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
    public partial class purchase : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        DateTime thisDay = DateTime.Today;

        memo frm_memo = new memo();
        public static ListView stlstv = new ListView();

        public static double lb_tot, lb_pay, tx_lss;

        public purchase()
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

        void dataupdate()
        {
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
                combo_gen.DataSource = dt;
                combo_gen.DisplayMember = "Generic";
                combo_gen.ValueMember = "Model";
                //close connection
                this.CloseConnection();
            }
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            /*this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_add_new.Anchor = System.Windows.Forms.AnchorStyles.None;*/

            dataupdate();
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

        public double convert_code(string code)
        {
            double digit;
            //digit = 2500000;
            var replaceChars = new Dictionary<string, string>
                   {
                       {"0", "a"},
                       {"1", "e"},
                       {"2", "h"},
                       {"3", "b"},
                       {"4", "f"},
                       {"5", "i"},
                       {"6", "c"},
                       {"7", "g"},
                       {"8", "j"},
                       {"9", "d"}
                   };
            var replaceChars2 = new Dictionary<string, string>
                   {
                       
                       {"1", "v"},
                       {"2", "w"},
                       {"3", "x"},
                       {"4", "y"},
                       {"5", "z"},
                       {"6", "u"}
                   };
            code = code.ToLower();
            
            //string num = code.Length.ToString();
            //MessageBox.Show(num.ToString());
            int number;
            if (code.Contains("/"))
            {
                number = code.IndexOf("/");
            }
            else
            {
                number = code.Length;
            }
            if (code.Contains("0"))
            {

            }
            else
            {
                code = code.Remove(1, 1);
            }
            //MessageBox.Show(code);
            //MessageBox.Show(s.ToString());
            foreach (var c in replaceChars2)
            {
                code = code.Replace(c.Value, c.Key);
            }
            foreach (var c in replaceChars)
            {
                code = code.Replace(c.Value, c.Key);
            }
            digit = Convert.ToDouble(code);
            //MessageBox.Show(Convert.ToDouble(code).ToString());
            return digit;
        }
        double percent;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_model.Text != "" && combo_type.Text != "" && combo_gen.Text != "" && txt_Details.Text != "")
            {
                establish_connection();
                percent = Convert.ToDouble(textBox1.Text);
                double selprice = convert_code(txt_price.Text) + (Convert.ToDouble(convert_code(txt_price.Text)) * percent) / 100;
                query = "INSERT INTO products (Model, Generic, Type, PurchasePrice, Available, Details, SellingPrice, purpcode) VALUES ('" + txt_model.Text + "','" + combo_gen.Text + "','" + combo_type.Text + "','" + convert_code(txt_price.Text) + "','" + txt_q.Text + "','" + txt_Details.Text + "','" + Convert.ToDouble(selprice) + "','" + txt_price.Text + "')";
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
                    txt_model.Text = "";
                    combo_type.Text = "";
                    combo_gen.Text = "";
                    txt_price.Text = "";
                    txt_Details.Text = "No Information Available";

                    dataupdate();

                    MessageBox.Show("New Item Added Successfully");
                }
            }
            else
            {
                MessageBox.Show("Fields Emty!");
            }
        }

        private void panel_close_Click(object sender, EventArgs e)
        {
            panel_add_new.Visible = false;
            panel1.Visible = true;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            // create reader & open file
            TextReader tr = new StreamReader("date");

            // read a line of text
            string utype = tr.ReadLine();
            //MessageBox.Show(utype);
            if (utype == "admin")
            {
                //dataupdate();
                unpro();
            }
            else
            {
                pro();
            }
            panel1.Visible = false;
            panel_add_new.Visible = true;
        }

        private void comboBox_lvl1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            comboBox_lvl2.Enabled = true;

        }

        private void comboBox_lvl2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_lvl3.Enabled = true;
            txt_num_product.Enabled = true;
            txt_quantity.Enabled = true;
        }

        private void comboBox_lvl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT Model,Type FROM products WHERE Generic='" + comboBox_lvl1.Text + "' GROUP BY Type";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl2.DataSource = dt;
                comboBox_lvl2.DisplayMember = "Type";
                comboBox_lvl2.ValueMember = "Model";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
        }

        private void comboBox_lvl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT Model FROM products WHERE Type='" + comboBox_lvl2.Text + "'";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox_lvl3.DataSource = dt;
                comboBox_lvl3.DisplayMember = "Model";
                comboBox_lvl3.ValueMember = "Model";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
        }

        private bool IsInCollection(ListViewItem lvi)
        {
            foreach (ListViewItem item in list_purchase.Items)
            {
                bool subItemEqualFlag = true;
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    string sub1 = item.SubItems[i].Text;
                    string sub2 = lvi.SubItems[i].Text;
                    if (sub1 != sub2)
                    {
                        subItemEqualFlag = false;
                    }
                }
                if (subItemEqualFlag)
                    return true;
            }

            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_lvl3.Enabled == true)
            {
                //Add items in the listview
                string[] arr = new string[6];
                ListViewItem itm;

                //Add first item
                arr[0] = comboBox_lvl3.Text;
                arr[1] = comboBox_lvl1.Text;
                arr[2] = comboBox_lvl2.Text;
                arr[3] = txt_num_product.Text;
                arr[4] = txt_quantity.Text;
                /*int a = Convert.ToInt16(txt_num_product.Text);
                int b = Convert.ToInt16(txt_quantity.Text);
                int sub = a * b;
                arr[5] = sub.ToString();*/
                itm = new ListViewItem(arr);
                if (!IsInCollection(itm))
                {
                    list_purchase.Items.Add(itm);
                }
                else
                {
                    MessageBox.Show("Duplicate Item!");
                }
                comboBox_lvl2.Text = "";
                comboBox_lvl2.Enabled = false;
                comboBox_lvl3.Text = "";
                comboBox_lvl3.Enabled = false;
                txt_num_product.Text = "";
                txt_num_product.Enabled = false;
                txt_quantity.Text = "1";
                txt_quantity.Enabled = false;
            }
            else
            {
                MessageBox.Show("Choose The Product and quantity First!");
            }
        }

        private void combo_type_Enter(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT Model,Type FROM products WHERE Generic='" + combo_gen.Text + "'";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                combo_type.DataSource = dt;
                combo_type.DisplayMember = "Type";
                combo_type.ValueMember = "Model";
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
        }

        private void combo_gen_Enter(object sender, EventArgs e)
        {
            combo_type.Text = "";
        }

        private void btn_pur_Click(object sender, EventArgs e)
        {
            if (list_purchase.Items.Count > 0)
            {
                int i = 0;
                double total = 0;
                foreach (ListViewItem item in list_purchase.Items)
                {
                    //DateTime thisDay = DateTime.Today;
                    string value = item.Text;
                    //MessageBox.Show(value);
                    establish_connection();

                    string query = "SELECT Available FROM products WHERE Model='" + value + "'";
                    int Count = -1;

                    //Open Connection
                    if (this.OpenConnection() == true)
                    {
                        //Create Mysql Command
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        //ExecuteScalar will return one value
                        Count = int.Parse(cmd.ExecuteScalar() + "");

                        int now_val = Count + Convert.ToInt32(list_purchase.Items[i].SubItems[4].Text);
                        query = "UPDATE products SET Available='" + now_val + "' WHERE Model='" + value + "'";

                        //cmd = new MySqlCommand(query, connection);
                        //un = (String)cmd.ExecuteScalar();
                        //open connection
                        //create command and assign the query and connection from the constructor
                        cmd = new MySqlCommand(query, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        string sold = "INSERT INTO purchased (pid, gen, tp, quantity, unitprice, amount, date) VALUES ('" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "','" + Convert.ToDouble(item.SubItems[4].Text) + "','" + convert_code(item.SubItems[3].Text) + "','" + convert_code(item.SubItems[3].Text) * Convert.ToDouble(item.SubItems[4].Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "')";

                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd_sold = new MySqlCommand(sold, connection);

                        //Execute command
                        cmd_sold.ExecuteNonQuery();

                        //close connection
                        this.CloseConnection();
                        total = total + convert_code(list_purchase.Items[i].SubItems[3].Text) * Convert.ToDouble(list_purchase.Items[i].SubItems[4].Text);
                        i++;

                        stlstv.Items.Clear();
                        //stlstv = new ListView();
                        //stlstv = listViewEx1;
                        foreach (ListViewItem itm in list_purchase.Items)
                        {
                            string[] arr = new string[6];
                            ListViewItem itms;

                            //Add first item
                            arr[0] = itm.SubItems[0].Text;
                            arr[1] = itm.SubItems[3].Text;
                            arr[2] = itm.SubItems[4].Text;
                            arr[3] = itm.SubItems[5].Text;
                            itms = new ListViewItem(arr);

                            stlstv.Items.Add(itms);
                        }
                        lb_pay = Convert.ToDouble(total);
                        frm_memo.ShowDialog();

                        MessageBox.Show("DONE...");
                    }
                }
                establish_connection();

                string query2 = "INSERT INTO ledger (accountname, amount, date) VALUES ('" + "Purchases Account" + "','" + total + "','" + thisDay.ToString("yyyy-MM-dd") + "')";

                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    cmd = new MySqlCommand(query2, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                //MessageBox.Show("DONE...");
                list_purchase.Items.Clear();
            }
            else
            {
                MessageBox.Show("No Item to Purchase!");
            }
        }

        private void comboBox_lvl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            establish_connection();
            if (this.OpenConnection() == true)
            {
                query = "SELECT purpcode FROM products WHERE Model='" + comboBox_lvl3.Text + "'";
                //MessageBox.Show(comboBox_lvl1.Text);
                //cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string someID="";
                if (dt.Rows.Count == 1)
                {
                    DataRow DR;
                    DR = dt.Rows[0];
                    someID = Convert.ToString(DR["purpcode"]);
                }
                txt_num_product.Text = someID;
                /*comboBox_lvl3.DisplayMember = "Price";
                comboBox_lvl3.ValueMember = "Model";*/
                //comboBox_lvl1.DataBind();

                //close connection
                this.CloseConnection();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in list_purchase.SelectedItems)
            {
                list_purchase.Items.Remove(eachItem);
            }

        }

        public void pro()
        {
            panel2.Visible = true;
        }

        public void unpro()
        {
            panel2.Visible = false;
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

        private void btn_sel_Click(object sender, EventArgs e)
        {
            if (list_purchase.Items.Count > 0)
            {
                int i = 0;
                double total = 0;
                int Count = -1;
                foreach (ListViewItem item in list_purchase.Items)
                {
                    //DateTime thisDay = DateTime.Today;
                    string value = item.Text;
                    //MessageBox.Show(value);
                    establish_connection();

                    string query = "SELECT Available FROM products WHERE Model='" + value + "'";
                    string query2 = "SELECT PurchasePrice FROM products WHERE Model='" + value + "'";
                    double pricep = 0;
                    

                    //Open Connection
                    if (this.OpenConnection() == true)
                    {
                        //Create Mysql Command
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        //ExecuteScalar will return one value
                        Count = int.Parse(cmd.ExecuteScalar() + "");
                        MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                        //ExecuteScalar will return one value
                        pricep = int.Parse(cmd2.ExecuteScalar() + "");

                        if (Count >= Convert.ToInt32(list_purchase.Items[i].SubItems[4].Text))
                        {
                            int now_val = Count - Convert.ToInt32(list_purchase.Items[i].SubItems[4].Text);
                            query = "UPDATE products SET Available='" + now_val + "' WHERE Model='" + value + "'";

                            double profit = convert_code(list_purchase.Items[i].SubItems[3].Text) - pricep;
                            profit = profit * Convert.ToDouble(list_purchase.Items[i].SubItems[4].Text);
                            DateTime thisDay = DateTime.Today;
                            string querypro = "INSERT INTO profit (Model, QSold, Date, profit) VALUES ('" + list_purchase.Items[i].SubItems[0].Text + "','" + list_purchase.Items[i].SubItems[4].Text + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + profit + "')";
                            //cmd = new MySqlCommand(query, connection);
                            //un = (String)cmd.ExecuteScalar();
                            //open connection
                            //create command and assign the query and connection from the constructor
                            cmd = new MySqlCommand(query, connection);

                            //Execute command
                            cmd.ExecuteNonQuery();

                            cmd2 = new MySqlCommand(querypro, connection);

                            //Execute command
                            cmd2.ExecuteNonQuery();

                            string sold = "INSERT INTO sold (pid, gen, tp, quantity, unitprice, amount, date) VALUES ('" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "','" + Convert.ToInt16(item.SubItems[4].Text) + "','" + convert_code(item.SubItems[3].Text) + "','" + convert_code(item.SubItems[3].Text) * Convert.ToInt16(item.SubItems[4].Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "')";

                            //create command and assign the query and connection from the constructor
                            MySqlCommand cmd_sold = new MySqlCommand(sold, connection);

                            //Execute command
                            cmd_sold.ExecuteNonQuery();

                            //close connection
                            this.CloseConnection();
                            total = total + convert_code(list_purchase.Items[i].SubItems[3].Text) * Convert.ToDouble(list_purchase.Items[i].SubItems[4].Text);
                            i++;

                            stlstv.Items.Clear();
                            //stlstv = new ListView();
                            //stlstv = listViewEx1;
                            foreach (ListViewItem itm in list_purchase.Items)
                            {
                                string[] arr = new string[6];
                                ListViewItem itms;

                                //Add first item
                                arr[0] = itm.SubItems[0].Text;
                                arr[1] = itm.SubItems[3].Text;
                                arr[2] = itm.SubItems[4].Text;
                                arr[3] = itm.SubItems[5].Text;
                                itms = new ListViewItem(arr);

                                stlstv.Items.Add(itms);
                            }
                            lb_pay = Convert.ToDouble(total);
                            frm_memo.ShowDialog();

                            MessageBox.Show("DONE...");
                        }
                        else
                        {
                            MessageBox.Show("Not Enough Items!");
                        }
                    }

                }
                establish_connection();
                DateTime thisDay2 = DateTime.Today;
                string query3 = "INSERT INTO ledger (accountname, amount, date) VALUES ('" + "Sales Account" + "','" + total + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";

                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query3, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                //MessageBox.Show("DONE...");
                list_purchase.Items.Clear();                                    
            }
            else
            {
                MessageBox.Show("No Item to Sell!");
            }
        }
    }
}
