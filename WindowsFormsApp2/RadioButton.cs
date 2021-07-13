using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RadioButton : Form
    {
        public RadioButton()
        {
            InitializeComponent();
        }

        private void RadioButton_Load(object sender, EventArgs e)
        {
            this.radioButton4.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var rbtn = sender as RadioButton;
            //if (rbtn.Checked)
            //{
            //    this.label1.Text = rbtn.Text + "Picked";
            //}
        }
    }
}
