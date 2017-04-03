namespace POS
{
    partial class employee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_employee = new System.Windows.Forms.ListView();
            this.emid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmployeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Payment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.advance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.due = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_addemployee = new System.Windows.Forms.Button();
            this.btn_removeemployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtperday = new System.Windows.Forms.TextBox();
            this.btn_emcancel = new System.Windows.Forms.Button();
            this.btn_emadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_emsalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emname = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.employee_splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblemname = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_lvl1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsalhist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_splitContainer)).BeginInit();
            this.employee_splitContainer.Panel1.SuspendLayout();
            this.employee_splitContainer.Panel2.SuspendLayout();
            this.employee_splitContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_employee
            // 
            this.list_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_employee.CheckBoxes = true;
            this.list_employee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.emid,
            this.EmployeeName,
            this.Salary,
            this.Payment,
            this.PaymentDate,
            this.advance,
            this.due});
            this.list_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_employee.FullRowSelect = true;
            this.list_employee.GridLines = true;
            this.list_employee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_employee.Location = new System.Drawing.Point(0, 86);
            this.list_employee.MultiSelect = false;
            this.list_employee.Name = "list_employee";
            this.list_employee.Size = new System.Drawing.Size(800, 408);
            this.list_employee.TabIndex = 2;
            this.list_employee.UseCompatibleStateImageBehavior = false;
            this.list_employee.View = System.Windows.Forms.View.Details;
            // 
            // emid
            // 
            this.emid.Text = "Employee ID";
            this.emid.Width = 103;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Employee Name";
            this.EmployeeName.Width = 132;
            // 
            // Salary
            // 
            this.Salary.Text = "Salary";
            this.Salary.Width = 120;
            // 
            // Payment
            // 
            this.Payment.Text = "Last Paid (TK)";
            this.Payment.Width = 113;
            // 
            // PaymentDate
            // 
            this.PaymentDate.Text = "Last Payment Date";
            this.PaymentDate.Width = 150;
            // 
            // advance
            // 
            this.advance.Text = "Advance";
            this.advance.Width = 85;
            // 
            // due
            // 
            this.due.Text = "Due";
            this.due.Width = 90;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(10, 26);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(204, 50);
            this.btn_pay.TabIndex = 3;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(379, 26);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 50);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_addemployee
            // 
            this.btn_addemployee.Location = new System.Drawing.Point(23, 26);
            this.btn_addemployee.Name = "btn_addemployee";
            this.btn_addemployee.Size = new System.Drawing.Size(100, 50);
            this.btn_addemployee.TabIndex = 5;
            this.btn_addemployee.Text = "Add Employee";
            this.btn_addemployee.UseVisualStyleBackColor = true;
            this.btn_addemployee.Click += new System.EventHandler(this.btn_addemployee_Click);
            // 
            // btn_removeemployee
            // 
            this.btn_removeemployee.Location = new System.Drawing.Point(129, 26);
            this.btn_removeemployee.Name = "btn_removeemployee";
            this.btn_removeemployee.Size = new System.Drawing.Size(128, 50);
            this.btn_removeemployee.TabIndex = 6;
            this.btn_removeemployee.Text = "Remove Employee";
            this.btn_removeemployee.UseVisualStyleBackColor = true;
            this.btn_removeemployee.Click += new System.EventHandler(this.btn_removeemployee_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtperday);
            this.panel1.Controls.Add(this.btn_emcancel);
            this.panel1.Controls.Add(this.btn_emadd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_emsalary);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_emname);
            this.panel1.Location = new System.Drawing.Point(231, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 166);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Per Day:";
            // 
            // txtperday
            // 
            this.txtperday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperday.Location = new System.Drawing.Point(89, 79);
            this.txtperday.Name = "txtperday";
            this.txtperday.Size = new System.Drawing.Size(258, 26);
            this.txtperday.TabIndex = 32;
            this.txtperday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // btn_emcancel
            // 
            this.btn_emcancel.Location = new System.Drawing.Point(248, 115);
            this.btn_emcancel.Name = "btn_emcancel";
            this.btn_emcancel.Size = new System.Drawing.Size(100, 36);
            this.btn_emcancel.TabIndex = 34;
            this.btn_emcancel.Text = "Cancel";
            this.btn_emcancel.UseVisualStyleBackColor = true;
            this.btn_emcancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_emadd
            // 
            this.btn_emadd.Location = new System.Drawing.Point(142, 115);
            this.btn_emadd.Name = "btn_emadd";
            this.btn_emadd.Size = new System.Drawing.Size(100, 36);
            this.btn_emadd.TabIndex = 33;
            this.btn_emadd.Text = "ADD";
            this.btn_emadd.UseVisualStyleBackColor = true;
            this.btn_emadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Salary:";
            // 
            // txt_emsalary
            // 
            this.txt_emsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emsalary.Location = new System.Drawing.Point(89, 47);
            this.txt_emsalary.Name = "txt_emsalary";
            this.txt_emsalary.Size = new System.Drawing.Size(258, 26);
            this.txt_emsalary.TabIndex = 31;
            this.txt_emsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Name:";
            // 
            // txt_emname
            // 
            this.txt_emname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emname.Location = new System.Drawing.Point(89, 15);
            this.txt_emname.Name = "txt_emname";
            this.txt_emname.Size = new System.Drawing.Size(258, 26);
            this.txt_emname.TabIndex = 29;
            this.txt_emname.TextChanged += new System.EventHandler(this.txt_emname_TextChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_title.Location = new System.Drawing.Point(3, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(312, 51);
            this.lbl_title.TabIndex = 40;
            this.lbl_title.Text = "Employee\'s Salary";
            // 
            // employee_splitContainer
            // 
            this.employee_splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employee_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.employee_splitContainer.IsSplitterFixed = true;
            this.employee_splitContainer.Location = new System.Drawing.Point(0, 500);
            this.employee_splitContainer.Name = "employee_splitContainer";
            // 
            // employee_splitContainer.Panel1
            // 
            this.employee_splitContainer.Panel1.Controls.Add(this.btn_addemployee);
            this.employee_splitContainer.Panel1.Controls.Add(this.btn_reset);
            this.employee_splitContainer.Panel1.Controls.Add(this.btn_removeemployee);
            // 
            // employee_splitContainer.Panel2
            // 
            this.employee_splitContainer.Panel2.Controls.Add(this.btn_pay);
            this.employee_splitContainer.Size = new System.Drawing.Size(800, 100);
            this.employee_splitContainer.SplitterDistance = 580;
            this.employee_splitContainer.SplitterWidth = 1;
            this.employee_splitContainer.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = global::POS.Properties.Resources.bg;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lblemname);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button_close);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_amount);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.comboBox_lvl1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(163, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 266);
            this.panel2.TabIndex = 42;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(305, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 59;
            this.label16.Text = "Pay Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(216, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 58;
            this.label14.Text = "Attendance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(129, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 57;
            this.label15.Text = "Work Diary:";
            // 
            // lblemname
            // 
            this.lblemname.AutoSize = true;
            this.lblemname.BackColor = System.Drawing.Color.Transparent;
            this.lblemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemname.Location = new System.Drawing.Point(217, 76);
            this.lblemname.Name = "lblemname";
            this.lblemname.Size = new System.Drawing.Size(45, 17);
            this.lblemname.TabIndex = 56;
            this.lblemname.Text = "Name";
            this.lblemname.Click += new System.EventHandler(this.lblemname_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(96, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "Employee Name:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(246, 209);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(128, 35);
            this.button_close.TabIndex = 54;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Advance Amount...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Advance:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 49;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(345, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(306, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "TK";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(217, 100);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ShortcutsEnabled = false;
            this.txt_amount.Size = new System.Drawing.Size(132, 20);
            this.txt_amount.TabIndex = 45;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(151, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Amount:";
            // 
            // comboBox_lvl1
            // 
            this.comboBox_lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_lvl1.FormattingEnabled = true;
            this.comboBox_lvl1.Location = new System.Drawing.Point(217, 49);
            this.comboBox_lvl1.MaxDropDownItems = 12;
            this.comboBox_lvl1.Name = "comboBox_lvl1";
            this.comboBox_lvl1.Size = new System.Drawing.Size(136, 21);
            this.comboBox_lvl1.Sorted = true;
            this.comboBox_lvl1.TabIndex = 43;
            this.comboBox_lvl1.SelectedIndexChanged += new System.EventHandler(this.comboBox_lvl1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Employee ID:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Contract Amount...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(159, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Salary:";
            // 
            // btnsalhist
            // 
            this.btnsalhist.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsalhist.Location = new System.Drawing.Point(656, 27);
            this.btnsalhist.Name = "btnsalhist";
            this.btnsalhist.Size = new System.Drawing.Size(131, 38);
            this.btnsalhist.TabIndex = 43;
            this.btnsalhist.Text = "Show History";
            this.btnsalhist.UseVisualStyleBackColor = true;
            this.btnsalhist.Click += new System.EventHandler(this.btnsalhist_Click);
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsalhist);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employee_splitContainer);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.list_employee);
            this.Name = "employee";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.employee_Load);
            this.Enter += new System.EventHandler(this.employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.employee_splitContainer.Panel1.ResumeLayout(false);
            this.employee_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employee_splitContainer)).EndInit();
            this.employee_splitContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_employee;
        private System.Windows.Forms.ColumnHeader EmployeeName;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader PaymentDate;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ColumnHeader Payment;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_addemployee;
        private System.Windows.Forms.Button btn_removeemployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_emsalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_emname;
        private System.Windows.Forms.Button btn_emcancel;
        private System.Windows.Forms.Button btn_emadd;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.SplitContainer employee_splitContainer;
        private System.Windows.Forms.ColumnHeader advance;
        private System.Windows.Forms.ColumnHeader due;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_lvl1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblemname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsalhist;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtperday;
        private System.Windows.Forms.ColumnHeader emid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
