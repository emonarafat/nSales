﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.IO;

namespace POS
{
    public partial class ledger : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        //MySqlCommand cmd;
        private System.ComponentModel.Container components = null;
        public ledger()
        {
            InitializeComponent();
        }

        public void establish_connection()
        {
            try
            {
                MyConString = "SERVER=localhost;DATABASE=shop;UID=root;PASSWORD=;";
                connection = new MySqlConnection(MyConString);
                //connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not Connect to Server");
            }
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void show_data()
        {
            list_account.Items.Clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM ledger";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "ledger");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_account.Items.Add(new ListViewItem(new string[] { Convert.ToDateTime(tempRow["date"]).ToShortDateString() + "", tempRow["accountname"] + "", tempRow["amount"] + "" }));
                }
                foreach (ListViewItem eachItem in list_account.Items)
                {
                    if (eachItem.SubItems[2].Text=="0")
                    {
                        list_account.Items.Remove(eachItem);
                    }
                }
            }
        }

        public void ledger_update()
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT accountname FROM ledger GROUP BY accountname";
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl1.DataSource = dt;
                comboBox_lvl1.DisplayMember = "accountname";
                comboBox_lvl1.ValueMember = "accountname";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
            //list_account.Items.Clear();
            show_data();
        }

        private void ledger_Load(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT accountname FROM ledger GROUP BY accountname";
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl1.DataSource = dt;
                comboBox_lvl1.DisplayMember = "accountname";
                comboBox_lvl1.ValueMember = "accountname";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
            //list_account.Items.Clear();
            show_data();
        }

        private void comboBox_lvl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_account.Items.Clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM ledger WHERE accountname='" + comboBox_lvl1.Text + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "ledger");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_account.Items.Add(new ListViewItem(new string[] { Convert.ToDateTime(tempRow["date"]).ToShortDateString() + "", tempRow["accountname"] + "", tempRow["amount"] + "" }));
                }
                foreach (ListViewItem eachItem in list_account.Items)
                {
                    if (eachItem.SubItems[2].Text == "0")
                    {
                        list_account.Items.Remove(eachItem);
                    }
                }
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button_sa_Click(object sender, EventArgs e)
        {
            //list_account.Items.Clear();
            ledger_update();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM ledger WHERE date BETWEEN'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                //MessageBox.Show(dateTimePicker1.Value.ToShortDateString().ToString());
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "ledger");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;
                list_account.Items.Clear();
                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_account.Items.Add(new ListViewItem(new string[] { Convert.ToDateTime(tempRow["date"]).ToShortDateString() + "", tempRow["accountname"] + "", tempRow["amount"] + "" }));
                }
                foreach (ListViewItem eachItem in list_account.Items)
                {
                    if (eachItem.SubItems[2].Text == "0")
                    {
                        list_account.Items.Remove(eachItem);
                    }
                }
            }
            CloseConnection();
        }
        System.IO.StreamReader fileToPrint;
        System.Drawing.Font printFont;
        private void btn_print_Click(object sender, EventArgs e)
        {
            int i = 0;
            string printPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            TextWriter tw = new StreamWriter(printPath + @"\myFile.txt");
            tw.WriteLine("#####" + lbl_title.Text + "#####");
            tw.WriteLine("Date               Particulars               Amount(TK)");
            tw.WriteLine("-------------------------------------------------------");
            foreach (ListViewItem item in list_account.Items)
            {
                if (list_account.Items[i].SubItems[0].Text != "")
                {
                    tw.WriteLine(list_account.Items[i].SubItems[0].Text + "_____" + list_account.Items[i].SubItems[1].Text + "_____" + list_account.Items[i].SubItems[2].Text);
                }
                i++;
            }
            tw.Close();

            fileToPrint = new System.IO.StreamReader(printPath + @"\myFile.txt");
            printFont = new System.Drawing.Font("Segoe UI Semibold", 8);
            printDocument1.Print();
            fileToPrint.Close();
            if (File.Exists(printPath + @"\myFile.txt"))
            {
                File.Delete(printPath + @"\myFile.txt");
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            float yPos = 10f;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            while (count < linesPerPage)
            {
                line = fileToPrint.ReadLine();
                if (line == null)
                {
                    break;
                }
                yPos = topMargin + count * printFont.GetHeight(e.Graphics);
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
            {
                e.HasMorePages = true;
            }
        }
    }
}
