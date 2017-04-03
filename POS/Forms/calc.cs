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
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = textBox1.Text.Replace("a","0");
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
                       {"6", "u"},
                       {".", "/"}
                   };
            int number;
            string s = textBox1.Text;
            //string num = s.Length.ToString();
            //MessageBox.Show(num.ToString());
            if (s.Contains("."))
            {
                number = s.IndexOf(".");
            }
            else
            {
                number = s.Length;
            }
            //MessageBox.Show(number.ToString());
            if (number > 0)
            {
                foreach (var c in replaceChars)
                {
                    s = s.Replace(c.Key, c.Value);
                }

                s = s.Insert(1, number.ToString());
                foreach (var c in replaceChars2)
                {
                    s = s.Replace(c.Key, c.Value);
                }
                textBox4.Text = s.ToUpper();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                       {"6", "u"},
                       {".", "/"}
                   };
            string s = textBox2.Text;
            s = s.ToLower();
            //string num = s.Length.ToString();
            //MessageBox.Show(num.ToString());
            int number;
            if (s.Contains("/"))
            {
                number = s.IndexOf("/");
            }
            else
            {
                number = s.Length;
            }
            if (number > 0)
            {
                s = s.Remove(1, 1);
                //MessageBox.Show(s.ToString());
                foreach (var c in replaceChars2)
                {
                    s = s.Replace(c.Value, c.Key);
                }
                foreach (var c in replaceChars)
                {
                    s = s.Replace(c.Value, c.Key);
                }

                textBox3.Text = s;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calc_FormClosed(object sender, FormClosedEventArgs e)
        {
            POS.main_form.falseconv();
        }
    }
}
