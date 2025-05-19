using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace finL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void variables_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();

            this.Close();
        }

        private void functions_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.Show();

            this.Close();

        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            this.Owner = f1;
            this.Owner.Show();

            this.Close();
        }

        private void test_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Owner = this;

            f6.StartPosition = FormStartPosition.Manual;

            f6.Location = this.Location;

            f6.Show();

            this.Hide();
        }
    }
}
