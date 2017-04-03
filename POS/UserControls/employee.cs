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
    public partial class employee : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        //string paid = "Paid";
        //string done = "Done";
        //int Count = 0;
        DateTime thisDay2 = DateTime.Today;

        public employee()
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
            list_employee.Items.Clear();
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT * FROM loan";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, connection);
                DataSet myDataSet = new DataSet();
                adpt.Fill(myDataSet, "loan");
                DataTable myDataTable = myDataSet.Tables[0];
                DataRow tempRow = null;

                string dueitem="";
                string advitem = "";

                foreach (DataRow tempRow_Variable in myDataTable.Rows)
                {
                    tempRow = tempRow_Variable;
                    if (Convert.ToInt16(tempRow["due"]) >= 0)
                    {
                        dueitem = Convert.ToString(tempRow["due"]);
                        advitem = "0";
                    }
                    else
                    {
                        advitem = Convert.ToString(Convert.ToInt16(tempRow["due"]) * (-1));
                        dueitem = "0";
                    }
                    //list_stock.Items.Add((tempRow["Model"] + " (" + tempRow["Generic"] + ")" + " (" + tempRow["Type"] + ")" + " (" + tempRow["Price"] + ")"));
                    if (!String.IsNullOrEmpty(Convert.ToString(tempRow["lstpaydate"])))
                    {
                        list_employee.Items.Add(new ListViewItem(new string[] { tempRow["idnum"] + "", tempRow["emname"] + "", tempRow["contact"] + "", tempRow["lstpaid"] + "", Convert.ToDateTime(tempRow["lstpaydate"]).ToShortDateString() + "", advitem + "", dueitem + "" }));
                    }
                    else
                        list_employee.Items.Add(new ListViewItem(new string[] { tempRow["idnum"] + "", tempRow["emname"] + "", tempRow["contact"] + "", tempRow["lstpaid"] + "", "" + "", advitem + "", dueitem + "" }));
                }
            }
        }

        private void employee_Load(object sender, EventArgs e)
        {
            show_data();

        }

        /*pay frm_pay = new pay();

        payment usrcon_pay = new payment();*/

        private void btn_payment_Click(object sender, EventArgs e)
        {
            double adv = 0;
            double amount = Convert.ToDouble(txt_amount.Text);
            double sal = Convert.ToDouble(label7.Text);
            double due = 0;

            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT due FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                due = Convert.ToInt16(cmd.ExecuteScalar());

                //close connection
                this.CloseConnection();
            }
            //MessageBox.Show(due.ToString());
            if (due < 0)
            {
                adv = adv + (sal - amount);
                due = -adv;
            }
            else if (due >= 0)
            {
                due = due - amount;
            }
            //MessageBox.Show(due.ToString());
            establish_connection();
            //open connection
            if (this.OpenConnection() == true)
            {                
                query = "UPDATE loan SET due='" + due + "',lstpaydate='" + thisDay2.ToString("yyyy-MM-dd") + "',lstpaid='" + amount + "' WHERE idnum='" + comboBox_lvl1.Text + "'";
                //create command and assign the query and connection from the constructor
                cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                query = "INSERT INTO salaryhistory (emname, amount, date, idnum) VALUES ('" + lblemname.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + thisDay2.ToString("yyyy-MM-dd") + "','" + comboBox_lvl1.Text + "')";
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
                query = "SELECT emname FROM loan WHERE idnum='" + comboBox_lvl1.Text + "'";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string name = "";
                if (dt.Rows.Count == 1)
                {
                    DataRow DR;
                    DR = dt.Rows[0];
                    name = Convert.ToString(DR["emname"]);
                }
                lblemname.Text = name;

                query = "SELECT contact FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                String salary = Convert.ToString(cmd.ExecuteScalar());

                label7.Text = salary;

                query = "SELECT due FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(query, connection);
                cmd2.ExecuteNonQuery();
                double dd = Convert.ToDouble(cmd2.ExecuteScalar());
                string advance = "";
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
            list_employee.Items.Clear();
            show_data();
            panel2.Visible = false;            
        }

        private void btn_pay_Click(object sender, EventArgs e)
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

            /*frm_pay.ShowDialog();
            panel2.Controls.Remove(usrcon_pay);
            panel2.Controls.Add(usrcon_pay);*/
            panel2.Visible = true;

            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT attendance FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                int atd = Convert.ToInt16(cmd.ExecuteScalar());

                label14.Text = atd.ToString() + "Day(s)";

                query = "SELECT perday FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                int pam = Convert.ToInt16(cmd.ExecuteScalar());

                label16.Text = Convert.ToString(pam*atd) + "TK";

                query = "SELECT contact FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                String salary = Convert.ToString(cmd.ExecuteScalar());

                label7.Text = salary;

                query = "SELECT due FROM loan WHERE idnum = '" + comboBox_lvl1.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(query, connection);
                cmd2.ExecuteNonQuery();
                double dd = Convert.ToDouble(cmd2.ExecuteScalar());
                string advance = "";
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
            /*int total = 0;
            foreach (ListViewItem item in list_employee.Items)
            {
                if (item.Checked)
                {
                    DateTime thisDay = DateTime.Today;
                    string value = item.Text;
                    //MessageBox.Show(value);
                    establish_connection();
                    string query2 = "SELECT np FROM employee WHERE employee_id='" + value + "'";
                    int cpt = 0;

                    //cmd = new MySqlCommand(query, connection);
                    //un = (String)cmd.ExecuteScalar();
                    //open connection
                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                        //ExecuteScalar will return one value
                        Count = int.Parse(cmd2.ExecuteScalar() + "");
                        //MessageBox.Show(Count.ToString());

                        if (Count < 4)
                        {
                            if (Count == 3)
                            {
                                cpt = Count + 1;
                                query = "UPDATE employee SET status='" + "Done" + "',date='" + thisDay.ToString("yyyy-MM-dd") + "',np='" + cpt + "' WHERE employee_id='" + value + "'";
                                //create command and assign the query and connection from the constructor
                                cmd = new MySqlCommand(query, connection);

                                //Execute command
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cpt = Count + 1;
                                query = "UPDATE employee SET status='" + paid + "',date='" + thisDay.ToString("yyyy-MM-dd") + "',np='" + cpt + "' WHERE employee_id='" + value + "'";
                                //create command and assign the query and connection from the constructor
                                cmd = new MySqlCommand(query, connection);

                                //Execute command
                                cmd.ExecuteNonQuery();
                            }
                            total = total + Convert.ToInt32(list_employee.Items[item.Index].SubItems[2].Text);
                        }
                        else
                        {
                            /*query = "UPDATE employee SET status='" + done + "' WHERE employee_id='" + value + "'";
                            //create command and assign the query and connection from the constructor
                            cmd = new MySqlCommand(query, connection);

                            //Execute command
                            cmd.ExecuteNonQuery();*/
                        //}
                        //close connection
                       /* this.CloseConnection();
                    }
                }
            }
            establish_connection();

            string query3 = "INSERT INTO ledger (accountname, amount, date) VALUES ('" + "Salaries Account" + "','" + total + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";

            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query3, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
            list_employee.Items.Clear();
            show_data();*/
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_employee.Items)
            {

                //MessageBox.Show(value);
                establish_connection();

                //cmd = new MySqlCommand(query, connection);
                //un = (String)cmd.ExecuteScalar();
                //open connection
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    query = "UPDATE loan SET lstpaydate=NULL ,lstpaid='" + 0 + "',due='" + item.SubItems[2].Text + "'";
                    //create command and assign the query and connection from the constructor
                    cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            list_employee.Items.Clear();
            show_data();
        }

        private void btn_addemployee_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void btn_removeemployee_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in list_employee.Items)
            {
                if (item.Checked)
                {
                    string value = item.Text;
                    //MessageBox.Show(value);
                    establish_connection();
                    string query2 = "DELETE FROM loan WHERE idnum='" + value + "'";

                    if (this.OpenConnection() == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                        cmd2.ExecuteNonQuery();
                        this.CloseConnection();
                    }
                }
            }
            list_employee.Items.Clear();
            show_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("RanD"))
            {
                TextWriter tw1 = new StreamWriter("RanD");
                tw1.WriteLine(RandomNumber(1000, 4999));
                tw1.Close();
            }

            establish_connection();

            if (this.OpenConnection() == true)
            {
                TextReader tr1 = new StreamReader("RanD");
                string addr = tr1.ReadLine();
                int idnum = Convert.ToInt16(addr) + 5;
                tr1.Close();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                double ad = 0;
                query = "INSERT INTO loan (emname, contact, due, lstpaid, idnum, perday) VALUES ('" + txt_emname.Text + "','" + Convert.ToDouble(txt_emsalary.Text) + "','" + Convert.ToDouble(txt_emsalary.Text) + "','" + ad + "','" + idnum + "','" + Convert.ToDouble(txtperday.Text) + "')";
                //create command and assign the query and connection from the constructor
                cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
                MessageBox.Show("Employee ID: "+ idnum);
                TextWriter tw1 = new StreamWriter("RanD");
                tw1.WriteLine(idnum);
                tw1.Close();
            }
            panel1.Visible = false;
            list_employee.Items.Clear();
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

        private void txt_emname_TextChanged(object sender, EventArgs e)
        {

        }
        salhist sh = new salhist();
        private void btnsalhist_Click(object sender, EventArgs e)
        {
            sh.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblemname_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
