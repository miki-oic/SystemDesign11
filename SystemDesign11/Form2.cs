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

    public partial class Form2 : Form
    {

        private Form form;

        public Form2(Form form)
        {

            InitializeComponent();

            this.form = form;

            this.form.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            form.Show();

        }

    }

}
