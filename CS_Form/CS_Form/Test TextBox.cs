using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class Test_TextBox:TextBox
    {
        public Test_TextBox(string str, int x, int y,
           int width, int height)
        {

            // ラベル内に文字を表示させる
            Text = str;

            // ボタンの生成場所を指定
            Location = new Point(x, y);
            //　ボタンの大きさを指定
            Size = new Size(width, height);

        }

        public string TextReplacement(string str)
        {
            string temp = Text;

            Text = str;

            return temp;
        }
    }
}
