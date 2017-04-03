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
    public partial class payment : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        DateTime thisDay = DateTime.Today;

        public payment()
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

        private void pay_Load(object sender, EventArgs e)
        {
            label2.Text = thisDay.ToString("yyyy-MM-dd");
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT emname FROM loan";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl1.DataSource = dt;
                comboBox_lvl1.DisplayMember = "emname";
                comboBox_lvl1.ValueMember = "emname";
                //comboBox_lvl1.DataBind();
                                       
                //close connection
                this.CloseConnection();
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            double adv = 0;
            double amount = Convert.ToInt16(txt_amount.Text);
            double sal = Convert.ToInt16(label7.Text);
            double due = 0;

            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT due FROM loan WHERE emname = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                due = Convert.ToInt16(cmd.ExecuteScalar());
                //close connection
                this.CloseConnection();
            }
            MessageBox.Show(due.ToString());
            if (due < 0)
            {
                adv = adv + (sal - amount);
                due = -adv;
            }
            else if (due >= 0)
            {
                due = due - amount;
            }
            MessageBox.Show(due.ToString());
            establish_connection();
            //open connection
            if (this.OpenConnection() == true)
            {
                query = "UPDATE loan SET due='" + due + "',lstpaydate='" + thisDay.ToString("yyyy-MM-dd") + "',lstpaid='" + amount + "' WHERE emname='" + comboBox_lvl1.Text + "'";
                //create command and assign the query and connection from the constructor
                cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
            MessageBox.Show("Payment Information is Updated");
            comboBox_lvl1.Focus();
            txt_amount.Text = "";       
        }

        private void comboBox_lvl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT contact FROM loan WHERE emname = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                String salary = Convert.ToString(cmd.ExecuteScalar());

                label7.Text = salary;

                query = "SELECT due FROM loan WHERE emname = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(query, connection);
                cmd2.ExecuteNonQuery();
                int dd = Convert.ToInt16(cmd2.ExecuteScalar());
                string advance="";
                if (dd < 0)
                {
                    dd = -dd;
                    advance = Convert.ToString(dd);
                }
                else
                    advance = "0";

                label4.Text = advance;
                //close connection
                this.CloseConnection();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
