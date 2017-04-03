using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS
{
    public partial class Main : Form
    {
        string MyConString;
        MySqlConnection connection;
        string query;

        public Main()
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
                            query = "SELECT usrtype FROM log WHERE userid = '" + uid + "'";
                            cmd = new MySqlCommand(query, connection);
                            cmd.ExecuteNonQuery();
                            String utype = Convert.ToString(cmd.ExecuteScalar());
                            //MessageBox.Show(utype);
                            if (utype=="admin")
                            {
                                TextWriter tw = new StreamWriter("date");
                                //MessageBox.Show(utype);
                                // write a line of text to the file
                                tw.WriteLine("admin");

                                // close the stream
                                tw.Close();

                                TextWriter issuer = new StreamWriter("rate");
                                issuer.WriteLine(uid);
                                issuer.Close();
                            }
                            else
                            {
                                TextWriter tw = new StreamWriter("date");
                                //MessageBox.Show(utype);
                                // write a line of text to the file
                                tw.WriteLine("normal");

                                // close the stream
                                tw.Close();

                                TextWriter issuer = new StreamWriter("rate");
                                issuer.WriteLine(uid);
                                issuer.Close();
                            }

                            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                            t.Start();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("User Name/Password does not Match");
                            main_user_txt.Text = "";
                            main_pass_txt.Text = "";
                            main_user_txt.Focus();
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
            /*SqlCeCommand cmd;
            SqlCeConnection conn =
            new SqlCeConnection(@"Data Source=|DataDirectory|\nainamitDatabase.sdf");
            conn.Open();

            //commands represent a query or a stored procedure
            /*SqlCeDataAdapter adap =
            new SqlCeDataAdapter("SELECT userid FROM LoginCheck WHERE userid = '" + main_user_txt.Text + "'", conn);
            DataTable dat = new DataTable();
            adap.Fill(dat);*/
            /*cmd = new SqlCeCommand("SELECT userid FROM LoginCheck WHERE userid = '" + main_user_txt.Text + "' AND password = '" + main_pass_txt.Text + "'", conn);
            try
            {
                cmd.ExecuteNonQuery();
                String uid = Convert.ToString(cmd.ExecuteScalar());
                if (string.IsNullOrEmpty(uid) == false)
                {
                    //MessageBox.Show(un);
                    /*var InfoForm = new InfoForm();
                    InfoForm.Show();*/

                        /*System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                        t.Start();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User Name/Password does not Match");
                    }
                }
                catch (SqlCeException sqlexception)
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
                    conn.Close();
                }
            }*/
            else
            {
                MessageBox.Show("User Name/Password can not be empty");
            }
        }

        private void main_cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
