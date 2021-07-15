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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Updown().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ScrolBar().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new TimerForm().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new TimerForm2().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MonthCalender().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new DateTimePicker().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new KeyboardForm().Show();
        }
    }
}
