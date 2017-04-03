using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace POS
{
    public partial class main_form : Form
    {
        static bool conv = false;

        testlistview usrcon_testlistview = new testlistview();
        stock usrcon_stock = new stock();
        banking usrcon_banking = new banking();
        employee usrcon_employee = new employee();
        partyledger usrcon_party = new partyledger();
        partyledgerhist usrcon_partyle = new partyledgerhist();
        ledger usrcon_ledger = new ledger();
        purchase usrcon_purchase = new purchase();
        expenses usrcon_expenses = new expenses();
        banklehist usrcon_bankle = new banklehist();
        salpur usrcon_salpur = new salpur();

        about frm_about = new about();

        string MyConString;
        MySqlConnection connection;
        //string query;
        DateTime thisDay2 = DateTime.Today;

        public static string iname;

        public main_form()
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

        static Register regform = new Register();
        
        public static void ThreadProc2()
        {
            conv = true;
            Application.Run(new calc());
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            TextReader issuer = new StreamReader("rate");

            // read a line of text
            iname = issuer.ReadLine();


            // create reader & open file
            TextReader tr = new StreamReader("date");

            // read a line of text
            string utype=tr.ReadLine();
            //MessageBox.Show(utype);
            if (utype == "admin")
            {
                //MessageBox.Show(utype);
                admin_pictureBox.Visible = true;

                toolStripButton2.Visible = true;
                toolStripButton7.Visible = true;
                accounting_tabControl.Visible = true;
                toolStripButton8.Visible = true;
                converterToolStripMenuItem.Visible = true;
                toolStripSeparator4.Visible = true;
                registerToolStripMenuItem.Visible = true;
                panel2.Visible = false;
            }
            
            // close the stream
            tr.Close();
            
            //usrcon_testlistview.Dock = DockStyle.Fill;

            main_panel.SuspendLayout();
            main_panel.Controls.Add(usrcon_testlistview);
            main_panel.ResumeLayout();
            this.main_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usrcon_testlistview.Dock = DockStyle.Fill;
            main_panel.Dock = DockStyle.Fill;

            banking_panel.SuspendLayout();
            banking_panel.Controls.Add(usrcon_banking);
            banking_panel.ResumeLayout();
            this.banking_panel.Anchor = System.Windows.Forms.AnchorStyles.None;

            employee_panel.SuspendLayout();
            employee_panel.Controls.Add(usrcon_employee);
            employee_panel.ResumeLayout();
            this.employee_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usrcon_employee.Dock = DockStyle.Fill;
            employee_panel.Dock = DockStyle.Fill;

            party_panel.SuspendLayout();
            party_panel.Controls.Add(usrcon_party);
            party_panel.ResumeLayout();
            this.party_panel.Anchor = System.Windows.Forms.AnchorStyles.None;

            expense_panel.SuspendLayout();
            expense_panel.Controls.Add(usrcon_expenses);
            expense_panel.ResumeLayout();
            this.expense_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //usrcon_stock.Dock = DockStyle.Fill;

            main_tabControl.SelectedTab = tab_products;
            main_panel.SuspendLayout();
            main_panel.Controls.Remove(usrcon_testlistview);
            main_panel.Controls.Remove(usrcon_purchase);
            main_panel.Controls.Add(usrcon_stock);
            main_panel.ResumeLayout();

            usrcon_stock.Dock = DockStyle.Fill;

            usrcon_stock.clear();
            usrcon_stock.show_data();
            // create reader & open file
            TextReader tr = new StreamReader("date");

            // read a line of text
            string utype = tr.ReadLine();
            //MessageBox.Show(utype);
            if (utype == "admin")
            {
                //usrcon_stock.unpro();
            }
            else
            {
                usrcon_stock.pro();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //usrcon_testlistview.Dock = DockStyle.Fill;

            main_tabControl.SelectedTab = tab_products;
            main_panel.SuspendLayout();
            main_panel.Controls.Remove(usrcon_stock);
            main_panel.Controls.Remove(usrcon_purchase);
            main_panel.Controls.Add(usrcon_testlistview);
            main_panel.ResumeLayout();

            usrcon_testlistview.Dock = DockStyle.Fill;

            
        }

        private void btn_info_partyle_Click(object sender, EventArgs e)
        {
            info_panel.SuspendLayout();
            info_panel.Controls.Remove(usrcon_ledger);
            info_panel.Controls.Remove(usrcon_bankle);
            info_panel.Controls.Remove(usrcon_salpur);
            info_panel.Controls.Add(usrcon_partyle);
            usrcon_partyle.show_data();
            info_panel.ResumeLayout();
            this.info_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usrcon_partyle.Dock = DockStyle.Fill;
            info_panel.Dock = DockStyle.Fill;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
                regform.ShowDialog();
        }

        private void button_genle_Click(object sender, EventArgs e)
        {
            info_panel.SuspendLayout();
            info_panel.Controls.Remove(usrcon_partyle);
            info_panel.Controls.Remove(usrcon_bankle);
            info_panel.Controls.Remove(usrcon_salpur);
            info_panel.Controls.Add(usrcon_ledger);
            usrcon_ledger.show_data();
            info_panel.ResumeLayout();
            this.info_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usrcon_ledger.Dock = DockStyle.Fill;
            info_panel.Dock = DockStyle.Fill;
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_products;
            main_panel.SuspendLayout();
            main_panel.Controls.Remove(usrcon_testlistview);
            main_panel.Controls.Remove(usrcon_stock);
            main_panel.Controls.Add(usrcon_purchase);
            main_panel.ResumeLayout();

            usrcon_purchase.Dock = DockStyle.Fill;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (conv == false)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                t.Start();
            }
        }

        private void barcodeSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conv == false)
            {
                toolStripButton8.PerformClick();
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {           
                toolStripButton2.PerformClick();
        }
        public static void falseconv()
        {
            conv = false;
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonbankle_Click(object sender, EventArgs e)
        {
            info_panel.SuspendLayout();
            info_panel.Controls.Remove(usrcon_ledger);
            info_panel.Controls.Remove(usrcon_partyle);
            info_panel.Controls.Remove(usrcon_salpur);
            info_panel.Controls.Add(usrcon_bankle);
            usrcon_bankle.show_data();
            info_panel.ResumeLayout();
            this.info_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usrcon_bankle.Dock = DockStyle.Fill;
            info_panel.Dock = DockStyle.Fill;
        }
        string query;
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
        gatepass gtfrm = new gatepass();
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            gtfrm.ShowDialog();
        }
        challan frm_challan = new challan();
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frm_challan.ShowDialog();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1.PerformClick();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3.PerformClick();
        }

        private void bankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_accounting;
            accounting_tabControl.SelectedTab = tab_banking;
        }

        private void salariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_accounting;
            accounting_tabControl.SelectedTab = tab_salary;
        }

        private void partiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_accounting;
            accounting_tabControl.SelectedTab = tab_parties;
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_accounting;
            accounting_tabControl.SelectedTab = tab_expenses;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewLoansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_ledger;
            
        }

        private void gatePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton5.PerformClick();
        }

        private void challanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton4.PerformClick();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_accounting;
            accounting_tabControl.SelectedTab = tab_salary;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_ledger;
        }

        private void button_sale_purchase_Click(object sender, EventArgs e)
        {
            info_panel.SuspendLayout();
            info_panel.Controls.Remove(usrcon_ledger);
            info_panel.Controls.Remove(usrcon_partyle);
            info_panel.Controls.Remove(usrcon_bankle);
            info_panel.Controls.Add(usrcon_salpur);
            usrcon_salpur.show_data();
            info_panel.ResumeLayout();
            this.info_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            usrcon_salpur.Dock = DockStyle.Fill;
            info_panel.Dock = DockStyle.Fill;
        }

        private void aDDNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tabControl.SelectedTab = tab_products;
            main_panel.SuspendLayout();
            main_panel.Controls.Remove(usrcon_testlistview);
            main_panel.Controls.Remove(usrcon_stock);
            main_panel.Controls.Add(usrcon_purchase);
            main_panel.ResumeLayout();

            usrcon_purchase.Dock = DockStyle.Fill;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_about.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Manual For nSales.pdf");
        }

        private void main_tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void main_tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (main_tabControl.SelectedTab == tab_ledger)
            {
                button_sale_purchase.PerformClick();
            }
        }
        address addr = new address();
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addr.ShowDialog();
        }
        attendance ats = new attendance();
        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ats.ShowDialog();
        }
        profitbar pb = new profitbar();
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            pb.ShowDialog();
        }

        
    }
}
