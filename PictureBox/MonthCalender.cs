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
    public partial class MonthCalender : Form
    {
        public MonthCalender()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.monthCalendar1.SelectionStart;
            DateTime endDate = this.monthCalendar1.SelectionEnd;
            this.label1.Text =
                $"{startDate}~ {Environment.NewLine}{endDate}";

        }
    }
}
