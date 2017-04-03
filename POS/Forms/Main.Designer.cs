namespace POS
{
    partial class Main
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
            this.main_user_lbl = new System.Windows.Forms.Label();
            this.main_pass_lbl = new System.Windows.Forms.Label();
            this.main_user_txt = new System.Windows.Forms.TextBox();
            this.main_pass_txt = new System.Windows.Forms.TextBox();
            this.main_ok_btn = new System.Windows.Forms.Button();
            this.main_cancel_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_user_lbl
            // 
            this.main_user_lbl.AutoSize = true;
            this.main_user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.main_user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_user_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.main_user_lbl.Location = new System.Drawing.Point(75, 50);
            this.main_user_lbl.Name = "main_user_lbl";
            this.main_user_lbl.Size = new System.Drawing.Size(79, 17);
            this.main_user_lbl.TabIndex = 0;
            this.main_user_lbl.Text = "User Name";
            // 
            // main_pass_lbl
            // 
            this.main_pass_lbl.AutoSize = true;
            this.main_pass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.main_pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_pass_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.main_pass_lbl.Location = new System.Drawing.Point(75, 75);
            this.main_pass_lbl.Name = "main_pass_lbl";
            this.main_pass_lbl.Size = new System.Drawing.Size(69, 17);
            this.main_pass_lbl.TabIndex = 1;
            this.main_pass_lbl.Text = "Password";
            // 
            // main_user_txt
            // 
            this.main_user_txt.Location = new System.Drawing.Point(160, 49);
            this.main_user_txt.Name = "main_user_txt";
            this.main_user_txt.Size = new System.Drawing.Size(200, 20);
            this.main_user_txt.TabIndex = 2;
            // 
            // main_pass_txt
            // 
            this.main_pass_txt.Location = new System.Drawing.Point(160, 74);
            this.main_pass_txt.Name = "main_pass_txt";
            this.main_pass_txt.PasswordChar = '*';
            this.main_pass_txt.Size = new System.Drawing.Size(200, 20);
            this.main_pass_txt.TabIndex = 3;
            // 
            // main_ok_btn
            // 
            this.main_ok_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.main_ok_btn.FlatAppearance.BorderSize = 0;
            this.main_ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_ok_btn.Location = new System.Drawing.Point(193, 111);
            this.main_ok_btn.Name = "main_ok_btn";
            this.main_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.main_ok_btn.TabIndex = 4;
            this.main_ok_btn.Text = "OK";
            this.main_ok_btn.UseVisualStyleBackColor = false;
            this.main_ok_btn.Click += new System.EventHandler(this.main_ok_btn_Click);
            // 
            // main_cancel_btn
            // 
            this.main_cancel_btn.BackColor = System.Drawing.Color.Crimson;
            this.main_cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.main_cancel_btn.FlatAppearance.BorderSize = 0;
            this.main_cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_cancel_btn.Location = new System.Drawing.Point(285, 111);
            this.main_cancel_btn.Name = "main_cancel_btn";
            this.main_cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.main_cancel_btn.TabIndex = 5;
            this.main_cancel_btn.Text = "Cancel";
            this.main_cancel_btn.UseVisualStyleBackColor = false;
            this.main_cancel_btn.Click += new System.EventHandler(this.main_cancel_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::POS.Properties.Resources.POS__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AcceptButton = this.main_ok_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::POS.Properties.Resources.POS__21_;
            this.CancelButton = this.main_cancel_btn;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.main_cancel_btn);
            this.Controls.Add(this.main_ok_btn);
            this.Controls.Add(this.main_pass_txt);
            this.Controls.Add(this.main_user_txt);
            this.Controls.Add(this.main_pass_lbl);
            this.Controls.Add(this.main_user_lbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_user_lbl;
        private System.Windows.Forms.Label main_pass_lbl;
        private System.Windows.Forms.TextBox main_user_txt;
        private System.Windows.Forms.TextBox main_pass_txt;
        private System.Windows.Forms.Button main_ok_btn;
        private System.Windows.Forms.Button main_cancel_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

