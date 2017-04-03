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
    public partial class stock : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        public static ArrayList Files = new ArrayList();
        public stock()
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

        public void clear()
        {
            list_stock.Items.Clear();
        }

        private void stock_Load(object sender, EventArgs e)
        {

            //show_data();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT Model,Generic FROM products GROUP BY Generic";
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl1.DataSource = dt;
                comboBox_lvl1.DisplayMember = "Generic";
                comboBox_lvl1.ValueMember = "Model";
                //comboBox_lvl1.DataBind();
                query = "SELECT Model,Type FROM products GROUP BY Type";
                //cmd = new MySqlCommand(query, connection);
                da = new MySqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl2.DataSource = dt;
                comboBox_lvl2.DisplayMember = "Type";
                comboBox_lvl2.ValueMember = "Model";

                query = "SELECT Model FROM products";
                //cmd = new MySqlCommand(query, connection);
                da = new MySqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl3.DataSource = dt;
                comboBox_lvl3.DisplayMember = "Model";
                comboBox_lvl3.ValueMember = "Model";
                //close connection
                this.CloseConnection();
            }

            // create reader & open file
            TextReader tr = new StreamReader("date");

            // read a line of text
            string utype = tr.ReadLine();
            //MessageBox.Show(utype);
            if (utype == "admin")
            {
                //MessageBox.Show(utype);
                panel2.Visible = false;
            }
        }

        public void show_data()
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM products";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "products");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_stock.Items.Add(new ListViewItem(new string[] { tempRow["Model"] + "", tempRow["Generic"] + "", tempRow["Type"] + "", tempRow["purpcode"] + "", tempRow["SellingPrice"] + "", tempRow["Available"] + "" }));
                }
            }
            CloseConnection();
        }

        private void btn_removeitem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_stock.Items)
            {
                if (item.Checked)
                {
                    string value = item.Text;
                    //MessageBox.Show(value);
                    establish_connection();
                    string query2 = "DELETE FROM products WHERE Model='" + value + "'";

                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                        cmd2.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                }
            }
            list_stock.Items.Clear();
            show_data();
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
                    query = "SELECT MAX(SellingPrice) FROM products";
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
                        someID = Convert.ToInt32(DR["MAX(SellingPrice)"]);
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

        private void comboBox_lvl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM products WHERE Generic='" + comboBox_lvl1.Text + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "products");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_stock.Items.Add(new ListViewItem(new string[] { tempRow["Model"] + "", tempRow["Generic"] + "", tempRow["Type"] + "", tempRow["purpcode"] + "", tempRow["SellingPrice"] + "", tempRow["Available"] + "" }));
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
                query = "SELECT * FROM products WHERE Type='" + comboBox_lvl2.Text + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "products");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_stock.Items.Add(new ListViewItem(new string[] { tempRow["Model"] + "", tempRow["Generic"] + "", tempRow["Type"] + "", tempRow["purpcode"] + "", tempRow["SellingPrice"] + "", tempRow["Available"] + "" }));
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
                query = "SELECT * FROM products WHERE Model='" + comboBox_lvl3.Text + "'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "products");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_stock.Items.Add(new ListViewItem(new string[] { tempRow["Model"] + "", tempRow["Generic"] + "", tempRow["Type"] + "", tempRow["purpcode"] + "", tempRow["SellingPrice"] + "", tempRow["Available"] + "" }));
                }
            }
            CloseConnection();
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
                    query = "SELECT * FROM products WHERE SellingPrice BETWEEN'" + txt__plow.Text + "' AND '" + txt_phigh.Text + "'";
                    MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                    DataSet myDataSet = new DataSet();
                    adpt.Fill(myDataSet, "products");
                    DataTable myDataTable = myDataSet.Tables[0];
                    DataRow tempRow = null;

                    foreach (DataRow tempRow_Variable in myDataTable.Rows)
                    {
                        tempRow = tempRow_Variable;
                        //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                        list_stock.Items.Add(new ListViewItem(new string[] { tempRow["Model"] + "", tempRow["Generic"] + "", tempRow["Type"] + "", tempRow["purpcode"] + "", tempRow["SellingPrice"] + "", tempRow["Available"] + "" }));
                    }
                }
                CloseConnection();
            }
        }

        private void main_ok_btn_Click(object sender, EventArgs e)
        {
            if (main_pass_txt.Text != "" && main_user_txt.Text != "")
            {
                establish_connection();

                query = "SELECT userid FROM log WHERE userid = '" + main_user_txt.Text + "' AND password = '" + main_pass_txt.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                if (this.OpenConnection() == true)
                {

                    try
                    {
                        cmd.ExecuteNonQuery();
                        String uid = Convert.ToString(cmd.ExecuteScalar());
                        if (string.IsNullOrEmpty(uid) == false)
                        {
                            //MessageBox.Show(un);
                            /*var InfoForm = new InfoForm();
                            InfoForm.Show();*/

                            panel2.Visible = false;
                            main_pass_txt.Text = "";
                            main_user_txt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("User Name/Password does not Match");
                            main_pass_txt.Text = "";
                            main_user_txt.Text = "";
                        }
                    }
                    catch (MySqlException sqlexception)
                    {
                        MessageBox.Show(sqlexception.Message, "Oh Fudge.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fooey.", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.CloseConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("User Name/Password can not be empty");
            }
        }

        public void pro()
        {
            panel2.Visible = true;
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            checkBox_tp.Checked = false;
            checkBox_gen.Checked = false;
            checkBox_pri.Checked = false;
            comboBox_lvl3.Visible = false;
            comboBox_lvl2.Visible = false;
            comboBox_lvl1.Visible = false;
            txt__plow.Visible = false;
            txt_phigh.Visible = false;
            label1.Visible = false;
            btn_search.Visible = false;

            clear();
            show_data();
            
        }
    }
}
