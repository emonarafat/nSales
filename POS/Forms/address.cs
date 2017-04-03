using MySql.Data.MySqlClient;
using System;
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
    public partial class address : Form
    {
        public address()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            change.Enabled = false;
            save.Enabled = true;
            addresstxt.Enabled = true;
            contacttxt.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            TextWriter tw1 = new StreamWriter("AddR");
            //MessageBox.Show(utype);
            // write a line of text to the file
            tw1.WriteLine(addresstxt.Text);

            // close the stream
            tw1.Close();
            TextWriter tw2 = new StreamWriter("ConT");
            //MessageBox.Show(utype);
            // write a line of text to the file
            tw2.WriteLine(contacttxt.Text);

            // close the stream
            tw2.Close();

            save.Enabled = false;
            change.Enabled = true;
            addresstxt.Enabled = false;
            contacttxt.Enabled = false;
        }

        private void address_Load(object sender, EventArgs e)
        {
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

                addresstxt.Text = addr;
                contacttxt.Text = cont;

                tr1.Close();
                tr2.Close();
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
    }
}
