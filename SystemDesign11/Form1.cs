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
            /*
             * �I�����������邽�тɃe�X�g���K�v�B
             * �����I���̔�����K�v�ƂȂ�����
             * ���Ȃ��N���X���Ɏ��̈Ⴄ�����R�[�h���������̂Ń����e�i���X�����Ⴂ�B
             * �f�[�^�̕���������̂Ńo�O���������₷���B
             * ���@�\�����Ĕh���J��������B
             * 
             * �f�U�C���p�^�[���ŉ������邱�Ƃ͂ł��邪�A�傫�ȕύX�ƂȂ�A�R�X�g�������B
             */
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
