
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.RadioButton = new System.Windows.Forms.Button();
            this.CheckBox = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.Button();
            this.ListBoxForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListBoxForm2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RadioButton
            // 
            this.RadioButton.Location = new System.Drawing.Point(62, 50);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Size = new System.Drawing.Size(162, 45);
            this.RadioButton.TabIndex = 1;
            this.RadioButton.Text = "RadioButton";
            this.RadioButton.UseVisualStyleBackColor = true;
            this.RadioButton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // CheckBox
            // 
            this.CheckBox.Location = new System.Drawing.Point(62, 117);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(162, 42);
            this.CheckBox.TabIndex = 2;
            this.CheckBox.Text = "Checkbox";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(62, 188);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(142, 40);
            this.GroupBox.TabIndex = 3;
            this.GroupBox.Text = "GroupBox";
            this.GroupBox.UseVisualStyleBackColor = true;
            this.GroupBox.Click += new System.EventHandler(this.GroupBox_Click);
            // 
            // Container
            // 
            this.Container.Location = new System.Drawing.Point(62, 251);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(142, 40);
            this.Container.TabIndex = 4;
            this.Container.Text = "Container-Tab";
            this.Container.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Location = new System.Drawing.Point(62, 308);
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(162, 38);
            this.TabControl.TabIndex = 5;
            this.TabControl.Text = "TabControl";
            this.TabControl.UseVisualStyleBackColor = true;
            this.TabControl.Click += new System.EventHandler(this.button6_Click);
            // 
            // ListBoxForm
            // 
            this.ListBoxForm.Location = new System.Drawing.Point(281, 46);
            this.ListBoxForm.Name = "ListBoxForm";
            this.ListBoxForm.Size = new System.Drawing.Size(171, 49);
            this.ListBoxForm.TabIndex = 6;
            this.ListBoxForm.Text = "ListBoxForm";
            this.ListBoxForm.UseVisualStyleBackColor = true;
            this.ListBoxForm.Click += new System.EventHandler(this.ListBoxForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListBoxForm2
            // 
            this.ListBoxForm2.Location = new System.Drawing.Point(292, 117);
            this.ListBoxForm2.Name = "ListBoxForm2";
            this.ListBoxForm2.Size = new System.Drawing.Size(160, 59);
            this.ListBoxForm2.TabIndex = 8;
            this.ListBoxForm2.Text = "ListBoxForm2";
            this.ListBoxForm2.UseVisualStyleBackColor = true;
            this.ListBoxForm2.Click += new System.EventHandler(this.ListBoxForm2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Combobox";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 72);
            this.button4.TabIndex = 10;
            this.button4.Text = "CheckBoxList";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ListBoxForm2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListBoxForm);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.RadioButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RadioButton;
        private System.Windows.Forms.Button CheckBox;
        private System.Windows.Forms.Button GroupBox;
        private System.Windows.Forms.Button Container;
        private System.Windows.Forms.Button TabControl;
        private System.Windows.Forms.Button ListBoxForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ListBoxForm2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

