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
    public partial class Updown : Form
    {
        public Updown()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.label3.Text = this.numericUpDown1.Value.ToString();

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            this.label4.Text = this.numericUpDown1.Value.ToString();
        }

        private void Updown_Load(object sender, EventArgs e)
        {
            this.numericUpDown1.Value = 1500;
            this.domainUpDown1.SelectedIndex = 1;
        }
    }
}
