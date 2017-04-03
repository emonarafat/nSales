using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class salhist : Form
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        public static ArrayList Files = new ArrayList();
        public salhist()
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
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM salaryhistory";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "salaryhistory");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { Convert.ToDateTime(tempRow["date"]).ToShortDateString() + "", tempRow["idnum"] + "", tempRow["emname"] + "", tempRow["amount"] + "" }));
                }
            }
            CloseConnection();
        }

        private void salhist_Load(object sender, EventArgs e)
        {
            show_data();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM salaryhistory WHERE date BETWEEN'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                //MessageBox.Show(dateTimePicker1.Value.ToShortDateString().ToString());
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "salaryhistory");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;
                list_ex.Items.Clear();
                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { Convert.ToDateTime(tempRow["date"]).ToShortDateString() + "", tempRow["idnum"] + "", tempRow["emname"] + "", tempRow["amount"] + "" }));
                }
            }
            CloseConnection();
        }

        private void button_sa_Click(object sender, EventArgs e)
        {
            list_ex.Items.Clear();
            show_data();
        }
        System.IO.StreamReader fileToPrint;
        System.Drawing.Font printFont;
        private void btn_print_Click(object sender, EventArgs e)
        {
            int i = 0;
            string printPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            TextWriter tw = new StreamWriter(printPath + @"\myFile.txt");
            tw.WriteLine("#####Gate Pass History#####");
            tw.WriteLine("Date               Employee ID               Employee Name             Amount(TK)");
            tw.WriteLine("---------------------------------------------------------------------------------");
            foreach (ListViewItem item in list_ex.Items)
            {
                if (list_ex.Items[i].SubItems[0].Text != "")
                {
                    tw.WriteLine(list_ex.Items[i].SubItems[0].Text + "_____" + list_ex.Items[i].SubItems[1].Text + "_____" + list_ex.Items[i].SubItems[2].Text + "_____" + list_ex.Items[i].SubItems[3].Text);
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
