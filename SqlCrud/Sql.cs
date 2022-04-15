using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SqlCrud
{
    
    class Sql
    {
        private static string _connectionString = @"Server=DESKTOP-J0OVA9S\SQLEXPRESS;Database=CinemaPlas;Trusted_Connection=True;";

        public static void Select(string query)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();

                    sda.Fill(table);
                    string ColName = "";
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        ColName = ColName + table.Columns[i].ColumnName + " ";
                    }
                    Console.WriteLine(ColName);
                    foreach (DataRow row in table.Rows)
                    {
                        string result= "";
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            result += row[i] + " ";
                        }
                        Console.WriteLine(result);
                    }

                }


            }

        }
        public static void Execute(string query)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query,conn))
                {

                    try
                    {
                        if (command.ExecuteNonQuery()>0)
                        {
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Not found");
                        
                    }
                }

            }



        }
             

    }
}
