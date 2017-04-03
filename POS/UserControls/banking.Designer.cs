namespace POS
{
    partial class banking
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
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_party = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_banks = new System.Windows.Forms.ComboBox();
            this.comboBox_ac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.checkBox_out = new System.Windows.Forms.CheckBox();
            this.checkBox_in = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_addac = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addingbank = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_bb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_done = new System.Windows.Forms.Button();
            this.combo_bb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_addingaccount = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_acc = new System.Windows.Forms.TextBox();
            this.btn_addb = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Name of the Bank:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(337, 305);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ShortcutsEnabled = false;
            this.txt_amount.Size = new System.Drawing.Size(132, 20);
            this.txt_amount.TabIndex = 45;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Amount:";
            // 
            // txt_party
            // 
            this.txt_party.Location = new System.Drawing.Point(337, 206);
            this.txt_party.Name = "txt_party";
            this.txt_party.Size = new System.Drawing.Size(228, 20);
            this.txt_party.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Issued By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Subject:";
            // 
            // comboBox_banks
            // 
            this.comboBox_banks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_banks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_banks.FormattingEnabled = true;
            this.comboBox_banks.Location = new System.Drawing.Point(337, 230);
            this.comboBox_banks.MaxDropDownItems = 12;
            this.comboBox_banks.Name = "comboBox_banks";
            this.comboBox_banks.Size = new System.Drawing.Size(228, 21);
            this.comboBox_banks.Sorted = true;
            this.comboBox_banks.TabIndex = 48;
            this.comboBox_banks.SelectedIndexChanged += new System.EventHandler(this.comboBox_banks_SelectedIndexChanged);
            // 
            // comboBox_ac
            // 
            this.comboBox_ac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ac.FormattingEnabled = true;
            this.comboBox_ac.Location = new System.Drawing.Point(337, 255);
            this.comboBox_ac.MaxDropDownItems = 12;
            this.comboBox_ac.Name = "comboBox_ac";
            this.comboBox_ac.Size = new System.Drawing.Size(228, 21);
            this.comboBox_ac.Sorted = true;
            this.comboBox_ac.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Name the Employee...";
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(442, 381);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(123, 33);
            this.btn_ADD.TabIndex = 51;
            this.btn_ADD.Text = "ADD";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // checkBox_out
            // 
            this.checkBox_out.AutoSize = true;
            this.checkBox_out.Location = new System.Drawing.Point(412, 332);
            this.checkBox_out.Name = "checkBox_out";
            this.checkBox_out.Size = new System.Drawing.Size(49, 17);
            this.checkBox_out.TabIndex = 53;
            this.checkBox_out.Text = "OUT";
            this.checkBox_out.UseVisualStyleBackColor = true;
            this.checkBox_out.CheckedChanged += new System.EventHandler(this.checkBox_out_CheckedChanged);
            // 
            // checkBox_in
            // 
            this.checkBox_in.AutoSize = true;
            this.checkBox_in.Checked = true;
            this.checkBox_in.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_in.Location = new System.Drawing.Point(369, 332);
            this.checkBox_in.Name = "checkBox_in";
            this.checkBox_in.Size = new System.Drawing.Size(37, 17);
            this.checkBox_in.TabIndex = 52;
            this.checkBox_in.Text = "IN";
            this.checkBox_in.UseVisualStyleBackColor = true;
            this.checkBox_in.CheckedChanged += new System.EventHandler(this.checkBox_in_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Date:";
            // 
            // btn_addac
            // 
            this.btn_addac.Location = new System.Drawing.Point(571, 254);
            this.btn_addac.Name = "btn_addac";
            this.btn_addac.Size = new System.Drawing.Size(117, 23);
            this.btn_addac.TabIndex = 57;
            this.btn_addac.Text = "Add Account";
            this.btn_addac.UseVisualStyleBackColor = true;
            this.btn_addac.Click += new System.EventHandler(this.btn_addac_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(257, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Catagory:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Check",
            "Online",
            "TT"});
            this.comboBox1.Location = new System.Drawing.Point(337, 280);
            this.comboBox1.MaxDropDownItems = 12;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 59;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_addingbank);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_bb);
            this.panel1.Location = new System.Drawing.Point(311, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 109);
            this.panel1.TabIndex = 60;
            this.panel1.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(197, 39);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 31);
            this.btn_close.TabIndex = 50;
            this.btn_close.Text = "Done";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addingbank
            // 
            this.btn_addingbank.Location = new System.Drawing.Point(286, 39);
            this.btn_addingbank.Name = "btn_addingbank";
            this.btn_addingbank.Size = new System.Drawing.Size(83, 31);
            this.btn_addingbank.TabIndex = 49;
            this.btn_addingbank.Text = "Add Bank";
            this.btn_addingbank.UseVisualStyleBackColor = true;
            this.btn_addingbank.Click += new System.EventHandler(this.btn_addingbank_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Name of the Bank:";
            // 
            // txt_bb
            // 
            this.txt_bb.Location = new System.Drawing.Point(141, 13);
            this.txt_bb.Name = "txt_bb";
            this.txt_bb.Size = new System.Drawing.Size(228, 20);
            this.txt_bb.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.btn_done);
            this.panel2.Controls.Add(this.combo_bb);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btn_addingaccount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_acc);
            this.panel2.Location = new System.Drawing.Point(309, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 109);
            this.panel2.TabIndex = 61;
            this.panel2.Visible = false;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(199, 66);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(83, 31);
            this.btn_done.TabIndex = 55;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // combo_bb
            // 
            this.combo_bb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_bb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_bb.FormattingEnabled = true;
            this.combo_bb.Location = new System.Drawing.Point(143, 13);
            this.combo_bb.MaxDropDownItems = 12;
            this.combo_bb.Name = "combo_bb";
            this.combo_bb.Size = new System.Drawing.Size(228, 21);
            this.combo_bb.Sorted = true;
            this.combo_bb.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Name of the Bank:";
            // 
            // btn_addingaccount
            // 
            this.btn_addingaccount.Location = new System.Drawing.Point(288, 66);
            this.btn_addingaccount.Name = "btn_addingaccount";
            this.btn_addingaccount.Size = new System.Drawing.Size(83, 31);
            this.btn_addingaccount.TabIndex = 52;
            this.btn_addingaccount.Text = "Add Account";
            this.btn_addingaccount.UseVisualStyleBackColor = true;
            this.btn_addingaccount.Click += new System.EventHandler(this.btn_addingaccount_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Account Number:";
            // 
            // txt_acc
            // 
            this.txt_acc.Location = new System.Drawing.Point(143, 40);
            this.txt_acc.Name = "txt_acc";
            this.txt_acc.Size = new System.Drawing.Size(228, 20);
            this.txt_acc.TabIndex = 50;
            // 
            // btn_addb
            // 
            this.btn_addb.Location = new System.Drawing.Point(571, 228);
            this.btn_addb.Name = "btn_addb";
            this.btn_addb.Size = new System.Drawing.Size(117, 23);
            this.btn_addb.TabIndex = 62;
            this.btn_addb.Text = "Add Bank";
            this.btn_addb.UseVisualStyleBackColor = true;
            this.btn_addb.Click += new System.EventHandler(this.btn_addb_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_title.Location = new System.Drawing.Point(256, 19);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(282, 51);
            this.lbl_title.TabIndex = 63;
            this.lbl_title.Text = "Banking Section";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(475, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 64;
            this.textBox1.Visible = false;
            // 
            // banking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_addac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_out);
            this.Controls.Add(this.checkBox_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ac);
            this.Controls.Add(this.comboBox_banks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_party);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_addb);
            this.Controls.Add(this.textBox1);
            this.Name = "banking";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.banking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_party;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_banks;
        private System.Windows.Forms.ComboBox comboBox_ac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.CheckBox checkBox_out;
        private System.Windows.Forms.CheckBox checkBox_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_addac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_bb;
        private System.Windows.Forms.Button btn_addingbank;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combo_bb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_addingaccount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_acc;
        private System.Windows.Forms.Button btn_addb;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox textBox1;
    }
}
