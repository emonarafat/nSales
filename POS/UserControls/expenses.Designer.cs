namespace POS
{
    partial class expenses
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
            this.txt_spent_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_lvl1 = new System.Windows.Forms.ComboBox();
            this.btn_Entry = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_ok_btn = new System.Windows.Forms.Button();
            this.main_pass_txt = new System.Windows.Forms.TextBox();
            this.main_user_txt = new System.Windows.Forms.TextBox();
            this.main_pass_lbl = new System.Windows.Forms.Label();
            this.main_user_lbl = new System.Windows.Forms.Label();
            this.main_cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_spent_amount
            // 
            this.txt_spent_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_spent_amount.Location = new System.Drawing.Point(358, 34);
            this.txt_spent_amount.Name = "txt_spent_amount";
            this.txt_spent_amount.ShortcutsEnabled = false;
            this.txt_spent_amount.Size = new System.Drawing.Size(219, 26);
            this.txt_spent_amount.TabIndex = 33;
            this.txt_spent_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_spent_amount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Amount Spent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Spent on:";
            // 
            // comboBox_lvl1
            // 
            this.comboBox_lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_lvl1.FormattingEnabled = true;
            this.comboBox_lvl1.Items.AddRange(new object[] {
            "Official Expenses",
            "Others Expenses",
            "Personal Expenses"});
            this.comboBox_lvl1.Location = new System.Drawing.Point(359, 66);
            this.comboBox_lvl1.MaxDropDownItems = 12;
            this.comboBox_lvl1.Name = "comboBox_lvl1";
            this.comboBox_lvl1.Size = new System.Drawing.Size(218, 28);
            this.comboBox_lvl1.Sorted = true;
            this.comboBox_lvl1.TabIndex = 30;
            // 
            // btn_Entry
            // 
            this.btn_Entry.Location = new System.Drawing.Point(477, 133);
            this.btn_Entry.Name = "btn_Entry";
            this.btn_Entry.Size = new System.Drawing.Size(100, 38);
            this.btn_Entry.TabIndex = 34;
            this.btn_Entry.Text = "Entry";
            this.btn_Entry.UseVisualStyleBackColor = true;
            this.btn_Entry.Click += new System.EventHandler(this.btn_Entry_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.main_ok_btn);
            this.panel2.Controls.Add(this.main_pass_txt);
            this.panel2.Controls.Add(this.main_user_txt);
            this.panel2.Controls.Add(this.main_pass_lbl);
            this.panel2.Controls.Add(this.main_user_lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 200);
            this.panel2.TabIndex = 43;
            // 
            // main_ok_btn
            // 
            this.main_ok_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.main_ok_btn.FlatAppearance.BorderSize = 0;
            this.main_ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_ok_btn.Location = new System.Drawing.Point(455, 121);
            this.main_ok_btn.Name = "main_ok_btn";
            this.main_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.main_ok_btn.TabIndex = 15;
            this.main_ok_btn.Text = "OK";
            this.main_ok_btn.UseVisualStyleBackColor = false;
            this.main_ok_btn.Click += new System.EventHandler(this.main_ok_btn_Click);
            // 
            // main_pass_txt
            // 
            this.main_pass_txt.Location = new System.Drawing.Point(330, 88);
            this.main_pass_txt.Name = "main_pass_txt";
            this.main_pass_txt.PasswordChar = '*';
            this.main_pass_txt.Size = new System.Drawing.Size(200, 20);
            this.main_pass_txt.TabIndex = 14;
            // 
            // main_user_txt
            // 
            this.main_user_txt.Location = new System.Drawing.Point(330, 64);
            this.main_user_txt.Name = "main_user_txt";
            this.main_user_txt.Size = new System.Drawing.Size(200, 20);
            this.main_user_txt.TabIndex = 13;
            // 
            // main_pass_lbl
            // 
            this.main_pass_lbl.AutoSize = true;
            this.main_pass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.main_pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_pass_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_pass_lbl.Location = new System.Drawing.Point(245, 89);
            this.main_pass_lbl.Name = "main_pass_lbl";
            this.main_pass_lbl.Size = new System.Drawing.Size(69, 17);
            this.main_pass_lbl.TabIndex = 12;
            this.main_pass_lbl.Text = "Password";
            // 
            // main_user_lbl
            // 
            this.main_user_lbl.AutoSize = true;
            this.main_user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.main_user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_user_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_user_lbl.Location = new System.Drawing.Point(245, 65);
            this.main_user_lbl.Name = "main_user_lbl";
            this.main_user_lbl.Size = new System.Drawing.Size(79, 17);
            this.main_user_lbl.TabIndex = 11;
            this.main_user_lbl.Text = "User Name";
            // 
            // main_cancel_btn
            // 
            this.main_cancel_btn.BackColor = System.Drawing.Color.Crimson;
            this.main_cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.main_cancel_btn.FlatAppearance.BorderSize = 0;
            this.main_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_cancel_btn.Location = new System.Drawing.Point(371, 133);
            this.main_cancel_btn.Name = "main_cancel_btn";
            this.main_cancel_btn.Size = new System.Drawing.Size(100, 38);
            this.main_cancel_btn.TabIndex = 45;
            this.main_cancel_btn.Text = "Protect";
            this.main_cancel_btn.UseVisualStyleBackColor = false;
            this.main_cancel_btn.Click += new System.EventHandler(this.main_cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Name the Employee...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Issued By:";
            // 
            // expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Entry);
            this.Controls.Add(this.txt_spent_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_lvl1);
            this.Controls.Add(this.main_cancel_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "expenses";
            this.Size = new System.Drawing.Size(800, 200);
            this.Load += new System.EventHandler(this.expenses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_spent_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_lvl1;
        private System.Windows.Forms.Button btn_Entry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button main_ok_btn;
        private System.Windows.Forms.TextBox main_pass_txt;
        private System.Windows.Forms.TextBox main_user_txt;
        private System.Windows.Forms.Label main_pass_lbl;
        private System.Windows.Forms.Label main_user_lbl;
        private System.Windows.Forms.Button main_cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
