﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class TestButton : Button
    {
        Form1 _form1;
        public TestButton(Form1 form1,int id, int x, int y, int width, int height)
        {
            _form1 = form1;
            Click += OnClick;
            Text = id.ToString();
            Location = new Point(x, y);
            Size = new Size(width, height);

        }

        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdate(Text);
        }
    }
}
