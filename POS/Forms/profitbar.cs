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
    public partial class profitbar : Form
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        public static ArrayList Files = new ArrayList();
        public profitbar()
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
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                try
                {
                    query = "SELECT SUM(profit) FROM profit WHERE date BETWEEN'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    double prft = Convert.ToDouble(cmd.ExecuteScalar());
                    lbls.Text = prft.ToString() + "TK";

                    query = "SELECT SUM(Less) FROM profit WHERE date BETWEEN'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    double lss = Convert.ToDouble(cmd.ExecuteScalar());
                    lbll.Text = lss.ToString() + "TK";

                    lblp.Text = Convert.ToString(prft - lss) + "TK";
                }
                catch(Exception)
                {
                    MessageBox.Show("No Data to Show");
                }

                CloseConnection();
            }
        }

        private void button_sa_Click(object sender, EventArgs e)
        {
            show_data();
        }        

        public void show_data()
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT SUM(profit) FROM profit";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                double prft = Convert.ToDouble(cmd.ExecuteScalar());
                lbls.Text = prft.ToString() + "TK";

                query = "SELECT SUM(Less) FROM profit";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                double lss = Convert.ToDouble(cmd.ExecuteScalar());
                lbll.Text = lss.ToString() + "TK";

                lblp.Text = Convert.ToString(prft - lss) + "TK";

                CloseConnection();
            }
            
        }

        private void profitbar_Load(object sender, EventArgs e)
        {
            try
            {
                show_data();
            }
            catch (Exception)
            {
                MessageBox.Show("No Data to Show");
            }
        }
    }
}
