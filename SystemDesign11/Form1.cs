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

                radioButton1Checked();

            }
            else if (radioButton2.Checked)
            {

                radioButton2Checked();

            }
            else if (radioButton3.Checked)
            {

                radioButton3Checked();

            }
            else if (radioButton4.Checked)
            {

                radioButton4Checked();

            }
            else
            {


                Debug.Print("???");

            }

        }

        private void radioButton4Checked()
        {

            Debug.Print("radioButton4");

        }

        private void radioButton3Checked()
        {

            Debug.Print("radioButton3");

        }

        private void radioButton2Checked()
        {

            Debug.Print("radioButton2");

        }

        private void radioButton1Checked()
        {

            Debug.Print("radioButton1");

        }
    }
}
