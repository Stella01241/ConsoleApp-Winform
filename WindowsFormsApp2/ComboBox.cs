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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  this.label1.Text = (this.comboBox1.SelectedIndex).ToString();
            this.label1.Text = this.comboBox1.SelectedItem as string;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedItem = "無照律師";
        }
    }
}
