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
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }
        private int _zoom = 0;

        private void TimerForm_Load(object sender, EventArgs e)
        {
            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;

            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Size = new Size(18, 18);
            this.pictureBox1.Location = new Point(101, 91);

            this.timer1.Interval = 100;
            this.timer1.Enabled = true;
            this.timer2.Interval = 1000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this._zoom += 1;
            int size = this._zoom * 18;
            int loc = (10 - this._zoom) * 9 + 20;
            this.pictureBox1.Size = new Size(size, size);
            this.pictureBox1.Location = new Point(loc, loc);
            if (this._zoom ==10 )
            {
                this.timer2.Enabled = true;
                this.timer1.Enabled = false;
                this._zoom = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
            this.timer2.Enabled = true;
        }
    }
}
