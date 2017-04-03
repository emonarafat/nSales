using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS
{
    public partial class banking : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        DateTime thisDay = DateTime.Today;

        public banking()
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
        private void checkBox_in_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_in.Checked == true)
                checkBox_out.Checked = false;
            else
                checkBox_out.Checked = true;
        }

        private void checkBox_out_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_out.Checked == true)
                checkBox_in.Checked = false;
            else
                checkBox_in.Checked = true;
        }

        public void dataupdate()
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT serial, bankname FROM nameofbanks GROUP BY bankname";
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_banks.DataSource = dt;
                comboBox_banks.DisplayMember = "bankname";
                comboBox_banks.ValueMember = "serial";

                combo_bb.DataSource = dt;
                combo_bb.DisplayMember = "bankname";
                combo_bb.ValueMember = "serial";

                query = "SELECT serial, accountnum FROM accounts WHERE bankname='" + comboBox_banks.Text + "'";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                da = new MySqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                comboBox_ac.DataSource = dt;
                comboBox_ac.DisplayMember = "accountnum";
                comboBox_ac.ValueMember = "serial";
                //close connection
                this.CloseConnection();
            }
        }

        private void banking_Load(object sender, EventArgs e)
        {
            label7.Text = thisDay.ToString("yyyy-MM-dd");
            label1.Text = main_form.iname.ToUpper();
            dataupdate();
        }

        private void btn_addac_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btn_addingbank_Click(object sender, EventArgs e)
        {
            if (txt_bb.Text != "")
            {
                establish_connection();

                query = "INSERT INTO nameofbanks (bankname) VALUES ('" + txt_bb.Text + "')";

                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                    txt_bb.Text = "";

                    MessageBox.Show("Bank Information Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("Field Empty!");
            }
        }

        private void btn_addingaccount_Click(object sender, EventArgs e)
        {
            if (txt_acc.Text != "" && combo_bb.Text != "")
            {
                establish_connection();

                query = "INSERT INTO accounts (bankname, accountnum) VALUES ('" + combo_bb.Text + "','" + txt_acc.Text + "')";

                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                    combo_bb.Text = "";
                    txt_acc.Text = "";

                    MessageBox.Show("Account Information Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("Fields Empty!");
            }
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

        private void comboBox_banks_SelectedIndexChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT serial, accountnum FROM accounts WHERE bankname='" + comboBox_banks.Text + "'";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_ac.DataSource = dt;
                comboBox_ac.DisplayMember = "accountnum";
                comboBox_ac.ValueMember = "serial";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataupdate();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            dataupdate();
        }

        private void btn_addb_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            if (txt_party.Text != "" && comboBox_banks.Text != "" && comboBox_ac.Text != "" && comboBox1.Text != "" && txt_amount.Text != "")
            {
                establish_connection();

                query = "INSERT INTO banking (date, subject, bankname, acnum, catagory, amount, type, issuedby) VALUES ('" + thisDay.ToString("yyyy-MM-dd") + "','" + txt_party.Text + "','" + comboBox_banks.Text + "','" + comboBox_ac.Text + "','" + comboBox1.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + "OUT" + "','" + label1.Text + "')";
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
                    txt_party.Text = "";
                    comboBox_banks.Text = "";
                    comboBox_ac.Text = "";
                    txt_amount.Text = "";
                    comboBox1.Text = "";
                    textBox1.Visible = false;
                    MessageBox.Show("Bank Statement Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("Fields Emty!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Check")
            {
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
            }
        }
    }
}
