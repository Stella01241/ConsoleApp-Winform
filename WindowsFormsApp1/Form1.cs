using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int _cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            _cnt += 1;
            this.label1.Text = $"點擊第{_cnt}次"; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = $"共{this.textBox1.Text.Length}字";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result=
            MessageBox.Show("確定要儲存嗎?", "moudou winform", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.label1.Text = "Click yes";
            }
        }
    }
}
