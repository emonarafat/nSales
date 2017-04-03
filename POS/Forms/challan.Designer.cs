namespace POS
{
    partial class challan
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
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.linkLabelshow = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_exhist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.textBox_tn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_carriage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_party = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addrlbl = new System.Windows.Forms.Label();
            this.contlbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(251, 325);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(127, 33);
            this.btn_print.TabIndex = 14;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(389, 325);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(123, 33);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.panel_close_Click);
            // 
            // linkLabelshow
            // 
            this.linkLabelshow.AutoSize = true;
            this.linkLabelshow.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelshow.LinkColor = System.Drawing.Color.MintCream;
            this.linkLabelshow.Location = new System.Drawing.Point(44, 335);
            this.linkLabelshow.Name = "linkLabelshow";
            this.linkLabelshow.Size = new System.Drawing.Size(107, 13);
            this.linkLabelshow.TabIndex = 37;
            this.linkLabelshow.TabStop = true;
            this.linkLabelshow.Text = "Show Challan History";
            this.linkLabelshow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelshow_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImage = global::POS.Properties.Resources.bg;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_exhist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 365);
            this.panel2.TabIndex = 56;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(9, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 318);
            this.panel3.TabIndex = 41;
            // 
            // btn_exhist
            // 
            this.btn_exhist.BackColor = System.Drawing.Color.Transparent;
            this.btn_exhist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_exhist.FlatAppearance.BorderSize = 0;
            this.btn_exhist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exhist.Image = global::POS.Properties.Resources.POS__6_;
            this.btn_exhist.Location = new System.Drawing.Point(490, 3);
            this.btn_exhist.Name = "btn_exhist";
            this.btn_exhist.Size = new System.Drawing.Size(27, 26);
            this.btn_exhist.TabIndex = 40;
            this.btn_exhist.UseVisualStyleBackColor = false;
            this.btn_exhist.Click += new System.EventHandler(this.btn_exhist_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::POS.Properties.Resources.POS__5_;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.contlbl);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.addrlbl);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.textBox_tn);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_weight);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_carriage);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_party);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 310);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "No. of Carriage:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::POS.Properties.Resources.POS__11_;
            this.pictureBox1.Location = new System.Drawing.Point(20, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(209, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Name the Employee...";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_title.Location = new System.Drawing.Point(366, 247);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(115, 41);
            this.lbl_title.TabIndex = 40;
            this.lbl_title.Text = "Challan";
            // 
            // textBox_tn
            // 
            this.textBox_tn.Location = new System.Drawing.Point(211, 167);
            this.textBox_tn.Name = "textBox_tn";
            this.textBox_tn.Size = new System.Drawing.Size(160, 20);
            this.textBox_tn.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Truck Number:";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(360, 141);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(79, 20);
            this.textBox_weight.TabIndex = 11;
            this.textBox_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Weight:";
            // 
            // textBox_carriage
            // 
            this.textBox_carriage.Location = new System.Drawing.Point(211, 142);
            this.textBox_carriage.Name = "textBox_carriage";
            this.textBox_carriage.Size = new System.Drawing.Size(79, 20);
            this.textBox_carriage.TabIndex = 10;
            this.textBox_carriage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "TK";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(211, 192);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ShortcutsEnabled = false;
            this.txt_amount.Size = new System.Drawing.Size(132, 20);
            this.txt_amount.TabIndex = 13;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Amount:";
            // 
            // txt_party
            // 
            this.txt_party.Location = new System.Drawing.Point(211, 118);
            this.txt_party.Name = "txt_party";
            this.txt_party.Size = new System.Drawing.Size(228, 20);
            this.txt_party.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Issued By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name of Party:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS.Properties.Resources.lgo1;
            this.pictureBox2.Location = new System.Drawing.Point(72, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(122, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Address:";
            // 
            // addrlbl
            // 
            this.addrlbl.AutoSize = true;
            this.addrlbl.BackColor = System.Drawing.Color.Transparent;
            this.addrlbl.Location = new System.Drawing.Point(209, 241);
            this.addrlbl.Name = "addrlbl";
            this.addrlbl.Size = new System.Drawing.Size(111, 13);
            this.addrlbl.TabIndex = 60;
            this.addrlbl.Text = "Name the Employee...";
            // 
            // contlbl
            // 
            this.contlbl.AutoSize = true;
            this.contlbl.BackColor = System.Drawing.Color.Transparent;
            this.contlbl.Location = new System.Drawing.Point(209, 262);
            this.contlbl.Name = "contlbl";
            this.contlbl.Size = new System.Drawing.Size(111, 13);
            this.contlbl.TabIndex = 62;
            this.contlbl.Text = "Name the Employee...";
            this.contlbl.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(122, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Contact No:";
            // 
            // challan
            // 
            this.AcceptButton = this.btn_print;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::POS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(520, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linkLabelshow);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "challan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Challan";
            this.Load += new System.EventHandler(this.challan_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_party;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print;
        
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox textBox_tn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_carriage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelshow;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exhist;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label contlbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label addrlbl;
        private System.Windows.Forms.Label label11;
    }
}