using System.Diagnostics;

namespace SystemDesign11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {


                Debug.Print("radioButton1");

            }
            else if (radioButton2.Checked)
            {


                Debug.Print("radioButton2");

            }
            else if (radioButton3.Checked)
            {


                Debug.Print("radioButton3");

            }
            else if (radioButton4.Checked)
            {


                Debug.Print("radioButton4");

            }
            else
            {


                Debug.Print("???");

            }

        }
    }
}
