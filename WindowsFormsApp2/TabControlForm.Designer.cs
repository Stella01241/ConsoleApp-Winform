
namespace WindowsFormsApp2
{
    partial class TabControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.會員 = new System.Windows.Forms.TabPage();
            this.產品 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.會員列表 = new System.Windows.Forms.TabPage();
            this.新增會員 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.會員.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.會員);
            this.tabControl1.Controls.Add(this.產品);
            this.tabControl1.Controls.Add(this.會員列表);
            this.tabControl1.Controls.Add(this.新增會員);
            this.tabControl1.Location = new System.Drawing.Point(35, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // 會員
            // 
            this.會員.Controls.Add(this.textBox2);
            this.會員.Controls.Add(this.textBox1);
            this.會員.Controls.Add(this.button1);
            this.會員.Location = new System.Drawing.Point(4, 28);
            this.會員.Name = "會員";
            this.會員.Padding = new System.Windows.Forms.Padding(3);
            this.會員.Size = new System.Drawing.Size(716, 328);
            this.會員.TabIndex = 0;
            this.會員.Text = "會員";
            this.會員.UseVisualStyleBackColor = true;
            // 
            // 產品
            // 
            this.產品.Location = new System.Drawing.Point(4, 28);
            this.產品.Name = "產品";
            this.產品.Padding = new System.Windows.Forms.Padding(3);
            this.產品.Size = new System.Drawing.Size(716, 328);
            this.產品.TabIndex = 1;
            this.產品.Text = "產品";
            this.產品.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 2;
            // 
            // 會員列表
            // 
            this.會員列表.Location = new System.Drawing.Point(4, 28);
            this.會員列表.Name = "會員列表";
            this.會員列表.Size = new System.Drawing.Size(716, 328);
            this.會員列表.TabIndex = 2;
            this.會員列表.Text = "會員列表";
            this.會員列表.UseVisualStyleBackColor = true;
            // 
            // 新增會員
            // 
            this.新增會員.Location = new System.Drawing.Point(4, 28);
            this.新增會員.Name = "新增會員";
            this.新增會員.Size = new System.Drawing.Size(716, 328);
            this.新增會員.TabIndex = 3;
            this.新增會員.Text = "新增會員";
            this.新增會員.UseVisualStyleBackColor = true;
            // 
            // TabControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabControlForm";
            this.Text = "TabControlForm";
            this.tabControl1.ResumeLayout(false);
            this.會員.ResumeLayout(false);
            this.會員.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 會員;
        private System.Windows.Forms.TabPage 產品;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage 會員列表;
        private System.Windows.Forms.TabPage 新增會員;
    }
}