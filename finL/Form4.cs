using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            this.Owner = f1;
            this.Owner.Show();

            this.Close();
        }

        private void mainscope_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();

            this.Close();
        }

        private void functions_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.Show();

            this.Hide();
        }

        private void test_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();

            f7.Owner = this;

            f7.StartPosition = FormStartPosition.Manual;

            f7.Location = this.Location;

            f7.Show();

            this.Hide();
        }
    }
}
