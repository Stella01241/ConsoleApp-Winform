using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class KeyboardForm : Form
    {
        public KeyboardForm()
        {
            InitializeComponent();
        }

        private void KeyboardForm_Load(object sender, EventArgs e)
        {
            this.label1.Text = string.Empty;
        }

        private void KeyboardForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.label1.Text += "KeyDown" + Environment.NewLine;
        }

        private void KeyboardForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.label1.Text += "KeyPress" + e.KeyChar + Environment.NewLine;
            if (e.KeyChar ==13)
            {
                this.label1.Text = string.Empty;
            }
        }

        private void KeyboardForm_KeyUp(object sender, KeyEventArgs e)
        {
            this.label1.Text += "KeyUp" + Environment.NewLine;
        }
    }
}
