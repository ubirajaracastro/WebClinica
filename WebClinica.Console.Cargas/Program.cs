using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace WebClinica.Console.Cargas
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = "C:\\WebClinica\\TabelaTUSS2.xls";

            ReadExcelFile("page1", caminho);



        }


        private static void ReadExcelFile(string sheetName, string path)
        {

            using (OleDbConnection conn = new OleDbConnection())
            {
                DataTable dt = new DataTable();
                string Import_FileName = path;
                string fileExtension = Path.GetExtension(Import_FileName);
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
                using (OleDbCommand comm = new OleDbCommand())
                {
                    comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dt);


                        string pathFile = @"c:\WebClinica\TUSS.txt";
                        StreamWriter sw = File.CreateText(pathFile);

                        foreach (DataRow row in dt.Rows) // Loop over the rows.
                        {
                            System.Console.WriteLine("--- Row ---"); // Print separator.
                            sw.WriteLine("Row");
                            foreach (var item in row.ItemArray) // Loop over the items.
                            {
                                System.Console.Write("Item: "); // Print label.
                                sw.Write("Item");
                                sw.WriteLine(item);
                                System.Console.WriteLine(item); // Invokes ToString abstract method.
                                                                                              

                            }
                        }
                        System.Console.Read();

                            


                        
                    }

                }
            }
        }

      
    }
}
