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
    public partial class gatepass : Form
    {
        string MyConString;
        MySqlConnection connection;
        string query;
        MySqlCommand cmd;
        DateTime thisDay = DateTime.Today;

        PrintDocument pd = new PrintDocument();
        PrintDialog pdialog = new PrintDialog();

        public gatepass()
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

        private void GatePass_Load(object sender, EventArgs e)
        {
            label2.Text = thisDay.ToString("yyyy-MM-dd");
            label3.Text = main_form.iname.ToUpper();

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
            }
        }

        private void panel_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(img, new System.Drawing.Rectangle(0, 0, img.Width, img.Height)); // listView1.DisplayRectangle);
            e.Graphics.DrawImage(img, panel1.PointToScreen(new Point(-530, 220)));
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txt_subject.Text != "" && txt_amount.Text != "")
            {
                establish_connection();
                //int selprice = (Convert.ToInt32(txt_price.Text) * 30) / 100;
                query = "INSERT INTO gatepass (date, subject, amount) VALUES ('" + label2.Text + "','" + txt_subject.Text + "','" + Convert.ToDouble(txt_amount.Text) + "')";
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

                    MessageBox.Show("GatePass Added Successfully");
                }
                PaperSize paperSize = new PaperSize("A4", 210, 297);
                paperSize.RawKind = (int)PaperKind.A4;

                pdialog.Document = pd;
                pdialog.AllowCurrentPage = true;
                pdialog.AllowPrintToFile = true;
                pdialog.AllowSelection = true;
                pdialog.AllowSomePages = true;
                pdialog.ShowNetwork = true;
                pd.DefaultPageSettings.Landscape = true;
                pd.DefaultPageSettings.PrinterSettings.Copies = 1;

                pd.DefaultPageSettings.PaperSize = paperSize;
                pd.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
                pd.DefaultPageSettings.Margins = new Margins(20, 20, 20, 20);

                // If the printer supports printing in color, then override the printer's default behavior. 
                if (pd.PrinterSettings.SupportsColor)
                {

                    // Set the page default's to not print in color.
                    pd.DefaultPageSettings.Color = false;
                }

                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                /*if (pdialog.ShowDialog() == DialogResult.OK)
                {*/
                pd.Print();
                //}
                this.Close();
            }
            else
            {
                MessageBox.Show("Fields Empty!");
            }
        }
        gatepasshist usrcon_gtpasshist = new gatepasshist();
        private void linkLabelshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.SuspendLayout();
            panel3.Controls.Add(usrcon_gtpasshist);
            panel3.ResumeLayout();

            usrcon_gtpasshist.Dock = DockStyle.Fill;
            panel2.Visible = true;
        }

        private void btn_exhist_Click(object sender, EventArgs e)
        {
            panel3.SuspendLayout();
            panel3.Controls.Remove(usrcon_gtpasshist);
            panel3.ResumeLayout();

            //usrcon_gtpasshist.Dock = DockStyle.Fill;
            panel2.Visible = false;
        }
    }
}
