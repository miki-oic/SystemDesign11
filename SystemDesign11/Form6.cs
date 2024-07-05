using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDesign11
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Form2(this).Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            new Form3(this).Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            new Form4(this).Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            new Form5(this).Show();

        }
    }
}
