using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SQLTester.Functions
{
    internal class SqlFunctions
    {

        public void ExecuteSqlFile(string sqlFilePath, string outputFilePath, string _connectionString)
        {
            try
            {
                if (!File.Exists(sqlFilePath))
                {
                    throw new FileNotFoundException("SQL file not found.", sqlFilePath);
                }

                string query = File.ReadAllText(sqlFilePath);

                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            using (StreamWriter writer = new StreamWriter(outputFilePath))
                            {
                                // Write column headers
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    writer.Write(reader.GetName(i) + (i < reader.FieldCount - 1 ? "\t" : ""));
                                }
                                writer.WriteLine();

                                // Write data rows
                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        writer.Write(reader[i]?.ToString() + (i < reader.FieldCount - 1 ? "\t" : ""));
                                    }
                                    writer.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}
