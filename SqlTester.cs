using SQLTester.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace SQLTester
{
    public partial class SqlTester : Form
    {
        private List<long> baseTimesList = new List<long>();
        private List<long> prototypeTimesList = new List<long>();
        private List<long> optimizedTimesList = new List<long>();

        private int baseTimesCount = 0;
        private int prototypeTimesCount = 0;
        private int optimizedTimesCount = 0;

        private int executionTime = 0;
        private int executionBaseTime = 0;

        private Stopwatch executionStopwatch = new Stopwatch();
        private Stopwatch lapStopWatch = new Stopwatch();
        private Stopwatch baseStopWatch = new Stopwatch();
        private Random random = new Random();

        private SqlFunctions sqlTester = new SqlFunctions();
        private ReportFunctions reportFunctions = new ReportFunctions();


        public SqlTester()
        {
            InitializeComponent();
            resetCounters();

            baseTxt.Text = ConfigurationManager.AppSettings["BaseFile"];
            prototypeTxt.Text = ConfigurationManager.AppSettings["PrototypeFile"];
            resultsTxt.Text = ConfigurationManager.AppSettings["ReportLocation"];

            serverTxt.Text = ConfigurationManager.AppSettings["Server"];
            databaseTxt.Text = ConfigurationManager.AppSettings["Database"];
            userNameTxt.Text = ConfigurationManager.AppSettings["UserName"];
            passwordTxt.Text = ConfigurationManager.AppSettings["Password"];

         }



        private void executeButton_Click(object sender, EventArgs e)
        {
            executeButton.Enabled = false;
            executeButton.Text = "Executing Query";
            executionStopwatch.Start();

            string connectionString = $"Server={serverTxt.Text};Database={databaseTxt.Text};User Id={userNameTxt.Text};Password={passwordTxt.Text};";

            baseTimesList = new List<long>();
            prototypeTimesList = new List<long>();
            optimizedTimesList = new List<long>();

            if(baseTxt.Text != "") { baseTimesCount = 0; }

            baseStopWatch.Start();
            baseStopWatch.Stop();
            baseTimeLbl.Text = baseStopWatch.ElapsedMilliseconds.ToString() + " ms";
            String reportLocation = resultsTxt.Text;
            resetCounters();

            Console.WriteLine(baseTimesCount + "-"+ prototypeTimesCount+"-"+ optimizedTimesCount);
            do
            {
                switch(random.Next(0, 3))
                {
                    case 0: // Test Base
                        if(baseTimesCount < cyclesCount.Value)
                        {
                            String reportPath = reportLocation + "reportBase" + baseTimesCount.ToString() + ".txt";
                            reportFunctions.DeleteFile(reportPath);
                            lapStopWatch.Start();
                            sqlTester.ExecuteSqlFile(baseTxt.Text, reportPath, connectionString);
                            lapStopWatch.Stop();

                            baseTimesCount++;
                            baseTimesList.Add(lapStopWatch.ElapsedMilliseconds);
                            lapStopWatch.Reset();

                        }
                        break;
                    case 1:
                        if (prototypeTimesCount < cyclesCount.Value)
                        {
                            String reportPath = reportLocation + "reportPrototype" + prototypeTimesCount.ToString() + ".txt";
                            reportFunctions.DeleteFile(reportPath);
                            lapStopWatch.Start();
                            sqlTester.ExecuteSqlFile(prototypeTxt.Text, reportPath, connectionString);
                            lapStopWatch.Stop();

                            prototypeTimesCount++;
                            prototypeTimesList.Add(lapStopWatch.ElapsedMilliseconds);
                            lapStopWatch.Reset();
                        }
                        break;
                    case 2:
                        if (optimizedTimesCount < cyclesCount.Value)
                        {
                            String reportPath = reportLocation + "reportOptimized" + optimizedTimesCount.ToString() + ".txt";
                            reportFunctions.DeleteFile(reportPath);
                            lapStopWatch.Start();
                            sqlTester.ExecuteSqlFile(optimizedTxt.Text, reportPath, connectionString);
                            lapStopWatch.Stop();

                            optimizedTimesCount++;
                            optimizedTimesList.Add(lapStopWatch.ElapsedMilliseconds);
                            lapStopWatch.Reset();
                        }
                        break;
                    default: break;


                };
            }
            while (baseTimesCount < cyclesCount.Value || prototypeTimesCount < cyclesCount.Value || optimizedTimesCount < cyclesCount.Value);
            resetCounters();


            executionStopwatch.Stop();

            totalTimeLbl.Text = executionStopwatch.ElapsedMilliseconds.ToString() + " ms";
            baseExecutionLbl.Text = calcLabel(baseTimesList);
            prototypeExecutionLbl.Text = calcLabel(prototypeTimesList);
            optimizedExecutionLbl.Text = calcLabel(optimizedTimesList);

            executionStopwatch.Reset();

            resolveLbl.Text = resolveCompare();
            executeButton.Enabled = true;
            executeButton.Text = "Execute";
        }

        private String resolveCompare()
        {
            StringBuilder sb = new StringBuilder();

            int maxReturn = 0;

            for (int i = 0; i < cyclesCount.Value; i++)
            {
                String reportBase = resultsTxt.Text + "reportBase" + i.ToString() + ".txt";
                String reportPrototype = resultsTxt.Text + "reportPrototype" + i.ToString() + ".txt";

                int fileReturn = reportFunctions.CompareFiles(reportBase, reportPrototype);

                if (maxReturn < fileReturn) { maxReturn = fileReturn; }

                if (fileReturn > 0) { }

            }

            switch (maxReturn)
            {
                case 0:
                    sb.Append("Identical results");
                    break;
                case 1: // Generic error
                    sb.Append("Unidentified Error");
                    break;
                case 2: // Wrong Order
                    sb.Append("Wrong Lines Order");
                    break;
                case 3: // Diferent Size
                    sb.Append("Same size, Diferent results ");
                    break;
                case 4: // Diferent Size
                    sb.Append("Diferent Size");
                    break;
                case 5: //File do not exist
                    sb.Append("File do not exist");
                    break;
                default:
                    sb.Append("Not executed");
                    break;
            }


            return sb.ToString();
        }

        private void resetCounters()
        {
            baseTimesCount = (int)cyclesCount.Value;
            prototypeTimesCount = (int)cyclesCount.Value;
            optimizedTimesCount = (int)cyclesCount.Value;

            if (baseTxt.Text != "") { baseTimesCount = 0; }
            if (prototypeTxt.Text != "") { prototypeTimesCount = 0;  }
            if (optimizedTxt.Text != "") { optimizedTimesCount = 0;  }

        }

        private String calcLabel(List<long> values)
        {
            if(values == null || values.Count == 0)
            {
                return "Non executed.";
            }
            StringBuilder sb = new StringBuilder();
            long total = 0;
            long min = 9999999999;
            long max = 0;
            int quantity = 0;
            foreach (long value in values)
            {
                if (value < min) { min = value; };
                if (value > max) {  max = value; }
                total += value;
                quantity++;
            }

            float med = total / quantity;

            sb.Append("Total time: ");
            sb.Append(total);
            sb.Append(", cycles: ");
            sb.Append(quantity);
            sb.Append(", min: ");
            sb.Append(min);
            sb.Append(", med: ");
            sb.Append(med);
            sb.Append(", max: ");
            sb.Append(max);

            return sb.ToString();
        }

        private string searchFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return "";
        }

        private string searchFolder()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return "";
        }

        private void baseFindBtn_Click(object sender, EventArgs e)
        {
            baseTxt.Text = searchFile();
        }

        private void prototypeFindBtn_Click(object sender, EventArgs e)
        {
            prototypeTxt.Text = searchFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultsTxt.Text = searchFolder();
        }
    }
}
