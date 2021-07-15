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
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Today.AddDays(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.label1.Text = "已選取:" + this.dateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
