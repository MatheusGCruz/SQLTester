using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTester.Functions
{
    internal class ReportFunctions
    {

        public int CompareFiles(string file1, string file2)
        {
            if (!File.Exists(file1) || !File.Exists(file2))
            {
                return 5;
            }

            string[] lines1 = File.ReadAllLines(file1);
            string[] lines2 = File.ReadAllLines(file2);

            if (lines1.Length != lines2.Length)
            {
                return 4; // Different size
            }

            List<int> differentLines = new List<int>();
            int minLength = Math.Min(lines1.Length, lines2.Length);
            HashSet<string> lines1Set = new HashSet<string>(lines1);
            HashSet<string> lines2Set = new HashSet<string>(lines2);

            var commonLines = lines1Set.Intersect(lines2Set).ToList();

            for (int i = 0; i < minLength; i++)
            {
                if (lines1[i] != lines2[i])
                {
                    differentLines.Add(i + 1);
                }
            }

            if (differentLines.Count > 0)
            {
                if(commonLines.Count == differentLines.Count) { 
                    return 2; //Same lines, Different position
                }
                return 3; //Different lines
            }
            else if (lines1.Length == lines2.Length)
            {
                return 0; // Identical files
            }

            return 1;
        }

        public void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }

}

