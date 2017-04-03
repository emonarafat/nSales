namespace POS
{
    partial class stock
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
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Generic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceatPurchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.no_item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_stock = new System.Windows.Forms.ListView();
            this.SellingPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_all = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_phigh = new System.Windows.Forms.TextBox();
            this.checkBox_pri = new System.Windows.Forms.CheckBox();
            this.checkBoxmod = new System.Windows.Forms.CheckBox();
            this.checkBox_tp = new System.Windows.Forms.CheckBox();
            this.checkBox_gen = new System.Windows.Forms.CheckBox();
            this.txt__plow = new System.Windows.Forms.TextBox();
            this.comboBox_lvl3 = new System.Windows.Forms.ComboBox();
            this.comboBox_lvl2 = new System.Windows.Forms.ComboBox();
            this.comboBox_lvl1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.log_splitContainer = new System.Windows.Forms.SplitContainer();
            this.main_user_lbl = new System.Windows.Forms.Label();
            this.main_ok_btn = new System.Windows.Forms.Button();
            this.main_pass_lbl = new System.Windows.Forms.Label();
            this.main_pass_txt = new System.Windows.Forms.TextBox();
            this.main_user_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_removeitem = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_splitContainer)).BeginInit();
            this.log_splitContainer.Panel1.SuspendLayout();
            this.log_splitContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Model
            // 
            this.Model.Text = "Model";
            this.Model.Width = 150;
            // 
            // Generic
            // 
            this.Generic.Text = "Generic";
            this.Generic.Width = 150;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 150;
            // 
            // PriceatPurchase
            // 
            this.PriceatPurchase.Text = "Price at Purchase";
            this.PriceatPurchase.Width = 150;
            // 
            // no_item
            // 
            this.no_item.Text = "No. of Items";
            this.no_item.Width = 100;
            // 
            // list_stock
            // 
            this.list_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_stock.CheckBoxes = true;
            this.list_stock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Model,
            this.Generic,
            this.Type,
            this.PriceatPurchase,
            this.SellingPrice,
            this.no_item});
            this.list_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_stock.FullRowSelect = true;
            this.list_stock.GridLines = true;
            this.list_stock.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_stock.Location = new System.Drawing.Point(0, 145);
            this.list_stock.MultiSelect = false;
            this.list_stock.Name = "list_stock";
            this.list_stock.Size = new System.Drawing.Size(824, 438);
            this.list_stock.TabIndex = 0;
            this.list_stock.UseCompatibleStateImageBehavior = false;
            this.list_stock.View = System.Windows.Forms.View.Details;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Text = "Selling Price";
            this.SellingPrice.Width = 119;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.button_all);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_phigh);
            this.panel1.Controls.Add(this.checkBox_pri);
            this.panel1.Controls.Add(this.checkBoxmod);
            this.panel1.Controls.Add(this.checkBox_tp);
            this.panel1.Controls.Add(this.checkBox_gen);
            this.panel1.Controls.Add(this.txt__plow);
            this.panel1.Controls.Add(this.comboBox_lvl3);
            this.panel1.Controls.Add(this.comboBox_lvl2);
            this.panel1.Controls.Add(this.comboBox_lvl1);
            this.panel1.Location = new System.Drawing.Point(14, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 62);
            this.panel1.TabIndex = 8;
            // 
            // button_all
            // 
            this.button_all.Location = new System.Drawing.Point(687, 2);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(75, 23);
            this.button_all.TabIndex = 47;
            this.button_all.Text = "Show All";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "-";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.log_splitContainer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 627);
            this.panel2.TabIndex = 9;
            // 
            // log_splitContainer
            // 
            this.log_splitContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.log_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.log_splitContainer.IsSplitterFixed = true;
            this.log_splitContainer.Location = new System.Drawing.Point(469, 0);
            this.log_splitContainer.Name = "log_splitContainer";
            this.log_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // log_splitContainer.Panel1
            // 
            this.log_splitContainer.Panel1.Controls.Add(this.main_user_lbl);
            this.log_splitContainer.Panel1.Controls.Add(this.main_ok_btn);
            this.log_splitContainer.Panel1.Controls.Add(this.main_pass_lbl);
            this.log_splitContainer.Panel1.Controls.Add(this.main_pass_txt);
            this.log_splitContainer.Panel1.Controls.Add(this.main_user_txt);
            this.log_splitContainer.Size = new System.Drawing.Size(352, 627);
            this.log_splitContainer.SplitterDistance = 220;
            this.log_splitContainer.SplitterWidth = 1;
            this.log_splitContainer.TabIndex = 11;
            // 
            // main_user_lbl
            // 
            this.main_user_lbl.AutoSize = true;
            this.main_user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.main_user_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_user_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_user_lbl.Location = new System.Drawing.Point(28, 72);
            this.main_user_lbl.Name = "main_user_lbl";
            this.main_user_lbl.Size = new System.Drawing.Size(79, 17);
            this.main_user_lbl.TabIndex = 6;
            this.main_user_lbl.Text = "User Name";
            // 
            // main_ok_btn
            // 
            this.main_ok_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.main_ok_btn.FlatAppearance.BorderSize = 0;
            this.main_ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_ok_btn.Location = new System.Drawing.Point(238, 126);
            this.main_ok_btn.Name = "main_ok_btn";
            this.main_ok_btn.Size = new System.Drawing.Size(75, 23);
            this.main_ok_btn.TabIndex = 10;
            this.main_ok_btn.Text = "OK";
            this.main_ok_btn.UseVisualStyleBackColor = false;
            this.main_ok_btn.Click += new System.EventHandler(this.main_ok_btn_Click);
            // 
            // main_pass_lbl
            // 
            this.main_pass_lbl.AutoSize = true;
            this.main_pass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.main_pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_pass_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.main_pass_lbl.Location = new System.Drawing.Point(28, 97);
            this.main_pass_lbl.Name = "main_pass_lbl";
            this.main_pass_lbl.Size = new System.Drawing.Size(69, 17);
            this.main_pass_lbl.TabIndex = 7;
            this.main_pass_lbl.Text = "Password";
            // 
            // main_pass_txt
            // 
            this.main_pass_txt.Location = new System.Drawing.Point(113, 96);
            this.main_pass_txt.Name = "main_pass_txt";
            this.main_pass_txt.PasswordChar = '*';
            this.main_pass_txt.Size = new System.Drawing.Size(200, 20);
            this.main_pass_txt.TabIndex = 9;
            // 
            // main_user_txt
            // 
            this.main_user_txt.Location = new System.Drawing.Point(113, 71);
            this.main_user_txt.Name = "main_user_txt";
            this.main_user_txt.Size = new System.Drawing.Size(200, 20);
            this.main_user_txt.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btn_removeitem);
            this.panel3.Location = new System.Drawing.Point(18, 586);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 38);
            this.panel3.TabIndex = 10;
            // 
            // btn_removeitem
            // 
            this.btn_removeitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_removeitem.Location = new System.Drawing.Point(686, 0);
            this.btn_removeitem.Name = "btn_removeitem";
            this.btn_removeitem.Size = new System.Drawing.Size(114, 38);
            this.btn_removeitem.TabIndex = 8;
            this.btn_removeitem.Text = "Remove Product";
            this.btn_removeitem.UseVisualStyleBackColor = true;
            this.btn_removeitem.Click += new System.EventHandler(this.btn_removeitem_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_title.Location = new System.Drawing.Point(3, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(125, 51);
            this.lbl_title.TabIndex = 65;
            this.lbl_title.Text = "Stocks";
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.list_stock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.panel3);
            this.Name = "stock";
            this.Size = new System.Drawing.Size(821, 627);
            this.Load += new System.EventHandler(this.stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.log_splitContainer.Panel1.ResumeLayout(false);
            this.log_splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_splitContainer)).EndInit();
            this.log_splitContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Generic;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader PriceatPurchase;
        private System.Windows.Forms.ColumnHeader no_item;
        private System.Windows.Forms.ListView list_stock;
        private System.Windows.Forms.ColumnHeader SellingPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_gen;
        private System.Windows.Forms.TextBox txt__plow;
        private System.Windows.Forms.ComboBox comboBox_lvl3;
        private System.Windows.Forms.ComboBox comboBox_lvl2;
        private System.Windows.Forms.ComboBox comboBox_lvl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phigh;
        private System.Windows.Forms.CheckBox checkBox_pri;
        private System.Windows.Forms.CheckBox checkBoxmod;
        private System.Windows.Forms.CheckBox checkBox_tp;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button main_ok_btn;
        private System.Windows.Forms.TextBox main_pass_txt;
        private System.Windows.Forms.TextBox main_user_txt;
        private System.Windows.Forms.Label main_pass_lbl;
        private System.Windows.Forms.Label main_user_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_removeitem;
        private System.Windows.Forms.SplitContainer log_splitContainer;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button button_all;
    }
}
