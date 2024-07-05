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

    public partial class Form7 : Form
    {

        public Form7()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Form1().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            new Form6().Show();

        }

    }

}
