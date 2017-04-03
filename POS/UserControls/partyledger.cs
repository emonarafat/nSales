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
    public partial class partyledger : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        DateTime thisDay = DateTime.Today;
        public partyledger()
        {
            InitializeComponent();
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //this.Close();
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
        public void dataupdate()
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT name FROM parties GROUP BY name";
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_banks.DataSource = dt;
                comboBox_banks.DisplayMember = "name";
                comboBox_banks.ValueMember = "name";

                /*combo_bb.DataSource = dt;
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
                comboBox_ac.ValueMember = "serial";*/
                //close connection
                this.CloseConnection();
            }
        }
        private void loan_Load(object sender, EventArgs e)
        {
            label3.Text=main_form.iname.ToUpper();
            label7.Text = thisDay.ToString("yyyy-MM-dd");
            dataupdate();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(thisDay.ToString("yyyy-MM-dd"));
            if (txt_amount.Text != "")
            {
                try
                {
                    establish_connection();
                    //int selprice = (Convert.ToInt32(txt_price.Text) * 30) / 100;
                    if (checkBox_in.Checked == true)
                        query = "INSERT INTO partyledger (partyname, address, amount, date, issuedby, paytype, mobile, phone) VALUES ('" + comboBox_banks.Text + "','" + label_address.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + label3.Text + "','" + "Advance" + "','" + label_mobile.Text + "','" + label_phone.Text + "')";
                    else
                        query = "INSERT INTO partyledger (partyname, address, amount, date, issuedby, paytype, mobile, phone) VALUES ('" + comboBox_banks.Text + "','" + label_address.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + label3.Text + "','" + "Due" + "','" + label_mobile.Text + "','" + label_phone.Text + "')";
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

                        MessageBox.Show("Transaction is Successful");
                    }

                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally 
                {
                    txt_subject.Text = "";
                    textBox_sub.Text = "";
                    txt_amount.Text = "";
                    checkBox_in.Checked = true;
                    txt_subject.Focus();
                }
            }
            else
            {
                MessageBox.Show("Fields Empty!");
            }
        }
        private void txt_num_product_KeyPress(object sender, KeyPressEventArgs e)
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
        public static void ThreadProc5()
        {
            //Application.Run(new partyledgerhist());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc5));
            t.Start();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataupdate();
        }

        private void btn_addingbank_Click(object sender, EventArgs e)
        {
            if (txt_subject.Text != "" && textBox_sub.Text != "" && textBox_mobile.Text != "")
            {
                establish_connection();

                query = "INSERT INTO parties (name, address, mobile, tel) VALUES ('" + txt_subject.Text + "','" + textBox_sub.Text + "','" + textBox_mobile.Text + "','" + textBox_phone.Text + "')";

                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                    txt_subject.Text = "";
                    textBox_sub.Text = "";
                    textBox_mobile.Text = "";
                    textBox_phone.Text = "";

                    MessageBox.Show("Party Information Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("Fields Empty");
                txt_subject.Text = "";
                textBox_sub.Text = "";
                textBox_mobile.Text = "";
                textBox_phone.Text = "";
            }
        }

        private void comboBox_banks_SelectedIndexChanged(object sender, EventArgs e)
        {
            establish_connection();

            string query = "SELECT address FROM parties WHERE name='" + comboBox_banks.Text + "'";
            string query2 = "SELECT mobile FROM parties WHERE name='" + comboBox_banks.Text + "'";
            string query3 = "SELECT tel FROM parties WHERE Model='" + comboBox_banks.Text + "'";
            

            //Open Connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //ExecuteScalar will return one value
                    label_address.Text = (cmd.ExecuteScalar() + "");
                    //MessageBox.Show(gen);
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    //ExecuteScalar will return one value
                    label_mobile.Text = (cmd2.ExecuteScalar() + "");
                    //MessageBox.Show(tp);
                    MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                    //ExecuteScalar will return one value
                    label_phone.Text = (cmd3.ExecuteScalar() + "");
                }
                catch (Exception)
                {
                            //
                }
                CloseConnection();
            }
        }
    }
}
