namespace POS
{
    partial class banklehist
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.list_ex = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bankname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.catagory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.issuedby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_sa = new System.Windows.Forms.Button();
            this.btn_clall = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.free3_panel = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.free3_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // list_ex
            // 
            this.list_ex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_ex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_ex.CheckBoxes = true;
            this.list_ex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Date,
            this.bankname,
            this.acnum,
            this.subject,
            this.catagory,
            this.type,
            this.amount,
            this.issuedby});
            this.list_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_ex.FullRowSelect = true;
            this.list_ex.GridLines = true;
            this.list_ex.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_ex.Location = new System.Drawing.Point(0, 117);
            this.list_ex.MultiSelect = false;
            this.list_ex.Name = "list_ex";
            this.list_ex.Size = new System.Drawing.Size(918, 364);
            this.list_ex.TabIndex = 42;
            this.list_ex.UseCompatibleStateImageBehavior = false;
            this.list_ex.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // bankname
            // 
            this.bankname.Text = "Bank Name";
            this.bankname.Width = 120;
            // 
            // acnum
            // 
            this.acnum.Text = "Account";
            this.acnum.Width = 190;
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            // 
            // catagory
            // 
            this.catagory.Text = "Catagory";
            this.catagory.Width = 100;
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 100;
            // 
            // issuedby
            // 
            this.issuedby.Text = "Issued By";
            this.issuedby.Width = 120;
            // 
            // button_sa
            // 
            this.button_sa.Location = new System.Drawing.Point(323, 86);
            this.button_sa.Name = "button_sa";
            this.button_sa.Size = new System.Drawing.Size(117, 23);
            this.button_sa.TabIndex = 44;
            this.button_sa.Text = "Show All";
            this.button_sa.UseVisualStyleBackColor = true;
            this.button_sa.Click += new System.EventHandler(this.button_sa_Click);
            // 
            // btn_clall
            // 
            this.btn_clall.Location = new System.Drawing.Point(13, 3);
            this.btn_clall.Name = "btn_clall";
            this.btn_clall.Size = new System.Drawing.Size(100, 36);
            this.btn_clall.TabIndex = 45;
            this.btn_clall.Text = "Clear All";
            this.btn_clall.UseVisualStyleBackColor = true;
            this.btn_clall.Click += new System.EventHandler(this.btn_clall_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(118, 3);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(100, 36);
            this.button_remove.TabIndex = 46;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Filter by Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(222, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 49;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "TO";
            // 
            // free3_panel
            // 
            this.free3_panel.Controls.Add(this.btn_clall);
            this.free3_panel.Controls.Add(this.button_remove);
            this.free3_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.free3_panel.Location = new System.Drawing.Point(0, 487);
            this.free3_panel.Name = "free3_panel";
            this.free3_panel.Size = new System.Drawing.Size(918, 49);
            this.free3_panel.TabIndex = 51;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_title.Location = new System.Drawing.Point(3, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(420, 51);
            this.lbl_title.TabIndex = 52;
            this.lbl_title.Text = "Bank Transaction Ledger";
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Location = new System.Drawing.Point(772, 18);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(123, 33);
            this.btn_print.TabIndex = 55;
            this.btn_print.Text = "Print List";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // banklehist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.free3_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.list_ex);
            this.Controls.Add(this.button_sa);
            this.Name = "banklehist";
            this.Size = new System.Drawing.Size(918, 536);
            this.Load += new System.EventHandler(this.loanhist_Load);
            this.free3_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView list_ex;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader acnum;
        private System.Windows.Forms.ColumnHeader catagory;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader issuedby;
        private System.Windows.Forms.Button button_sa;
        private System.Windows.Forms.Button btn_clall;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader bankname;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel free3_panel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
