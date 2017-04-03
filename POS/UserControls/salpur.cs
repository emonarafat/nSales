using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

namespace POS
{
    public partial class salpur : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        public static ArrayList Files = new ArrayList();
        public salpur()
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
            list_ex.Items.Clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM sold GROUP BY pid, date";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "sold");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "SOLD" + "" }));
                }

                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM purchased GROUP BY pid, date";
                adpt = new MySqlDataAdapter(query, connection);
                myDataSet = new DataSet();
                adpt.Fill(myDataSet, "purchased");
                myDataTable = myDataSet.Tables[0];
                tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "PURCHASED" + "" }));
                }

            }
            CloseConnection();
        }

        private void salpur_Load(object sender, EventArgs e)
        {
            
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT pid,gen FROM sold GROUP BY gen";
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl1.DataSource = dt;
                comboBox_lvl1.DisplayMember = "gen";
                comboBox_lvl1.ValueMember = "pid";
                //comboBox_lvl1.DataBind();
                query = "SELECT pid,tp FROM sold GROUP BY tp";
                //cmd = new MySqlCommand(query, connection);
                da = new MySqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl2.DataSource = dt;
                comboBox_lvl2.DisplayMember = "tp";
                comboBox_lvl2.ValueMember = "pid";

                query = "SELECT pid FROM sold GROUP BY pid";
                //cmd = new MySqlCommand(query, connection);
                da = new MySqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl3.DataSource = dt;
                comboBox_lvl3.DisplayMember = "pid";
                comboBox_lvl3.ValueMember = "pid";
                //close connection
                this.CloseConnection();

                //list_ex.Items.Clear();
                show_data();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM sold WHERE date BETWEEN'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' GROUP BY pid, date";
                //MessageBox.Show(dateTimePicker1.Value.ToShortDateString().ToString());
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "sold");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;
                list_ex.Items.Clear();
                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "SOLD" + "" }));
                }

                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM purchased WHERE date BETWEEN'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' GROUP BY pid, date";
                adpt = new MySqlDataAdapter(query, connection);
                myDataSet = new DataSet();
                adpt.Fill(myDataSet, "purchased");
                myDataTable = myDataSet.Tables[0];
                tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "PURCHASED" + "" }));
                }

            }
            CloseConnection();
        }

        private void button_sa_Click(object sender, EventArgs e)
        {
            //list_ex.Items.Clear();
            show_data();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_ex.Items)
            {
                if (item.Checked)
                {
                    string value = item.Text;
                    //MessageBox.Show(value);
                    establish_connection();
                    string query2 = "DELETE FROM sold WHERE pid='" + value + "'";

                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                        cmd2.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                }
            }
            //list_ex.Items.Clear();
            show_data();
        }

        private void btn_clall_Click(object sender, EventArgs e)
        {
            establish_connection();
            string query2 = "DELETE FROM sold";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                cmd2.ExecuteNonQuery();
                this.CloseConnection();
            }
            //list_ex.Items.Clear();
            show_data();
        }

        private void btn_exhist_Click(object sender, EventArgs e)
        {
            //this.Close();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_gen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_gen.Checked == true)
            {
                checkBox_tp.Checked = false;
                checkBoxmod.Checked = false;
                checkBox_pri.Checked = false;
                comboBox_lvl1.Visible = true;
                comboBox_lvl2.Visible = false;
                comboBox_lvl3.Visible = false;
                txt__plow.Visible = false;
                txt_phigh.Visible = false;
                label1.Visible = false;
                btn_search.Visible = false;
            }
            else
                comboBox_lvl1.Visible = false;
        }

        private void checkBox_tp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tp.Checked == true)
            {
                checkBox_gen.Checked = false;
                checkBoxmod.Checked = false;
                checkBox_pri.Checked = false;
                comboBox_lvl2.Visible = true;
                comboBox_lvl1.Visible = false;
                comboBox_lvl3.Visible = false;
                txt__plow.Visible = false;
                txt_phigh.Visible = false;
                label1.Visible = false;
                btn_search.Visible = false;
            }
            else
                comboBox_lvl2.Visible = false;
        }

        private void checkBoxmod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmod.Checked == true)
            {
                checkBox_tp.Checked = false;
                checkBox_gen.Checked = false;
                checkBox_pri.Checked = false;
                comboBox_lvl3.Visible = true;
                comboBox_lvl2.Visible = false;
                comboBox_lvl1.Visible = false;
                txt__plow.Visible = false;
                txt_phigh.Visible = false;
                label1.Visible = false;
                btn_search.Visible = false;
            }
            else
                comboBox_lvl3.Visible = false;
        }

        private void checkBox_pri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pri.Checked == true)
            {
                checkBox_tp.Checked = false;
                checkBoxmod.Checked = false;
                checkBox_gen.Checked = false;
                txt__plow.Visible = true;
                txt_phigh.Visible = true;
                label1.Visible = true;
                btn_search.Visible = true;
                comboBox_lvl1.Visible = false;
                comboBox_lvl2.Visible = false;
                comboBox_lvl3.Visible = false;
                establish_connection();
                if (this.OpenConnection() == true)
                {
                    query = "SELECT MAX(unitprice) FROM sold";
                    //MessageBox.Show(comboBox_lvl1.Text);
                    //cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    int someID = 0;
                    if (dt.Rows.Count == 1)
                    {
                        DataRow DR;
                        DR = dt.Rows[0];
                        someID = Convert.ToInt32(DR["MAX(unitprice)"]);
                    }
                    txt_phigh.Text = someID.ToString();
                    /*comboBox_lvl3.DisplayMember = "Price";
                    comboBox_lvl3.ValueMember = "Model";*/
                    //comboBox_lvl1.DataBind();

                    //close connection
                    this.CloseConnection();
                }
            }
            else
            {
                txt__plow.Visible = false;
                txt_phigh.Visible = false;
                label1.Visible = false;
                btn_search.Visible = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt__plow.Text) || string.IsNullOrEmpty(txt_phigh.Text))
            {

            }
            else
            {
                clear();
                establish_connection();
                if (this.OpenConnection() == true)
                {
                    query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM sold WHERE unitprice BETWEEN'" + txt__plow.Text + "' AND '" + txt_phigh.Text + "' GROUP BY pid, date";
                    MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                    DataSet myDataSet = new DataSet();
                    adpt.Fill(myDataSet, "sold");
                    DataTable myDataTable = myDataSet.Tables[0];
                    DataRow tempRow = null;

                    foreach (DataRow tempRow_Variable in myDataTable.Rows)
                    {
                        tempRow = tempRow_Variable;
                        //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                        list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "SOLD" + "" }));
                    }

                    query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM purchased WHERE unitprice BETWEEN'" + txt__plow.Text + "' AND '" + txt_phigh.Text + "' GROUP BY pid, date";
                    adpt = new MySqlDataAdapter(query, connection);
                    myDataSet = new DataSet();
                    adpt.Fill(myDataSet, "purchased");
                    myDataTable = myDataSet.Tables[0];
                    tempRow = null;

                    foreach (DataRow tempRow_Variable in myDataTable.Rows)
                    {
                        tempRow = tempRow_Variable;
                        //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                        list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "PURCHASED" + "" }));
                    }

                }
                CloseConnection();
            }
        }

        public void clear()
        {
            list_ex.Items.Clear();
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void comboBox_lvl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM sold WHERE gen='" + comboBox_lvl1.Text + "' GROUP BY pid, date";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "sold");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "SOLD" + "" }));
                }

                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM purchased WHERE gen='" + comboBox_lvl1.Text + "' GROUP BY pid, date";
                adpt = new MySqlDataAdapter(query, connection);
                myDataSet = new DataSet();
                adpt.Fill(myDataSet, "purchased");
                myDataTable = myDataSet.Tables[0];
                tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "PURCHASED" + "" }));
                }

            }
            CloseConnection();
        }

        private void comboBox_lvl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM sold WHERE tp='" + comboBox_lvl2.Text + "' GROUP BY pid, date";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "sold");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "SOLD" + "" }));
                }

                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM purchased WHERE tp='" + comboBox_lvl2.Text + "' GROUP BY pid, date";
                adpt = new MySqlDataAdapter(query, connection);
                myDataSet = new DataSet();
                adpt.Fill(myDataSet, "purchased");
                myDataTable = myDataSet.Tables[0];
                tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "PURCHASED" + "" }));
                }

            }
            CloseConnection();
        }

        private void comboBox_lvl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM sold WHERE pid='" + comboBox_lvl3.Text + "' GROUP BY pid, date";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "sold");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "SOLD" + "" }));
                }

                query = "SELECT pid, DATE(date), gen, tp, unitprice, SUM(quantity), SUM(amount) FROM purchased WHERE pid='" + comboBox_lvl3.Text + "' GROUP BY pid, date";
                adpt = new MySqlDataAdapter(query, connection);
                myDataSet = new DataSet();
                adpt.Fill(myDataSet, "purchased");
                myDataTable = myDataSet.Tables[0];
                tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["pid"] + "", Convert.ToDateTime(tempRow["DATE(date)"]).ToShortDateString() + "", tempRow["gen"] + "", tempRow["tp"] + "", tempRow["unitprice"] + "", tempRow["SUM(quantity)"] + "", tempRow["SUM(amount)"] + "", "PURCHASED" + "" }));
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
            tw.WriteLine("Product ID       Date          Generic          Type          Unit Price(TK)     Quantity          Amount(TK)          Sold/Purchased");
            tw.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            foreach (ListViewItem item in list_ex.Items)
            {
                if (list_ex.Items[i].SubItems[0].Text != "")
                {
                    tw.WriteLine(list_ex.Items[i].SubItems[0].Text + "_____" + list_ex.Items[i].SubItems[1].Text + "______" + list_ex.Items[i].SubItems[2].Text + "______" + list_ex.Items[i].SubItems[3].Text + "______" + list_ex.Items[i].SubItems[4].Text + "______" + list_ex.Items[i].SubItems[5].Text + "______" + list_ex.Items[i].SubItems[6].Text + "______" + list_ex.Items[i].SubItems[7].Text);
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
