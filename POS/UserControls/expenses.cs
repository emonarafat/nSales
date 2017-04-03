using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace POS
{
    public partial class expenses : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        public expenses()
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

        private void txt_spent_amount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void expenses_Load(object sender, EventArgs e)
        {
            /*establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT serial,expensetype FROM expenses GROUP BY expensetype";
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl1.DataSource = dt;
                comboBox_lvl1.DisplayMember = "expensetype";
                comboBox_lvl1.ValueMember = "Serial";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();

            }*/
            // create reader & open file
            TextReader tr = new StreamReader("date");

            // read a line of text
            string utype = tr.ReadLine();
            if (utype == "admin")
            {
                //MessageBox.Show(utype);
                panel2.Visible = false;
                main_cancel_btn.Visible = false;
            }

            label1.Text = main_form.iname.ToUpper();

        }

        private void btn_Entry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_spent_amount.Text))
            {
                DateTime thisDay = DateTime.Today;
                //string value = item.Text;
                //MessageBox.Show(value);
                establish_connection();

                query = "SELECT serial FROM expenses";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "expenses");
                DataTable myDataTable = myDataSet.Tables[0];
                //DataRow tempRow = null;
                int i = 0;
                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    i++;
                    /* tempRow = tempRow_Variable;
                     //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                     list_stock.Items.Add(new ListViewItem(new string[] { tempRow["Model"] + "", tempRow["Generic"] + "", tempRow["Type"] + "", tempRow["Price"] + "", tempRow["Available"] + "" }));*/
                }
                i++;
                query = "INSERT INTO expenses (serial, amount, expensetype, date) VALUES ('" + i + "','" + Convert.ToDouble(txt_spent_amount.Text) + "','" + comboBox_lvl1.Text + "','" + thisDay.ToString("d") + "')";

                //cmd = new MySqlCommand(query, connection);
                //un = (String)cmd.ExecuteScalar();
                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                    MessageBox.Show("Entry is Done Successfully");
                    txt_spent_amount.Text = "";
                }
            }
            else
                MessageBox.Show("Field Empty!");
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
                            query = "SELECT usrtype FROM log WHERE userid = '" + uid + "'";
                            cmd = new MySqlCommand(query, connection);
                            cmd.ExecuteNonQuery();
                            String utype = Convert.ToString(cmd.ExecuteScalar());
                            //MessageBox.Show(utype);
                            if (utype == "admin")
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
                                MessageBox.Show("You have to be an Admin to Access this Area!");
                                main_pass_txt.Text = "";
                                main_user_txt.Text = "";
                            }
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

        private void main_cancel_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
