using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace POS
{
    public partial class testlistview : UserControl
    {
        string MyConString;
        MySqlConnection connection;
        //string query;
        DateTime thisDay2 = DateTime.Today;

        private ListViewEx.ListViewEx listViewEx1;
        private System.Windows.Forms.TextBox textBoxModel;
        ListViewItem lvi;
        private Control[] Editors;

        memo frm_memo=new memo();
        public static ListView stlstv=new ListView();

        public static double lb_tot, lb_pay, tx_lss;

        int mem, num;

        public testlistview()
        {
            InitializeComponent();
            listViewEx1.SubItemClicked += new ListViewEx.SubItemEventHandler(listViewEx1_SubItemClicked);
            listViewEx1.SubItemEndEditing += new ListViewEx.SubItemEndEditingEventHandler(listViewEx1_SubItemEndEditing);
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
        private void testlistview_Load(object sender, EventArgs e)
        {
            this.Anchor = System.Windows.Forms.AnchorStyles.None; 

            listViewEx1.Columns.Add("Model", 150, HorizontalAlignment.Left);
            listViewEx1.Columns.Add("Generic", 150, HorizontalAlignment.Left);
            listViewEx1.Columns.Add("Type", 150, HorizontalAlignment.Left);
            listViewEx1.Columns.Add("Price", 150, HorizontalAlignment.Left);
            listViewEx1.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
            listViewEx1.Columns.Add("Sub Total", 145, HorizontalAlignment.Left);

            stlstv.Columns.Add("Product ID", 100, HorizontalAlignment.Left);
            stlstv.Columns.Add("Unit Price", 150, HorizontalAlignment.Left);
            stlstv.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
            stlstv.Columns.Add("Sub Total", 150, HorizontalAlignment.Left);

            // Create sample ListView data.
            lvi = new ListViewItem("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");	// This is what's displayed in the password column
            //lvi.Tag = "";			// and that's the real password
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            this.listViewEx1.Items.Add(lvi);

            Editors = new Control[] {									
									textBoxModel,
                                    textBoxQuantity									
									};
        }

        int memcopy;
        string old, old2, new1, new2;
        private void listViewEx1_SubItemClicked(object sender, ListViewEx.SubItemEventArgs e)
        {


            if (e.SubItem == 0)
            {
                old = e.Item.SubItems[0].Text;
                //MessageBox.Show(e.Item.Index.ToString());
                mem = e.Item.Index;
                memcopy = mem;
                listViewEx1.StartEditing(Editors[0], e.Item, 0);
            }
            if (e.SubItem == 4)
            {
                old2 = e.Item.SubItems[4].Text;
                //MessageBox.Show(e.Item.Index.ToString());
                num = e.Item.Index;
                listViewEx1.StartEditing(Editors[1], e.Item, 4);
            }


        }

        private void listViewEx1_SubItemEndEditing(object sender, ListViewEx.SubItemEndEditingEventArgs e)
        {
            listViewEx1.Refresh();
            new1 = textBoxModel.Text;
            new2 = textBoxQuantity.Text;

            //MessageBox.Show(old.ToString() + "    " + new1.ToString() + "     " + listViewEx1.Items[mem].SubItems[5].Text);
            if (old != new1 && listViewEx1.Items[memcopy].SubItems[5].Text != "")
            {
                ListViewItem lvi;
                lvi = new ListViewItem("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                //lvi.Tag = "";
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                this.listViewEx1.Items.Add(lvi);

                /*if (mem == 0)
                {

                }
                else
                {
                    listViewEx1.Items[mem].Remove();
                }*/
                calculation();
                memcopy++;
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

        private bool IsInCollection(ListViewItem lvi)
        {
            foreach (ListViewItem item in listViewEx1.Items)
            {
                bool subItemEqualFlag = true;
                for (int i = 0; i < item.SubItems.Count - 3; i++)
                {
                    string sub1 = item.SubItems[i].Text;
                    string sub2 = lvi.SubItems[i].Text;
                    //MessageBox.Show(sub1+"////"+sub2);
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

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            new1 = textBoxModel.Text;
            if (old != new1)
            {
                if (textBoxModel.Text != null || textBoxModel.Text != "")
                {
                    establish_connection();

                    string query = "SELECT Generic FROM products WHERE Model='" + textBoxModel.Text + "'";
                    string query2 = "SELECT Type FROM products WHERE Model='" + textBoxModel.Text + "'";
                    string query3 = "SELECT SellingPrice FROM products WHERE Model='" + textBoxModel.Text + "'";
                    string gen = "";
                    string tp = "";
                    int pricep = 0;

                    //Open Connection
                    if (this.OpenConnection() == true)
                    {
                        try
                        {
                            //Create Mysql Command
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            //ExecuteScalar will return one value
                            gen = (cmd.ExecuteScalar() + "");
                            //MessageBox.Show(gen);
                            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                            //ExecuteScalar will return one value
                            tp = (cmd2.ExecuteScalar() + "");
                            //MessageBox.Show(tp);
                            MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                            //ExecuteScalar will return one value
                            pricep = int.Parse(cmd3.ExecuteScalar() + "");
                            //Add items in the listview
                            string[] arr = new string[6];
                            ListViewItem itm;

                            //Add first item
                            arr[0] = textBoxModel.Text;
                            arr[1] = gen;
                            arr[2] = tp;
                            arr[3] = pricep.ToString();
                            arr[4] = "1";
                            int a = Convert.ToInt32(arr[4]);
                            int sub = a * pricep;
                            arr[5] = sub.ToString();
                            itm = new ListViewItem(arr);
                            if (!IsInCollection(itm))
                            {

                                listViewEx1.Items.Add(itm);
                                if (mem == 0)
                                {
                                    listViewEx1.Items[0].Remove();
                                }
                                else if (listViewEx1.Items[mem - 1].SubItems[0].Text == "")
                                {
                                    listViewEx1.Items[mem - 1].Remove();
                                }
                                else
                                {
                                    listViewEx1.Items[mem].Remove();
                                }

                                /* int i = 0;
                                 foreach (ListViewItem item in listViewEx1.Items)
                                 {
                                     if (listViewEx1.Items[i].SubItems[1].Text == null || listViewEx1.Items[i].SubItems[1].Text == "")
                                     {
                                         listViewEx1.Items[i].Remove();
                                     }
                                     i++;
                                 }*/

                                /*listViewEx1.Items[mem].SubItems[1].Text = gen;
                                listViewEx1.Items[mem].SubItems[2].Text = tp;
                                listViewEx1.Items[mem].SubItems[3].Text = pricep.ToString();
                                listViewEx1.Items[mem].SubItems[4].Text = "1";
                                listViewEx1.Items[mem].SubItems[5].Text = Convert.ToString(Convert.ToInt32(listViewEx1.Items[mem].SubItems[4].Text) * pricep);*/
                            }
                            else
                            {
                                MessageBox.Show("Duplicate Item!");
                                textBoxModel.Text = "";
                            }
                        }
                        catch (Exception)
                        {
                            //
                        }
                    }
                    CloseConnection();
                    //MessageBox.Show(textBoxModel.Text);
                }
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (listViewEx1.Items[num].SubItems[3].Text != "" && listViewEx1.Items[num].SubItems[4].Text != "")
            {
                //MessageBox.Show((Convert.ToInt32(listViewEx1.Items[num].SubItems[3].Text) * Convert.ToInt32(textBoxQuantity.Text)).ToString());
                listViewEx1.Items[num].SubItems[5].Text = Convert.ToString(Convert.ToInt32(listViewEx1.Items[num].SubItems[3].Text) * Convert.ToInt32(textBoxQuantity.Text));
                calculation();
            }
        }
        double sum;
        private void btn_cal_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            calculation();
        }

        public void calculation()
        {
            int i = 0;
            sum = 0;
            foreach (ListViewItem item in listViewEx1.Items)
            {
                if (listViewEx1.Items[i].SubItems[5].Text != "")
                {
                    //MessageBox.Show(listViewEx1.Items[i].SubItems[5].Text + " \\\\ " + sum);
                    sum = sum + Convert.ToDouble(listViewEx1.Items[i].SubItems[5].Text);
                    //MessageBox.Show(sum.ToString());
                }
                i++;
            }
            lbl_total.Text = sum.ToString();
            try
            {
                if (textBoxLess.Text != null || textBoxLess.Text != "")
                {
                    lbl_payment.Text = Convert.ToString(sum - Convert.ToDouble(textBoxLess.Text));
                }
                else
                {
                    textBoxLess.Text = "0";
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void textBoxLess_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLess.Text != null || textBoxLess.Text != "")
                {
                    lbl_payment.Text = Convert.ToString(sum - Convert.ToInt32(textBoxLess.Text));
                }
                else
                {
                    textBoxLess.Text = "0";
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listViewEx1.Items.Count > 1)
            {
                foreach (ListViewItem eachItem in listViewEx1.SelectedItems)
                {
                    if(!String.IsNullOrEmpty(eachItem.SubItems[0].Text))
                    {
                        listViewEx1.Items.Remove(eachItem);
                    }
                }
                
                calculation();
                //panel1.Visible = false;
            }
        }

        

        private void btn_sel_Click(object sender, EventArgs e)
        {
            if (listViewEx1.Items.Count > 1)
            {
                int i = 0;
                double total = 0;
                int Count = -1;
                foreach (ListViewItem item in listViewEx1.Items)
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
                        try
                        {
                            //Create Mysql Command
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            //ExecuteScalar will return one value
                            Count = int.Parse(cmd.ExecuteScalar() + "");
                            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                            //ExecuteScalar will return one value
                            pricep = int.Parse(cmd2.ExecuteScalar() + "");

                            if (Count >= Convert.ToInt32(listViewEx1.Items[i].SubItems[4].Text))
                            {
                                int now_val = Count - Convert.ToInt32(listViewEx1.Items[i].SubItems[4].Text);
                                query = "UPDATE products SET Available='" + now_val + "' WHERE Model='" + value + "'";

                                double profit = Convert.ToDouble(listViewEx1.Items[i].SubItems[3].Text) - pricep - Convert.ToDouble(textBoxLess.Text);
                                profit = profit * Convert.ToInt32(listViewEx1.Items[i].SubItems[4].Text);
                                DateTime thisDay = DateTime.Today;
                                string querypro = "INSERT INTO profit (Model, QSold, Date, profit, Less) VALUES ('" + listViewEx1.Items[i].SubItems[0].Text + "','" + listViewEx1.Items[i].SubItems[4].Text + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + profit + "','" + Convert.ToDouble(textBoxLess.Text) + "')";

                                cmd = new MySqlCommand(query, connection);

                                //Execute command
                                cmd.ExecuteNonQuery();

                                cmd2 = new MySqlCommand(querypro, connection);

                                //Execute command
                                cmd2.ExecuteNonQuery();

                                string sold = "INSERT INTO sold (pid, gen, tp, quantity, unitprice, amount, date) VALUES ('" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "','" + Convert.ToDouble(item.SubItems[4].Text) + "','" + Convert.ToDouble(item.SubItems[3].Text) + "','" + Convert.ToDouble(item.SubItems[5].Text) + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";

                                //create command and assign the query and connection from the constructor
                                MySqlCommand cmd_sold = new MySqlCommand(sold, connection);

                                //Execute command
                                cmd_sold.ExecuteNonQuery();    

                                //close connection
                                this.CloseConnection();
                                total = total + Convert.ToDouble(listViewEx1.Items[i].SubItems[5].Text);
                                i++;

                                //pdialog = new PrintDialog();

                                stlstv.Items.Clear();
                                //stlstv = new ListView();
                                //stlstv = listViewEx1;
                                foreach (ListViewItem itm in listViewEx1.Items)
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
                                lb_pay = Convert.ToDouble(lbl_payment.Text);
                                frm_memo.ShowDialog();

                                //MessageBox.Show("DONE...");
                                //listViewEx1.Items.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Not Enough Items!");
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                establish_connection();

                string query3 = "INSERT INTO ledger (accountname, amount, date) VALUES ('" + "Sales Account" + "','" + total + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";
                string query4 = "INSERT INTO ledger (accountname, amount, date) VALUES ('" + "Discount Account" + "','" + Convert.ToDouble(textBoxLess.Text) + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query3, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd2 = new MySqlCommand(query4, connection);

                    //Execute command
                    cmd2.ExecuteNonQuery();
                    //close connection
                    this.CloseConnection();
                }


                /*foreach (ListViewItem item in listViewEx1.Items)
                {
                    establish_connection();
                    string sold = "INSERT INTO sold (pid, gen, tp, quantity, unitprice, amount, date) VALUES ('" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "','" + Convert.ToInt16(item.SubItems[4].Text) + "','" + Convert.ToInt16(item.SubItems[3].Text) + "','" + Convert.ToInt16(item.SubItems[5].Text) + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";
                    
                    if (this.OpenConnection() == true)
                    {
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(sold, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        //close connection
                        this.CloseConnection();
                    }
                }*/


                listViewEx1.Items.Clear();
                ListViewItem lvi;
                lvi = new ListViewItem("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                //lvi.Tag = "";
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                this.listViewEx1.Items.Add(lvi);
    
            }
            else
            {
                MessageBox.Show("No Item to Sell!");
            }
        }

        private void btn_pur_Click(object sender, EventArgs e)
        {
            if (listViewEx1.Items.Count > 1)
            {
                int i = 0;
                double total = 0;
                foreach (ListViewItem item in listViewEx1.Items)
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
                        try
                        {
                            //Create Mysql Command
                            MySqlCommand cmd = new MySqlCommand(query, connection);

                            //ExecuteScalar will return one value
                            Count = int.Parse(cmd.ExecuteScalar() + "");

                            //close Connection
                            //this.CloseConnection();
                            //MessageBox.Show(Count.ToString());
                            //return Count;
                            //MessageBox.Show(list_purchase.Items[i].SubItems[4].Text);
                            int now_val = Count + Convert.ToInt32(listViewEx1.Items[i].SubItems[4].Text);
                            query = "UPDATE products SET Available='" + now_val + "' WHERE Model='" + value + "'";

                            //cmd = new MySqlCommand(query, connection);
                            //un = (String)cmd.ExecuteScalar();
                            //open connection
                            //create command and assign the query and connection from the constructor
                            cmd = new MySqlCommand(query, connection);

                            //Execute command
                            cmd.ExecuteNonQuery();

                            string sold = "INSERT INTO purchased (pid, gen, tp, quantity, unitprice, amount, date) VALUES ('" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "','" + Convert.ToDouble(item.SubItems[4].Text) + "','" + Convert.ToDouble(item.SubItems[3].Text) + "','" + Convert.ToDouble(item.SubItems[5].Text) + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";

                            //create command and assign the query and connection from the constructor
                            MySqlCommand cmd_sold = new MySqlCommand(sold, connection);

                            //Execute command
                            cmd_sold.ExecuteNonQuery();

                            //close connection
                            this.CloseConnection();
                            total = total + Convert.ToDouble(listViewEx1.Items[i].SubItems[5].Text);
                            i++;

                            stlstv.Items.Clear();
                            //stlstv = new ListView();
                            //stlstv = listViewEx1;
                            foreach (ListViewItem itm in listViewEx1.Items)
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
                            lb_pay = Convert.ToDouble(lbl_payment.Text);
                            frm_memo.ShowDialog();

                            //MessageBox.Show("DONE...");
                            //listViewEx1.Items.Clear();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                establish_connection();

                string query2 = "INSERT INTO ledger (accountname, amount, date) VALUES ('" + "Purchases Account" + "','" + total + "','" + thisDay2.ToString("yyyy-MM-dd") + "')";

                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query2, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                //MessageBox.Show("DONE...");
                listViewEx1.Items.Clear();
                ListViewItem lvi;
                lvi = new ListViewItem("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                //lvi.Tag = "";
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                this.listViewEx1.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("No Item to Purchase!");
            }
        }

        private void testlistview_SizeChanged(object sender, EventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F5)
            {
                btn_sel.Focus();
                btn_sel.PerformClick();



                // Or directly calling the button's click event handler,

                // unless the handler is defined by annonymous methods.

                //button1_Click(button1, EventArgs.Empty);

            }
            else if (keyData == Keys.F6)
            {
                btn_pur.Focus();
                btn_pur.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listViewEx1.Items.Clear();
            ListViewItem lvi;
            lvi = new ListViewItem("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            //lvi.Tag = "";
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            this.listViewEx1.Items.Add(lvi);
            textBoxLess.Text = "0";
            lbl_payment.Text = "0";
            lbl_total.Text = "0";
        }
    }
}
