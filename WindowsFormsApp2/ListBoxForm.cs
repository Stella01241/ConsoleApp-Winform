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
    public partial class ListBoxForm : Form
    {
        public ListBoxForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.listBox1.Text + ";" + (this.listBox1.SelectedItem as string) + ";" +
                this.listBox1.SelectedIndex;
            //不重複輸出
            this.label2.Text = string.Empty;
            foreach(var item in this.listBox1.SelectedItems)
            {
                this.label2.Text +=
                    item + Environment.NewLine;
            }

            this.label1.Text = this.listBox1.Text + "Checked";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.SelectedItem = "啦啦隊";

            this.listBox1.SelectedItem = "無照律師";
        }

        private void ListBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
