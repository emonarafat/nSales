namespace POS
{
    partial class partyledger
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.textBox_sub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_mobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_in = new System.Windows.Forms.CheckBox();
            this.checkBox_out = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addingbank = new System.Windows.Forms.Button();
            this.comboBox_banks = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_mobile = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "TK";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(336, 315);
            this.txt_amount.MaxLength = 10;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ShortcutsEnabled = false;
            this.txt_amount.Size = new System.Drawing.Size(197, 20);
            this.txt_amount.TabIndex = 5;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_product_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Amount:";
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(145, 14);
            this.txt_subject.MaxLength = 25;
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(229, 20);
            this.txt_subject.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Issued By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Name of the Party:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(465, 389);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 35);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "Entry";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_title.Location = new System.Drawing.Point(250, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(299, 51);
            this.lbl_title.TabIndex = 38;
            this.lbl_title.Text = "Party Transaction";
            // 
            // textBox_sub
            // 
            this.textBox_sub.Location = new System.Drawing.Point(145, 40);
            this.textBox_sub.MaxLength = 45;
            this.textBox_sub.Multiline = true;
            this.textBox_sub.Name = "textBox_sub";
            this.textBox_sub.Size = new System.Drawing.Size(229, 64);
            this.textBox_sub.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Name the Employee...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Date:";
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Location = new System.Drawing.Point(146, 110);
            this.textBox_mobile.MaxLength = 15;
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.ShortcutsEnabled = false;
            this.textBox_mobile.Size = new System.Drawing.Size(228, 20);
            this.textBox_mobile.TabIndex = 3;
            this.textBox_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_product_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Mobile:";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(146, 136);
            this.textBox_phone.MaxLength = 15;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.ShortcutsEnabled = false;
            this.textBox_phone.Size = new System.Drawing.Size(228, 20);
            this.textBox_phone.TabIndex = 4;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_product_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(55, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Telephone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Payment Type:";
            // 
            // checkBox_in
            // 
            this.checkBox_in.AutoSize = true;
            this.checkBox_in.Checked = true;
            this.checkBox_in.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_in.Location = new System.Drawing.Point(398, 291);
            this.checkBox_in.Name = "checkBox_in";
            this.checkBox_in.Size = new System.Drawing.Size(69, 17);
            this.checkBox_in.TabIndex = 3;
            this.checkBox_in.Text = "Advance";
            this.checkBox_in.UseVisualStyleBackColor = true;
            this.checkBox_in.CheckedChanged += new System.EventHandler(this.checkBox_in_CheckedChanged);
            // 
            // checkBox_out
            // 
            this.checkBox_out.AutoSize = true;
            this.checkBox_out.Location = new System.Drawing.Point(473, 291);
            this.checkBox_out.Name = "checkBox_out";
            this.checkBox_out.Size = new System.Drawing.Size(46, 17);
            this.checkBox_out.TabIndex = 4;
            this.checkBox_out.Text = "Due";
            this.checkBox_out.UseVisualStyleBackColor = true;
            this.checkBox_out.CheckedChanged += new System.EventHandler(this.checkBox_out_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_addingbank);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_subject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_sub);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox_mobile);
            this.panel1.Location = new System.Drawing.Point(313, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 203);
            this.panel1.TabIndex = 69;
            this.panel1.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(202, 162);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 31);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Done";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addingbank
            // 
            this.btn_addingbank.Location = new System.Drawing.Point(291, 162);
            this.btn_addingbank.Name = "btn_addingbank";
            this.btn_addingbank.Size = new System.Drawing.Size(83, 31);
            this.btn_addingbank.TabIndex = 5;
            this.btn_addingbank.Text = "Add Party";
            this.btn_addingbank.UseVisualStyleBackColor = true;
            this.btn_addingbank.Click += new System.EventHandler(this.btn_addingbank_Click);
            // 
            // comboBox_banks
            // 
            this.comboBox_banks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_banks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_banks.FormattingEnabled = true;
            this.comboBox_banks.Location = new System.Drawing.Point(332, 174);
            this.comboBox_banks.MaxDropDownItems = 12;
            this.comboBox_banks.Name = "comboBox_banks";
            this.comboBox_banks.Size = new System.Drawing.Size(201, 21);
            this.comboBox_banks.Sorted = true;
            this.comboBox_banks.TabIndex = 66;
            this.comboBox_banks.SelectedIndexChanged += new System.EventHandler(this.comboBox_banks_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 73;
            this.button2.Text = "Add Party";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 74;
            this.label10.Text = "Select Party:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(262, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 76;
            this.label14.Text = "Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(273, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 77;
            this.label15.Text = "Mobile:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(329, 211);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(0, 17);
            this.label_address.TabIndex = 78;
            // 
            // label_mobile
            // 
            this.label_mobile.AutoSize = true;
            this.label_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mobile.Location = new System.Drawing.Point(329, 238);
            this.label_mobile.Name = "label_mobile";
            this.label_mobile.Size = new System.Drawing.Size(0, 17);
            this.label_mobile.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(246, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 80;
            this.label13.Text = "Telephone:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(329, 262);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(0, 17);
            this.label_phone.TabIndex = 81;
            // 
            // partyledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_mobile);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_banks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.checkBox_out);
            this.Controls.Add(this.checkBox_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_title);
            this.Name = "partyledger";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.loan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox textBox_sub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_mobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_in;
        private System.Windows.Forms.CheckBox checkBox_out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_addingbank;
        private System.Windows.Forms.ComboBox comboBox_banks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_mobile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_phone;
    }
}
