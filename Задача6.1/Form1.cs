using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "A";
            button1.BackColor = SystemColors.ControlDarkDark;
            button2.Text = "B";
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Width = button1.Width;
            button2.Height = button1.Height;
            this.BackColor = SystemColors.WindowText;
            this.Height = button1.Height*6;
            this.Width = button1.Width*2;
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Math.Abs(button1.Location.Y - button2.Location.Y) - 10 >= (button2.Height/2 + button1.Height/2))
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 10);
                button2.Location = new Point(button2.Location.X, button2.Location.Y - 10);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((button1.Location.Y - 10 >= 0) & (button2.Location.Y < 231))
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 10);
                button2.Location = new Point(button2.Location.X, button2.Location.Y + 10);
            }
        }
    }
}