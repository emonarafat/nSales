using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace POS
{
    public partial class memo : Form
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        DateTime thisDay = DateTime.Today;

        PrintDocument pd = new PrintDocument();
        PrintDialog pdialog = new PrintDialog();

        ListView cplstv = new ListView();        

        public memo()
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

        private void memo_Load(object sender, EventArgs e)
        {
            label7.Text = thisDay.ToString("yyyy-MM-dd");
            txt_amount.Text = testlistview.lb_pay.ToString();
            label2.Text = main_form.iname.ToUpper();
            cplstv.Clear();
            cplstv.Columns.Add("Product ID", 160, HorizontalAlignment.Left);
            cplstv.Columns.Add("Unit Price", 150, HorizontalAlignment.Left);
            cplstv.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
            cplstv.Columns.Add("Sub Total", 150, HorizontalAlignment.Left);
            foreach (ListViewItem itm in testlistview.stlstv.Items)
            {
                string[] arr = new string[6];
                ListViewItem itms;

                //Add first item
                arr[0] = itm.SubItems[0].Text;
                arr[1] = itm.SubItems[1].Text;
                arr[2] = itm.SubItems[2].Text;
                arr[3] = itm.SubItems[3].Text;
                itms = new ListViewItem(arr);

                cplstv.Items.Add(itms);
            }
            cplstv.View = View.Details;
            cplstv.Dock = DockStyle.Fill;
            panel2.Controls.Add(cplstv);

            if (File.Exists("AddR") && File.Exists("ConT"))
            {
                // create reader & open file
                TextReader tr1 = new StreamReader("AddR");

                // read a line of text
                string addr = tr1.ReadLine();
                // create reader & open file
                TextReader tr2 = new StreamReader("ConT");

                // read a line of text
                string cont = tr2.ReadLine();

                addrlbl.Text = addr;
                contlbl.Text = cont;

                tr1.Close();
                tr2.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(thisDay.ToString("yyyy-MM-dd"));
            if (txt_amount.Text != "" && txt_subject.Text != "" && textBox_sub.Text != "")
            {
                try
                {
                    establish_connection();
                    //int selprice = (Convert.ToInt32(txt_price.Text) * 30) / 100;
                    if (checkBox_in.Checked == true)
                        query = "INSERT INTO partyledger (partyname, address, amount, date, issuedby, paytype, mobile, phone) VALUES ('" + txt_subject.Text + "','" + textBox_sub.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + label2.Text + "','" + "Advance" + "','" + textBox_mobile.Text + "','" + textBox_phone.Text + "')";
                    else
                        query = "INSERT INTO partyledger (partyname, address, amount, date, issuedby, paytype, mobile, phone) VALUES ('" + txt_subject.Text + "','" + textBox_sub.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + label2.Text + "','" + "Due" + "','" + textBox_mobile.Text + "','" + textBox_phone.Text + "')";
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
                    textBox_mobile.Text = "";
                    textBox_phone.Text = "";
                    txt_amount.Text = "";
                    checkBox_in.Checked = true;
                    txt_subject.Focus();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Fields Empty!");
            }            
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width + 10, panel1.Height + 10);
            this.DrawToBitmap(img, new System.Drawing.Rectangle(0, 0, img.Width, img.Height)); // listView1.DisplayRectangle);
            e.Graphics.DrawImage(img, this.PointToScreen(new Point(-413, -130)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(thisDay.ToString("yyyy-MM-dd"));
            if (txt_amount.Text != "" && txt_subject.Text != "" && textBox_sub.Text != "")
            {
                try
                {
                    establish_connection();
                    //int selprice = (Convert.ToInt32(txt_price.Text) * 30) / 100;
                    if (checkBox_in.Checked == true)
                        query = "INSERT INTO partyledger (partyname, address, amount, date, issuedby, paytype, mobile, phone) VALUES ('" + txt_subject.Text + "','" + textBox_sub.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + label2.Text + "','" + "Advance" + "','" + textBox_mobile.Text + "','" + textBox_phone.Text + "')";
                    else
                        query = "INSERT INTO partyledger (partyname, address, amount, date, issuedby, paytype, mobile, phone) VALUES ('" + txt_subject.Text + "','" + textBox_sub.Text + "','" + Convert.ToDouble(txt_amount.Text) + "','" + thisDay.ToString("yyyy-MM-dd") + "','" + label2.Text + "','" + "Due" + "','" + textBox_mobile.Text + "','" + textBox_phone.Text + "')";
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

                        if (pd.PrinterSettings.SupportsColor)
                        {

                            // Set the page default's to not print in color.
                            pd.DefaultPageSettings.Color = false;
                        }

                        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                        //if (pdialog.ShowDialog() == DialogResult.OK)
                        //{
                        pd.Print();
                        //}

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
                    textBox_mobile.Text = "";
                    textBox_phone.Text = "";
                    txt_amount.Text = "";
                    checkBox_in.Checked = true;
                    txt_subject.Focus();
                }

                //DialogResult result = pdialog.ShowDialog();

                /*PaperSize paperSize = new PaperSize("A4", 210, 297);
                paperSize.RawKind = (int)PaperKind.A4;

                pdialog.Document = pd;
                pdialog.AllowCurrentPage = true;
                pdialog.AllowPrintToFile = true;
                pdialog.AllowSelection = true;
                pdialog.AllowSomePages = true;
                pdialog.ShowNetwork = true;
                pd.DefaultPageSettings.PrinterSettings.Copies = 1;

                pd.DefaultPageSettings.PaperSize = paperSize;
                pd.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
                pd.DefaultPageSettings.Margins = new Margins(20, 20, 20, 20);*/

                // If the printer supports printing in color, then override the printer's default behavior. 
                

                this.Close();

            }
            else
            {
                MessageBox.Show("Fields Empty!");
            }            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
