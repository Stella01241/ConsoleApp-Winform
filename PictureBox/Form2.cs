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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string []_picSourse = new string[] {"pic1","pic2" };

        private void Form2_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.AddRange(new string[] { "pic1","pic2"});
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = this.comboBox1.SelectedItem as string;
            if (Array.IndexOf(_picSourse,val) != -1)
            {
                if (val =="pic1")
                
                    this.pictureBox1.Image = Image.FromFile("image\\pic1.jpg");
                else if(val == "pic2")
                    this.pictureBox1.Image =new Bitmap("image\\pic2.jpg");

            }
        }
    }
}
