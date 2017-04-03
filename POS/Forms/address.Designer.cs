namespace POS
{
    partial class address
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
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addresstxt
            // 
            this.addresstxt.Enabled = false;
            this.addresstxt.Location = new System.Drawing.Point(163, 46);
            this.addresstxt.MaxLength = 300;
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(254, 101);
            this.addresstxt.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Address:";
            // 
            // contacttxt
            // 
            this.contacttxt.Enabled = false;
            this.contacttxt.Location = new System.Drawing.Point(163, 153);
            this.contacttxt.MaxLength = 25;
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(254, 20);
            this.contacttxt.TabIndex = 102;
            this.contacttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 102;
            this.label13.Text = "Contact No:";
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(334, 188);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(83, 33);
            this.change.TabIndex = 104;
            this.change.Text = "Change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(239, 188);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(83, 33);
            this.save.TabIndex = 105;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 261);
            this.Controls.Add(this.save);
            this.Controls.Add(this.change);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "address";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address";
            this.Load += new System.EventHandler(this.address_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button save;
    }
}