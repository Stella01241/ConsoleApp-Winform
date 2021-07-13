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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new ComboBox().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new TabControlForm().Show();
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            new RadioButton().Show();
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            
        }

        private void GroupBox_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxForm_Click(object sender, EventArgs e)
        {
            new ListBoxForm().Show();
        }

        private void ListBoxForm2_Click(object sender, EventArgs e)
        {

            new ListBoxForm2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ComboBox().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
