using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;
        Test_TextBox _testBox;

        public Form1()
        {
            InitializeComponent();
            string[] strs =
            {
                "あか",
                "あお",
                "きいろ",
                "みどり",
                "くろ",
                "しろ",
                "ちゃいろ",
                "ピンク",
                "むらさき",
                "きみどり"
            };

            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, strs[i],(i % 5) * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }

            _testLabel = new TestLabel("らべるです。", 10,200,500,100);
            Controls.Add(_testLabel);

            _testBox = new Test_TextBox("textboxです。", 10, 300, 500, 100);
            Controls.Add(_testBox);


            //Label label = new Label();
            //label.Location = new Point(30,400);
            //label.Text = "らべるです。";
            //Controls.Add(label);
        }

        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

        public string ButtonLabelReplacement(string str)
        {
            string s = _testBox.TextReplacement(str);


            return s;
        }

    }
}
