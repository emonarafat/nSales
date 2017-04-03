namespace POS
{
    partial class Register
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
            this.register_user_lbl = new System.Windows.Forms.Label();
            this.register_pass_lbl = new System.Windows.Forms.Label();
            this.register_repass_lbl = new System.Windows.Forms.Label();
            this.register_user_txt = new System.Windows.Forms.TextBox();
            this.register_pass_txt = new System.Windows.Forms.TextBox();
            this.register_repass_txt = new System.Windows.Forms.TextBox();
            this.register_ok_btn = new System.Windows.Forms.Button();
            this.register_cancel_btn = new System.Windows.Forms.Button();
            this.usertype_lbl = new System.Windows.Forms.Label();
            this.comboBox_utype = new System.Windows.Forms.ComboBox();
            this.button_show_user = new System.Windows.Forms.Button();
            this.panel_usershow = new System.Windows.Forms.Panel();
            this.button_remove = new System.Windows.Forms.Button();
            this.list_ex = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usrtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel_usershow.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_user_lbl
            // 
            this.register_user_lbl.AutoSize = true;
            this.register_user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.register_user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_user_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_user_lbl.Location = new System.Drawing.Point(31, 35);
            this.register_user_lbl.Name = "register_user_lbl";
            this.register_user_lbl.Size = new System.Drawing.Size(79, 17);
            this.register_user_lbl.TabIndex = 0;
            this.register_user_lbl.Text = "User Name";
            // 
            // register_pass_lbl
            // 
            this.register_pass_lbl.AutoSize = true;
            this.register_pass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.register_pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_pass_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_pass_lbl.Location = new System.Drawing.Point(31, 60);
            this.register_pass_lbl.Name = "register_pass_lbl";
            this.register_pass_lbl.Size = new System.Drawing.Size(69, 17);
            this.register_pass_lbl.TabIndex = 1;
            this.register_pass_lbl.Text = "Password";
            // 
            // register_repass_lbl
            // 
            this.register_repass_lbl.AutoSize = true;
            this.register_repass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.register_repass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_repass_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register_repass_lbl.Location = new System.Drawing.Point(31, 85);
            this.register_repass_lbl.Name = "register_repass_lbl";
            this.register_repass_lbl.Size = new System.Drawing.Size(123, 17);
            this.register_repass_lbl.TabIndex = 2;
            this.register_repass_lbl.Text = "Re-type Password";
            // 
            // register_user_txt
            // 
            this.register_user_txt.Location = new System.Drawing.Point(160, 34);
            this.register_user_txt.Name = "register_user_txt";
            this.register_user_txt.Size = new System.Drawing.Size(195, 20);
            this.register_user_txt.TabIndex = 4;
            // 
            // register_pass_txt
            // 
            this.register_pass_txt.Location = new System.Drawing.Point(160, 59);
            this.register_pass_txt.Name = "register_pass_txt";
            this.register_pass_txt.PasswordChar = '*';
            this.register_pass_txt.Size = new System.Drawing.Size(195, 20);
            this.register_pass_txt.TabIndex = 5;
            // 
            // register_repass_txt
            // 
            this.register_repass_txt.Location = new System.Drawing.Point(160, 84);
            this.register_repass_txt.Name = "register_repass_txt";
            this.register_repass_txt.PasswordChar = '*';
            this.register_repass_txt.Size = new System.Drawing.Size(195, 20);
            this.register_repass_txt.TabIndex = 6;
            // 
            // register_ok_btn
            // 
            this.register_ok_btn.BackColor = System.Drawing.Color.Orange;
            this.register_ok_btn.FlatAppearance.BorderSize = 0;
            this.register_ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_ok_btn.Location = new System.Drawing.Point(187, 156);
            this.register_ok_btn.Name = "register_ok_btn";
            this.register_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.register_ok_btn.TabIndex = 8;
            this.register_ok_btn.Text = "OK";
            this.register_ok_btn.UseVisualStyleBackColor = false;
            this.register_ok_btn.Click += new System.EventHandler(this.register_ok_btn_Click);
            // 
            // register_cancel_btn
            // 
            this.register_cancel_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.register_cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.register_cancel_btn.FlatAppearance.BorderSize = 0;
            this.register_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_cancel_btn.Location = new System.Drawing.Point(280, 156);
            this.register_cancel_btn.Name = "register_cancel_btn";
            this.register_cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.register_cancel_btn.TabIndex = 9;
            this.register_cancel_btn.Text = "Close";
            this.register_cancel_btn.UseVisualStyleBackColor = false;
            this.register_cancel_btn.Click += new System.EventHandler(this.register_exit_btn_Click);
            // 
            // usertype_lbl
            // 
            this.usertype_lbl.AutoSize = true;
            this.usertype_lbl.BackColor = System.Drawing.Color.Transparent;
            this.usertype_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usertype_lbl.Location = new System.Drawing.Point(31, 110);
            this.usertype_lbl.Name = "usertype_lbl";
            this.usertype_lbl.Size = new System.Drawing.Size(74, 17);
            this.usertype_lbl.TabIndex = 9;
            this.usertype_lbl.Text = "User Type";
            // 
            // comboBox_utype
            // 
            this.comboBox_utype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_utype.FormattingEnabled = true;
            this.comboBox_utype.Items.AddRange(new object[] {
            "normal",
            "admin"});
            this.comboBox_utype.Location = new System.Drawing.Point(234, 109);
            this.comboBox_utype.Name = "comboBox_utype";
            this.comboBox_utype.Size = new System.Drawing.Size(121, 21);
            this.comboBox_utype.TabIndex = 7;
            // 
            // button_show_user
            // 
            this.button_show_user.Location = new System.Drawing.Point(34, 156);
            this.button_show_user.Name = "button_show_user";
            this.button_show_user.Size = new System.Drawing.Size(104, 23);
            this.button_show_user.TabIndex = 10;
            this.button_show_user.Text = "Show All Users";
            this.button_show_user.UseVisualStyleBackColor = true;
            this.button_show_user.Click += new System.EventHandler(this.button_show_user_Click);
            // 
            // panel_usershow
            // 
            this.panel_usershow.BackColor = System.Drawing.Color.Transparent;
            this.panel_usershow.Controls.Add(this.button_remove);
            this.panel_usershow.Controls.Add(this.list_ex);
            this.panel_usershow.Controls.Add(this.linkLabel1);
            this.panel_usershow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_usershow.Location = new System.Drawing.Point(0, 0);
            this.panel_usershow.Name = "panel_usershow";
            this.panel_usershow.Size = new System.Drawing.Size(384, 196);
            this.panel_usershow.TabIndex = 11;
            this.panel_usershow.Visible = false;
            this.panel_usershow.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_usershow_Paint);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(275, 166);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(100, 25);
            this.button_remove.TabIndex = 47;
            this.button_remove.Text = "Remove User";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // list_ex
            // 
            this.list_ex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_ex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_ex.CheckBoxes = true;
            this.list_ex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username,
            this.usrtype});
            this.list_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_ex.FullRowSelect = true;
            this.list_ex.GridLines = true;
            this.list_ex.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_ex.Location = new System.Drawing.Point(9, 10);
            this.list_ex.MultiSelect = false;
            this.list_ex.Name = "list_ex";
            this.list_ex.Size = new System.Drawing.Size(366, 150);
            this.list_ex.TabIndex = 43;
            this.list_ex.UseCompatibleStateImageBehavior = false;
            this.list_ex.View = System.Windows.Forms.View.Details;
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 270;
            // 
            // usrtype
            // 
            this.usrtype.Text = "Privilege";
            this.usrtype.Width = 95;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Info;
            this.linkLabel1.Location = new System.Drawing.Point(12, 172);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Close";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Register
            // 
            this.AcceptButton = this.register_ok_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POS.Properties.Resources.POS__21_;
            this.CancelButton = this.register_cancel_btn;
            this.ClientSize = new System.Drawing.Size(384, 196);
            this.Controls.Add(this.panel_usershow);
            this.Controls.Add(this.button_show_user);
            this.Controls.Add(this.comboBox_utype);
            this.Controls.Add(this.usertype_lbl);
            this.Controls.Add(this.register_cancel_btn);
            this.Controls.Add(this.register_ok_btn);
            this.Controls.Add(this.register_repass_txt);
            this.Controls.Add(this.register_pass_txt);
            this.Controls.Add(this.register_user_txt);
            this.Controls.Add(this.register_repass_lbl);
            this.Controls.Add(this.register_pass_lbl);
            this.Controls.Add(this.register_user_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel_usershow.ResumeLayout(false);
            this.panel_usershow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label register_user_lbl;
        private System.Windows.Forms.Label register_pass_lbl;
        private System.Windows.Forms.Label register_repass_lbl;
        private System.Windows.Forms.TextBox register_user_txt;
        private System.Windows.Forms.TextBox register_pass_txt;
        private System.Windows.Forms.TextBox register_repass_txt;
        private System.Windows.Forms.Button register_ok_btn;
        private System.Windows.Forms.Button register_cancel_btn;
        private System.Windows.Forms.Label usertype_lbl;
        private System.Windows.Forms.ComboBox comboBox_utype;
        private System.Windows.Forms.Button button_show_user;
        private System.Windows.Forms.Panel panel_usershow;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListView list_ex;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader usrtype;
        private System.Windows.Forms.Button button_remove;
    }
}