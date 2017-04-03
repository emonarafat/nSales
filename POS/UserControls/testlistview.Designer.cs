namespace POS
{
    partial class testlistview
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
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.listViewEx1 = new ListViewEx.ListViewEx();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.pns_splitContainer = new System.Windows.Forms.SplitContainer();
            this.free_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLess = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_pur = new System.Windows.Forms.Button();
            this.btn_sel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pns_splitContainer)).BeginInit();
            this.pns_splitContainer.Panel1.SuspendLayout();
            this.pns_splitContainer.Panel2.SuspendLayout();
            this.pns_splitContainer.SuspendLayout();
            this.free_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(0, 0);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 0;
            this.textBoxModel.Visible = false;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // listViewEx1
            // 
            this.listViewEx1.AllowColumnReorder = true;
            this.listViewEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEx1.DoubleClickActivation = false;
            this.listViewEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.GridLines = true;
            this.listViewEx1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEx1.Location = new System.Drawing.Point(2, 86);
            this.listViewEx1.MultiSelect = false;
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(795, 412);
            this.listViewEx1.TabIndex = 7;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(8, 8);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.ShortcutsEnabled = false;
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 8;
            this.textBoxQuantity.Text = "1";
            this.textBoxQuantity.Visible = false;
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // pns_splitContainer
            // 
            this.pns_splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pns_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.pns_splitContainer.IsSplitterFixed = true;
            this.pns_splitContainer.Location = new System.Drawing.Point(0, 504);
            this.pns_splitContainer.Name = "pns_splitContainer";
            // 
            // pns_splitContainer.Panel1
            // 
            this.pns_splitContainer.Panel1.Controls.Add(this.button_clear);
            this.pns_splitContainer.Panel1.Controls.Add(this.btn_remove);
            // 
            // pns_splitContainer.Panel2
            // 
            this.pns_splitContainer.Panel2.Controls.Add(this.btn_cal);
            this.pns_splitContainer.Panel2.Controls.Add(this.free_panel);
            this.pns_splitContainer.Panel2.Controls.Add(this.btn_pur);
            this.pns_splitContainer.Panel2.Controls.Add(this.btn_sel);
            this.pns_splitContainer.Size = new System.Drawing.Size(800, 96);
            this.pns_splitContainer.SplitterDistance = 218;
            this.pns_splitContainer.SplitterWidth = 1;
            this.pns_splitContainer.TabIndex = 9;
            // 
            // free_panel
            // 
            this.free_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.free_panel.Controls.Add(this.label2);
            this.free_panel.Controls.Add(this.lbl_payment);
            this.free_panel.Controls.Add(this.label4);
            this.free_panel.Controls.Add(this.label1);
            this.free_panel.Controls.Add(this.textBoxLess);
            this.free_panel.Controls.Add(this.lbl_total);
            this.free_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free_panel.Location = new System.Drawing.Point(252, 12);
            this.free_panel.Name = "free_panel";
            this.free_panel.Size = new System.Drawing.Size(226, 70);
            this.free_panel.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Payment:";
            // 
            // lbl_payment
            // 
            this.lbl_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_payment.Location = new System.Drawing.Point(120, 49);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_payment.Size = new System.Drawing.Size(95, 20);
            this.lbl_payment.TabIndex = 33;
            this.lbl_payment.Text = "0";
            this.lbl_payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Less:";
            // 
            // textBoxLess
            // 
            this.textBoxLess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLess.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxLess.Location = new System.Drawing.Point(120, 27);
            this.textBoxLess.Name = "textBoxLess";
            this.textBoxLess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLess.ShortcutsEnabled = false;
            this.textBoxLess.Size = new System.Drawing.Size(90, 19);
            this.textBoxLess.TabIndex = 31;
            this.textBoxLess.Text = "0";
            this.textBoxLess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxLess.TextChanged += new System.EventHandler(this.textBoxLess_TextChanged);
            this.textBoxLess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_total.Location = new System.Drawing.Point(116, 5);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_total.Size = new System.Drawing.Size(99, 20);
            this.lbl_total.TabIndex = 28;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semilight", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_title.Location = new System.Drawing.Point(3, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(347, 51);
            this.lbl_title.TabIndex = 64;
            this.lbl_title.Text = "Sales and Purchases";
            // 
            // button_clear
            // 
            this.button_clear.Image = global::POS.Properties.Resources.POS__6_;
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clear.Location = new System.Drawing.Point(106, 25);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(67, 42);
            this.button_clear.TabIndex = 50;
            this.button_clear.Text = "Clear";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Image = global::POS.Properties.Resources.POS__18_;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(9, 25);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(91, 42);
            this.btn_remove.TabIndex = 49;
            this.btn_remove.Text = "Remove";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Image = global::POS.Properties.Resources.POS__4_;
            this.btn_cal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cal.Location = new System.Drawing.Point(484, 25);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(91, 42);
            this.btn_cal.TabIndex = 47;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_pur
            // 
            this.btn_pur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pur.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_pur.Image = global::POS.Properties.Resources.POS__15_;
            this.btn_pur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pur.Location = new System.Drawing.Point(132, 27);
            this.btn_pur.Name = "btn_pur";
            this.btn_pur.Size = new System.Drawing.Size(112, 38);
            this.btn_pur.TabIndex = 51;
            this.btn_pur.Text = " Purchase";
            this.btn_pur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pur.UseVisualStyleBackColor = true;
            this.btn_pur.Click += new System.EventHandler(this.btn_pur_Click);
            // 
            // btn_sel
            // 
            this.btn_sel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_sel.Image = global::POS.Properties.Resources.POS__16_;
            this.btn_sel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sel.Location = new System.Drawing.Point(14, 27);
            this.btn_sel.Name = "btn_sel";
            this.btn_sel.Size = new System.Drawing.Size(112, 38);
            this.btn_sel.TabIndex = 50;
            this.btn_sel.Text = "Sell       ";
            this.btn_sel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sel.UseVisualStyleBackColor = true;
            this.btn_sel.Click += new System.EventHandler(this.btn_sel_Click);
            // 
            // testlistview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pns_splitContainer);
            this.Controls.Add(this.listViewEx1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxModel);
            this.Name = "testlistview";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.testlistview_Load);
            this.SizeChanged += new System.EventHandler(this.testlistview_SizeChanged);
            this.pns_splitContainer.Panel1.ResumeLayout(false);
            this.pns_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pns_splitContainer)).EndInit();
            this.pns_splitContainer.ResumeLayout(false);
            this.free_panel.ResumeLayout(false);
            this.free_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.ListView listView1;
        //private System.Windows.Forms.ColumnHeader columnHeader1;
        //private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.SplitContainer pns_splitContainer;
        private System.Windows.Forms.Button btn_pur;
        private System.Windows.Forms.Button btn_sel;
        private System.Windows.Forms.Panel free_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLess;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button button_clear;
    }
}
