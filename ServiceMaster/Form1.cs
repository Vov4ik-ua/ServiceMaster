using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using View = System.Windows.Forms.View;
using MaterialSkin.Controls;
using Bunifu.Framework.UI;
using MetroFramework.Forms;
using Point = System.Drawing.Point;

namespace ServiceMaster
{
    public partial class ServiceMaster : Form
    {
        byte lasttab;
        bool editflag;
        public static string[] komp = new string[] { "АКБ", "МЗП", "Сумка", "Sim-karta" };
        public static string[] info = new string[] { "Потертості", "Царапини", "Сколи", "Тріщини" };

        public ServiceMaster()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 40;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17; //HTBOTTOMRIGHT
                    return;
                }
                else if (cursorPosition.X <= resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)16; //HTBOTTOMLEFT
                    return;
                }
                else if (cursorPosition.X <= resizeArea)
                {
                    m.Result = (IntPtr)10; //HTLEFT
                    return;
                }
                else if (cursorPosition.X >= ClientSize.Width - resizeArea)
                {
                    m.Result = (IntPtr)11; //HTRIGHT
                    return;
                }
                else if (cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)15; //HTBOTTOM
                    return;
                }
            }

            base.WndProc(ref m);
        }

        private void printandsave_Click(object sender, EventArgs e)
        {
            save_Click(this, e);
            Utility.editDocPrint(editflag ? 0 : Int32.Parse(nambellable.Text));
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //if (!File.Exists(@"protocol.doc")) { Properties.Resources.protocol }
            Utility.dbconect();
            updatelist("main");

            this.infolistchbox.Items.AddRange(info);

            this.komplistbox.Items.AddRange(komp);
            editflag = false;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;

        }
        private void save_Click(object sender, EventArgs e)
        {
            if (!editflag) { Utility.SqlCom(@"INSERT INTO 'order' (model, nespr, others, price, date, info, komp, IMEI, tel, Lname, name, complate, phone, end ) VALUES('" + modeltextbox.Text + "', '" + nesprtextbox.Text + "', '" + otherstextbox.Text + "', '" + pricetextbox.Text + "', '" + datenow.Text + "', '" + Utility.listitem(infolistchbox) + "', '" + Utility.listitem(komplistbox) + "', '" + imeitextbox.Text + "', '" + teltexbox.Text + "', '" + lnametextbox.Text + "', '" + nametextbox.Text + "', false, false, false )"); updatelist("add"); }

            else { Utility.SqlCom($"UPDATE 'order' SET model = '{modeltextbox.Text}', nespr = '{nesprtextbox.Text}', others = '{otherstextbox.Text}', price = '{pricetextbox.Text}', date = '{datenow.Text}', info = '{Utility.listitem(infolistchbox)}', komp = '{Utility.listitem(komplistbox)}', IMEI = '{imeitextbox.Text}', tel = '{teltexbox.Text}', Lname = '{lnametextbox.Text}', name = '{nametextbox.Text}', complate = '{complateCHbox.Checked}', phone = false, end = false WHERE _rowid_= '{nambellable.Text}' "); updatelist("main"); }
            edittab(-1);

        }
        public void updatelist(string str)
        {
            if (str == "main" || str == "")
            {
                str = "SELECT * FROM 'order'";
                this.dateView.Rows.Clear();
            }
            else if (str == "add")
            {
                str = @"SELECT `_rowid_`,* FROM `order` WHERE `id` LIKE (SELECT MAX(id) FROM 'order') ";
            } else
            {
                str = $"SELECT * FROM 'order' Where `model` LIKE '%{str}%' OR `name`LIKE '%{str}%' OR `Lname` LIKE '%{str}%'"; /// Пошук по трьох колонках
                this.dateView.Rows.Clear();
            }

            using (SQLiteCommand cmd = new SQLiteCommand(Utility.myConnection))
            {
                Utility.myConnection.Open();
                cmd.CommandText = str;
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string compl = "";
                        if ((bool)reader["complate"]) { compl = "Готово"; } else { compl = "Не готово"; };
                        this.dateView.Rows.Add(reader["id"], reader["model"], reader["nespr"], reader["Lname"], reader["name"], compl);
                    }
                    Utility.myConnection.Close();
                }
            }

        }
        //private void dateView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex != -1)
        //    {
        //        Utility.SqlCom("UPDATE `order` SET `complate`= " + dateView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value+ " WHERE _rowid_='"+dateView.Rows[e.RowIndex].Cells[0].Value+"'");

        //        ///updatelist("main");
        //    }
        //    dateView.Refresh();
        //}
        private void neworder_Click(object sender, EventArgs e)
        {

            if (TabControl.SelectedIndex != 1)
            {
                edittab(0);
            }
            else
            {
                edittab(-1);
            }

        }
        public void edittab(int id)
        {
            if (id == 0)
            {
                lasttab = (byte)TabControl.SelectedIndex;
                TabControl.SelectTab(1);
                allorder.Enabled = false;
                neworder.Text = "Скасувати";
                dockpanel.Visible = true;
                Search.Visible = false;
                {
                    DateTime thisDay = DateTime.Today;
                    datenow.Text = thisDay.ToShortDateString();         /// Дата 
                    using (SQLiteCommand cmd = new SQLiteCommand(Utility.myConnection))
                    {
                        Utility.myConnection.Open();

                        try
                        {
                            cmd.CommandText = "SELECT MAX(id) FROM 'order'";
                            nambellable.Text = ((long)cmd.ExecuteScalar() + 1).ToString();
                        }
                        catch
                        {
                            nambellable.Text = "1";
                        }
                        Utility.myConnection.Close();
                    }   /// Id
                    nametextbox.Text = "";
                    lnametextbox.Text = "";
                    modeltextbox.Text = "";
                    imeitextbox.Text = "";
                    nesprtextbox.Text = "";
                    pricetextbox.Text = "";
                    teltexbox.Text = "";
                    otherstextbox.Text = "";
                    listchadd("0;1", infolistchbox);
                    listchadd("", komplistbox);
                    complateCHbox.Checked = false;
                }
            }
            else if (id == -1)
            {
                editflag = false;
                Search.Visible = true;
                dockpanel.Visible = false;
                allorder.Enabled = true;
                neworder.Text = "Нове замовлення";
                TabControl.SelectTab(lasttab);
            }
            else
            {
                editflag = true;
                lasttab = (byte)TabControl.SelectedIndex;
                TabControl.SelectTab(1);
                allorder.Enabled = false;
                neworder.Text = "Скасувати";
                Search.Visible = false;
                dockpanel.Visible = true;

                using (SQLiteCommand cmd = new SQLiteCommand(Utility.myConnection))
                {
                    Utility.myConnection.Open();
                    cmd.CommandText = $"SELECT `_rowid_`,* FROM `order` WHERE `id` = {id} ";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            /////model, nespr, others, price, date, info, komp, IMEI, tel, Lname, name, complate, phone, end
                            nambellable.Text = reader["id"].ToString();
                            datenow.Text = reader["date"].ToString();
                            nametextbox.Text = reader["name"].ToString();
                            lnametextbox.Text = reader["Lname"].ToString();
                            modeltextbox.Text = reader["model"].ToString();
                            imeitextbox.Text = reader["IMEI"].ToString();
                            nesprtextbox.Text = reader["nespr"].ToString();
                            pricetextbox.Text = reader["price"].ToString();
                            teltexbox.Text = reader["tel"].ToString();
                            otherstextbox.Text = reader["others"].ToString();
                            listchadd(reader["info"].ToString(), infolistchbox);
                            listchadd(reader["komp"].ToString(), komplistbox);
                            complateCHbox.Checked = (bool)reader["complate"];


                        }
                        Utility.myConnection.Close();
                    }
                }

            }
        }    // якщо 0 то нове замовлення, якщо -1 то вийти.
        private void allorder_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(0);
            dockpanel.Visible = false;
            updatelist("main");
        }
        void listchadd(string s1, CheckedListBox chbox)
        {
            for (int i = 0; i < chbox.Items.Count; i++)
            {
                chbox.SetItemChecked(i, false);
            }
            try
            {
                int[] ints = s1.Split(';').Select(int.Parse).ToArray();
                foreach (int i in ints)
                {
                    chbox.SetItemChecked(i, true);
                }
            }
            catch
            {
               
               
            }

        }
        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updatelist(Search.Text);
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void dateView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (true) edittab(Convert.ToInt32(dateView.Rows[e.RowIndex].Cells["id"].FormattedValue));


        }
    }
}
