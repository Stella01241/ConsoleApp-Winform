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
    public partial class TimerForm2 : Form
    {
        public TimerForm2()
        {
            InitializeComponent();
        }
        private int _smallTime = 0, _bigTime = 0;
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            this._smallTime += 1;
            if (this._smallTime == 100)
                this._smallTime = 0;
            if (this._smallTime > 90)
                this.label1.ForeColor = Color.Red;
            else if (this._smallTime > 60)
                this.label1.ForeColor = Color.Orange;
            else if (this._smallTime > 30)
                this.label1.ForeColor = Color.Blue;
            else
                this.label1.ForeColor = Color.Black;
            this.label1.Text = this._smallTime.ToString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this._bigTime += 1;
            this.label2.Text = this._bigTime.ToString();
        }
    }
}
