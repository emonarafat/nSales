using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class attendance : Form
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        //MySqlCommand cmd;
        DateTime thisDay2 = DateTime.Today;
        public attendance()
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

        private void btnattend_Click(object sender, EventArgs e)
        {
            establish_connection();
            //open connection
            if (this.OpenConnection() == true)
            {
                query = "SELECT lastattend FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                String lstd = Convert.ToString(cmd.ExecuteScalar());

                query = "SELECT attendance FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                int attd = Convert.ToInt16(cmd.ExecuteScalar());
                if (Convert.ToDateTime(lstd) != Convert.ToDateTime(label2.Text))
                {
                    attd++;
                    query = "UPDATE loan SET lastattend='" + thisDay2.ToString("yyyy-MM-dd") + "',attendance='" + attd + "' WHERE idnum='" + comboBox_lvl1.Text + "'";
                    //create command and assign the query and connection from the constructor
                    cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                }
                else
                {

                }
                this.CloseConnection();
            }
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            label2.Text = thisDay2.ToString("yyyy-MM-dd");
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT idnum FROM loan";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl1.DataSource = dt;
                comboBox_lvl1.DisplayMember = "idnum";
                comboBox_lvl1.ValueMember = "idnum";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
        }
        private void comboBox_lvl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT emname FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                lblemname.Text = Convert.ToString(cmd.ExecuteScalar());                
                //close connection
                this.CloseConnection();
            }
        }
    }
}
