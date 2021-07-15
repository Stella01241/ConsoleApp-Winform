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
    public partial class ScrolBar : Form
    {
        public ScrolBar()
        {
            InitializeComponent();
        }
        private Point _startPoint;

        private void ScrolBar_Load(object sender, EventArgs e)
        {
            this.vScrollBar1.Maximum = this.pictureBox1.Height;
            this.hScrollBar1.Maximum = this.pictureBox1.Width;

            this._startPoint = this.pictureBox1.Location;
            this.label1.Text = "0,0";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            var newPoint = new Point(this.pictureBox1.Location.X,
                this._startPoint.Y - this.vScrollBar1.Value);
            this.pictureBox1.Location = newPoint;
            this.label1.Text = $"{this.hScrollBar1.Value},{this.vScrollBar1.Value}";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            var newpoint = new Point(this._startPoint.X - this.hScrollBar1.Value, this.pictureBox1.Location.Y);
            this.pictureBox1.Location = newpoint;
            this.label1.Text = $"{this.hScrollBar1.Value},{this.vScrollBar1.Value}";
        }

       
    }
}
