﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finL
{
    public partial class Form7: Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }
    }
}
