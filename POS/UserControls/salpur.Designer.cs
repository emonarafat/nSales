namespace POS
{
    partial class salpur
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
            this.pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_sa = new System.Windows.Forms.Button();
            this.btn_clall = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.free3_panel = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phigh = new System.Windows.Forms.TextBox();
            this.checkBox_pri = new System.Windows.Forms.CheckBox();
            this.checkBoxmod = new System.Windows.Forms.CheckBox();
            this.checkBox_tp = new System.Windows.Forms.CheckBox();
            this.checkBox_gen = new System.Windows.Forms.CheckBox();
            this.txt__plow = new System.Windows.Forms.TextBox();
            this.comboBox_lvl3 = new System.Windows.Forms.ComboBox();
            this.comboBox_lvl2 = new System.Windows.Forms.ComboBox();
            this.comboBox_lvl1 = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.free3_panel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pid,
            this.date,
            this.gen,
            this.tp,
            this.uprice,
            this.quantity,
            this.amount,
            this.sp});
            this.list_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_ex.FullRowSelect = true;
            this.list_ex.GridLines = true;
            this.list_ex.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_ex.Location = new System.Drawing.Point(0, 186);
            this.list_ex.MultiSelect = false;
            this.list_ex.Name = "list_ex";
            this.list_ex.Size = new System.Drawing.Size(918, 295);
            this.list_ex.TabIndex = 42;
            this.list_ex.UseCompatibleStateImageBehavior = false;
            this.list_ex.View = System.Windows.Forms.View.Details;
            // 
            // pid
            // 
            this.pid.Text = "Product ID";
            this.pid.Width = 120;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 120;
            // 
            // gen
            // 
            this.gen.Text = "Generic";
            this.gen.Width = 120;
            // 
            // tp
            // 
            this.tp.Text = "Type";
            this.tp.Width = 120;
            // 
            // uprice
            // 
            this.uprice.Text = "Unit Price";
            this.uprice.Width = 100;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 100;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 100;
            // 
            // sp
            // 
            this.sp.Text = "Sold/Purchased";
            this.sp.Width = 135;
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
            this.lbl_title.Size = new System.Drawing.Size(458, 51);
            this.lbl_title.TabIndex = 52;
            this.lbl_title.Text = "Sales and Purchase History";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_phigh);
            this.panel1.Controls.Add(this.checkBox_pri);
            this.panel1.Controls.Add(this.checkBoxmod);
            this.panel1.Controls.Add(this.checkBox_tp);
            this.panel1.Controls.Add(this.checkBox_gen);
            this.panel1.Controls.Add(this.txt__plow);
            this.panel1.Controls.Add(this.comboBox_lvl3);
            this.panel1.Controls.Add(this.comboBox_lvl2);
            this.panel1.Controls.Add(this.comboBox_lvl1);
            this.panel1.Location = new System.Drawing.Point(61, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 65);
            this.panel1.TabIndex = 53;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(687, 26);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 46;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "-";
            // 
            // txt_phigh
            // 
            this.txt_phigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phigh.Location = new System.Drawing.Point(600, 28);
            this.txt_phigh.Name = "txt_phigh";
            this.txt_phigh.ShortcutsEnabled = false;
            this.txt_phigh.Size = new System.Drawing.Size(81, 20);
            this.txt_phigh.TabIndex = 44;
            this.txt_phigh.Text = "0";
            this.txt_phigh.Visible = false;
            this.txt_phigh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // checkBox_pri
            // 
            this.checkBox_pri.AutoSize = true;
            this.checkBox_pri.Location = new System.Drawing.Point(506, 6);
            this.checkBox_pri.Name = "checkBox_pri";
            this.checkBox_pri.Size = new System.Drawing.Size(101, 17);
            this.checkBox_pri.TabIndex = 43;
            this.checkBox_pri.Text = "Search by Price";
            this.checkBox_pri.UseVisualStyleBackColor = true;
            this.checkBox_pri.CheckedChanged += new System.EventHandler(this.checkBox_pri_CheckedChanged);
            // 
            // checkBoxmod
            // 
            this.checkBoxmod.AutoSize = true;
            this.checkBoxmod.Location = new System.Drawing.Point(352, 6);
            this.checkBoxmod.Name = "checkBoxmod";
            this.checkBoxmod.Size = new System.Drawing.Size(106, 17);
            this.checkBoxmod.TabIndex = 42;
            this.checkBoxmod.Text = "Search by Model";
            this.checkBoxmod.UseVisualStyleBackColor = true;
            this.checkBoxmod.CheckedChanged += new System.EventHandler(this.checkBoxmod_CheckedChanged);
            // 
            // checkBox_tp
            // 
            this.checkBox_tp.AutoSize = true;
            this.checkBox_tp.Location = new System.Drawing.Point(196, 6);
            this.checkBox_tp.Name = "checkBox_tp";
            this.checkBox_tp.Size = new System.Drawing.Size(101, 17);
            this.checkBox_tp.TabIndex = 41;
            this.checkBox_tp.Text = "Search by Type";
            this.checkBox_tp.UseVisualStyleBackColor = true;
            this.checkBox_tp.CheckedChanged += new System.EventHandler(this.checkBox_tp_CheckedChanged);
            // 
            // checkBox_gen
            // 
            this.checkBox_gen.AutoSize = true;
            this.checkBox_gen.Location = new System.Drawing.Point(38, 6);
            this.checkBox_gen.Name = "checkBox_gen";
            this.checkBox_gen.Size = new System.Drawing.Size(114, 17);
            this.checkBox_gen.TabIndex = 40;
            this.checkBox_gen.Text = "Search by Generic";
            this.checkBox_gen.UseVisualStyleBackColor = true;
            this.checkBox_gen.CheckedChanged += new System.EventHandler(this.checkBox_gen_CheckedChanged);
            // 
            // txt__plow
            // 
            this.txt__plow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__plow.Location = new System.Drawing.Point(506, 28);
            this.txt__plow.Name = "txt__plow";
            this.txt__plow.ShortcutsEnabled = false;
            this.txt__plow.Size = new System.Drawing.Size(81, 20);
            this.txt__plow.TabIndex = 35;
            this.txt__plow.Text = "0";
            this.txt__plow.Visible = false;
            this.txt__plow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // comboBox_lvl3
            // 
            this.comboBox_lvl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_lvl3.FormattingEnabled = true;
            this.comboBox_lvl3.Items.AddRange(new object[] {
            "Apple",
            "Bannana",
            "Jack Fruit",
            "Mango",
            "Orange"});
            this.comboBox_lvl3.Location = new System.Drawing.Point(352, 28);
            this.comboBox_lvl3.MaxDropDownItems = 12;
            this.comboBox_lvl3.Name = "comboBox_lvl3";
            this.comboBox_lvl3.Size = new System.Drawing.Size(150, 21);
            this.comboBox_lvl3.Sorted = true;
            this.comboBox_lvl3.TabIndex = 34;
            this.comboBox_lvl3.Visible = false;
            this.comboBox_lvl3.SelectedIndexChanged += new System.EventHandler(this.comboBox_lvl3_SelectedIndexChanged);
            // 
            // comboBox_lvl2
            // 
            this.comboBox_lvl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_lvl2.FormattingEnabled = true;
            this.comboBox_lvl2.Items.AddRange(new object[] {
            "Apple",
            "Bannana",
            "Jack Fruit",
            "Mango",
            "Orange"});
            this.comboBox_lvl2.Location = new System.Drawing.Point(196, 28);
            this.comboBox_lvl2.MaxDropDownItems = 12;
            this.comboBox_lvl2.Name = "comboBox_lvl2";
            this.comboBox_lvl2.Size = new System.Drawing.Size(150, 21);
            this.comboBox_lvl2.Sorted = true;
            this.comboBox_lvl2.TabIndex = 33;
            this.comboBox_lvl2.Visible = false;
            this.comboBox_lvl2.SelectedIndexChanged += new System.EventHandler(this.comboBox_lvl2_SelectedIndexChanged);
            // 
            // comboBox_lvl1
            // 
            this.comboBox_lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_lvl1.FormattingEnabled = true;
            this.comboBox_lvl1.Location = new System.Drawing.Point(38, 28);
            this.comboBox_lvl1.MaxDropDownItems = 12;
            this.comboBox_lvl1.Name = "comboBox_lvl1";
            this.comboBox_lvl1.Size = new System.Drawing.Size(150, 21);
            this.comboBox_lvl1.Sorted = true;
            this.comboBox_lvl1.TabIndex = 32;
            this.comboBox_lvl1.Visible = false;
            this.comboBox_lvl1.SelectedIndexChanged += new System.EventHandler(this.comboBox_lvl1_SelectedIndexChanged);
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
            // salpur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.free3_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.list_ex);
            this.Controls.Add(this.button_sa);
            this.Name = "salpur";
            this.Size = new System.Drawing.Size(918, 536);
            this.Load += new System.EventHandler(this.salpur_Load);
            this.free3_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView list_ex;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader tp;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.Button button_sa;
        private System.Windows.Forms.Button btn_clall;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ColumnHeader pid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader gen;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel free3_panel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ColumnHeader uprice;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader sp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phigh;
        private System.Windows.Forms.CheckBox checkBox_pri;
        private System.Windows.Forms.CheckBox checkBoxmod;
        private System.Windows.Forms.CheckBox checkBox_tp;
        private System.Windows.Forms.CheckBox checkBox_gen;
        private System.Windows.Forms.TextBox txt__plow;
        private System.Windows.Forms.ComboBox comboBox_lvl3;
        private System.Windows.Forms.ComboBox comboBox_lvl2;
        private System.Windows.Forms.ComboBox comboBox_lvl1;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
