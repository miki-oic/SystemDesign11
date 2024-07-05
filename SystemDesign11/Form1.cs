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
             * 選択肢が増えるたびにテストが必要。
             * ※未選択の判定も必要となり非効率
             * おなじクラス内に質の違う実装コードが書かれるのでメンテナンス性が低い。
             * データの分離が難しいのでバグが発生しやすい。
             * 高機能すぎて派生開発が難しい。
             * 
             * デザインパターンで解決することはできるが、大きな変更となり、コストが高い。
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
