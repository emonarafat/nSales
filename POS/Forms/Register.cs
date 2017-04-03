using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS
{
    public partial class Register : Form
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        public Register()
        {
            InitializeComponent();
        }

        public static void ThreadProc()
        {

            Application.Run(new main_form());

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
        String uname;
        private void register_ok_btn_Click(object sender, EventArgs e)
        {
            if (register_user_txt.Text != "" && register_pass_txt.Text != "" && register_repass_txt.Text != "")
            {
                if (register_pass_txt.Text == register_repass_txt.Text)
                {

                    establish_connection();
                    if (this.OpenConnection() == true)
                    {
                        query = "SELECT userid FROM log WHERE userid = '" + register_user_txt.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            uname = Convert.ToString(cmd.ExecuteScalar());
                        }
                        catch (Exception)
                        {
                        }

                        if (String.IsNullOrEmpty(uname))
                        {
                            query = "INSERT INTO log (userid, password, usrtype) VALUES ('" + register_user_txt.Text + "' , '" + register_pass_txt.Text + "' , '" + comboBox_utype.Text + "' )";
                            cmd = new MySqlCommand(query, connection);
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception)
                            {
                            }
                            MessageBox.Show("New User Added. UserID: " + register_user_txt.Text + " Password: " + register_pass_txt.Text + "");
                        }
                        else
                        {
                            MessageBox.Show("Username Alraedy exist!! Please try a different one.");
                        }
                        this.CloseConnection();
                    }
                    
                    register_user_txt.Text = "";
                    register_pass_txt.Text = "";
                    register_repass_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Enter the Same Password Twice!");
                    register_pass_txt.Text = "";
                    register_repass_txt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please fill the fields Properly");
            }
        }

        private void register_exit_btn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void button_show_user_Click(object sender, EventArgs e)
        {
            list_ex.Items.Clear();
            show_data();
            panel_usershow.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_usershow.Visible = false;
        }

        public void show_data()
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT userid, usrtype FROM log";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "log");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    list_ex.Items.Add(new ListViewItem(new string[] { tempRow["userid"] + "", tempRow["usrtype"] + "" }));
                }
            }
            CloseConnection();
        }

        private void panel_usershow_Paint(object sender, PaintEventArgs e)
        {
            
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
                    string query2 = "DELETE FROM log WHERE userid='" + value + "'";

                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                        cmd2.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                }
            }
            list_ex.Items.Clear();
            show_data();
        }
    }
}
