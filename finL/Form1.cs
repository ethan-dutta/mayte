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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainscope_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void variables_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Owner = this;

            f4.StartPosition = FormStartPosition.Manual;

            f4.Location = this.Location;

            f4.Show();

            this.Hide();
        }

        private void functions_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.Owner = this;

            f5.StartPosition = FormStartPosition.Manual;

            f5.Location = this.Location;

            f5.Show();

            this.Hide();
        }


    }
}
