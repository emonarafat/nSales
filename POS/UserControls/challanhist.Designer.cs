namespace POS
{
    partial class challanhist
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.list_ex = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_sa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // list_ex
            // 
            this.list_ex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.list_ex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_ex.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.tn,
            this.nc,
            this.weight,
            this.amount});
            this.list_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_ex.FullRowSelect = true;
            this.list_ex.GridLines = true;
            this.list_ex.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_ex.Location = new System.Drawing.Point(0, 31);
            this.list_ex.MultiSelect = false;
            this.list_ex.Name = "list_ex";
            this.list_ex.Size = new System.Drawing.Size(494, 306);
            this.list_ex.TabIndex = 39;
            this.list_ex.UseCompatibleStateImageBehavior = false;
            this.list_ex.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // tn
            // 
            this.tn.Text = "Truck No#";
            this.tn.Width = 115;
            // 
            // nc
            // 
            this.nc.Text = "No. of Carriage";
            this.nc.Width = 100;
            // 
            // weight
            // 
            this.weight.Text = "Weight";
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 100;
            // 
            // button_sa
            // 
            this.button_sa.Location = new System.Drawing.Point(226, 4);
            this.button_sa.Name = "button_sa";
            this.button_sa.Size = new System.Drawing.Size(117, 23);
            this.button_sa.TabIndex = 41;
            this.button_sa.Text = "Show All";
            this.button_sa.UseVisualStyleBackColor = true;
            this.button_sa.Click += new System.EventHandler(this.button_sa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "TO";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 51;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Location = new System.Drawing.Point(368, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(123, 23);
            this.btn_print.TabIndex = 56;
            this.btn_print.Text = "Print List";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // challanhist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.list_ex);
            this.Controls.Add(this.button_sa);
            this.Name = "challanhist";
            this.Size = new System.Drawing.Size(494, 340);
            this.Load += new System.EventHandler(this.challanhist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView list_ex;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader tn;
        private System.Windows.Forms.ColumnHeader nc;
        private System.Windows.Forms.Button button_sa;
        private System.Windows.Forms.ColumnHeader weight;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
