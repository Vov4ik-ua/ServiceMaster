using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace ServiceMaster 
{
    public class Utility : ServiceMaster
    {
        static public SQLiteConnection myConnection;
        static public SQLiteCommand command = new SQLiteCommand(myConnection);
        
        static public void dbconect()
        {

            if (!File.Exists(@"./database.db3"))
            {
                SQLiteConnection.CreateFile(@"database.db3");
                MessageBox.Show("Created DB");
                myConnection = new SQLiteConnection(@"Data Source=database.db3");
                SqlCom(@"CREATE TABLE 
                        [order] (
                        [id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        [model] TEXT NULL,
                        [nespr] TEXT NULL,
                        [others] TEXT NULL,
                        [price] TEXT NULL,
                        [date] TEXT NULL,
                        [info] TEXT NULL,
                        [komp] TEXT NULL,
                        [IMEI] TEXT NULL,
                        [tel] TEXT NULL,
                        [Lname] TEXT NULL,
                        [name] TEXT NULL,
                        [complate] BOOLEAN DEFAULT 0,
                        [phone] BOOLEAN DEFAULT 0,
                        [end] BOOLEAN DEFAULT 0 )");
            }
            else {
                myConnection = new SQLiteConnection(@"Data Source=database.db3");
            }

        }
        static public void SqlCom(string sql)
        {
            

            using (SQLiteCommand cmd = new SQLiteCommand(Utility.myConnection))
            {
                myConnection.Open();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                myConnection.Close();
                
            }
        }
        static public void ReplaceWordStub(string stubToReplace, string text, Microsoft.Office.Interop.Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        static public string listitem(CheckedListBox list)
        {
            string str = "";
            foreach (var item in list.CheckedIndices)
            {
                if (str == "")
                {
                    str += item.ToString();
                }
                else
                {
                    str += ";" + item.ToString();
                }
            }

            return str;
        }
        static public string listitem(string s1, string[] array)
        {
            string str = "";
            int[] ints = s1.Split(';').Select(int.Parse).ToArray();
            foreach (int i in ints)
            {
                if (str == "")
                {
                    str += array[i];
                }
                else
                {
                    str += ", " + array[i].ToLower();
                }
            }

            return str;
        }
        static public void cmd(string com) {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C "+ com;
            process.StartInfo = startInfo;
            process.Start();
        }
        /*async*/ static public void editDocPrint(int id) {
            string str;
            if (id == 0)
            {
                str = @"SELECT `_rowid_`,* FROM `order` WHERE `id` LIKE (SELECT MAX(id) FROM 'order') ";
            }
            else
            {
                str = @"SELECT `_rowid_`,* FROM `order` WHERE `id` LIKE "+ id.ToString() +" ";
            }
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(Utility.myConnection))
                {
                    Utility.myConnection.Open();
                    cmd.CommandText = str;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //await Task.Run(() =>
                            //{
                            object fileName = System.Windows.Forms.Application.StartupPath + "\\protocol.doc";
                            Microsoft.Office.Interop.Word.Application WordApplication = new Microsoft.Office.Interop.Word.Application();
                            WordApplication.Visible = false; //выводим документ на экран
                            Microsoft.Office.Interop.Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            for (int i = 0; i < 2; i++)
                            {
                                try
                                {
                                    ///(model, nespr, others, price, date, info, komp, IMEI, tel, Lname, name, complate, phone, end )
                                    Utility.ReplaceWordStub("{id}", reader["id"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{model}", reader["model"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{nespr}", reader["nespr"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{others}", reader["others"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{price}", reader["price"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{date}", reader["date"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{info}", listitem(reader["info"].ToString(), info), WordDocument);
                                    Utility.ReplaceWordStub("{komp}", listitem(reader["komp"].ToString(), komp), WordDocument);
                                    Utility.ReplaceWordStub("{IMEI}", reader["IMEI"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{tel}", reader["tel"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{Lname}", reader["Lname"].ToString(), WordDocument);
                                    Utility.ReplaceWordStub("{name}", reader["name"].ToString(), WordDocument);
                                }
                                catch { MessageBox.Show("Произошла ошибка"); }
                            }
                            WordDocument.PrintOut();
                            Thread.Sleep(1000);
                            WordApplication.Application.Quit(false);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(WordApplication);
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(WordDocument);
                            //});
                        }
                        Utility.myConnection.Close();
                    }
                }
            }
            catch { MessageBox.Show("Помилка"); Utility.myConnection.Close(); }               
        }
    }
}
