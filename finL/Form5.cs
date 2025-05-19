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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void variables_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();

            this.Close();
        }

        private void test_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();

            f8.Owner = this;

            f8.StartPosition = FormStartPosition.Manual;

            f8.Location = this.Location;

            f8.Show();

            this.Hide();
        }
    }
}
