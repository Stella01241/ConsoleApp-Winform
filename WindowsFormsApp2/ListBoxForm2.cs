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
    public partial class ListBoxForm2 : Form
    {
        public ListBoxForm2()
        {
            InitializeComponent();
        }
        class TVshow
        {
            public string Name { get; set; }
            public string SortName { get; set; }
        }

        private void ListBoxForm2_Load(object sender, EventArgs e)
        {
            List<TVshow> list = new List<TVshow>();
            list.Add(new TVshow() { Name = "紙牌屋" });
            list.Add(new TVshow() { Name = "無照律師" });
            list.Add(new TVshow() { Name = "新世紀福爾摩斯" });
            list.Add(new TVshow() { Name = "tv1" });

            this.listBox1.DisplayMember = "ShortName";
            this.listBox1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.listBox1.Text + "Checked";
        }
    }
}
