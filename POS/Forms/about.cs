﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }
        private void panel_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
