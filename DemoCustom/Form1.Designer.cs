namespace DemoCustom
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCu1 = new CustomControl.TextBoxCu();
            this.myTextbox1 = new CustomControl.MyTextbox();
            this.fengTextBoxEx1 = new CustomControl.FengTextBoxEx();
            this.circleButton1 = new CustomControl.CircleButton();
            this.ellipseButton1 = new CustomControl.EllipseButton();
            this.textBoxEx1 = new CustomControl.TextBoxEx();
            this.ucShadowTextBox1 = new CustomControl.UcShadowTextBox();
            this.ucImageTextBox1 = new CustomControl.UcImageTextBox();
            this.SuspendLayout();
            // 
            // textBoxCu1
            // 
            this.textBoxCu1.Location = new System.Drawing.Point(46, 136);
            this.textBoxCu1.Name = "textBoxCu1";
            this.textBoxCu1.ReadOnly = false;
            this.textBoxCu1.Size = new System.Drawing.Size(224, 23);
            this.textBoxCu1.TabIndex = 8;
            this.textBoxCu1.Text = "textBoxCu1";
            // 
            // myTextbox1
            // 
            this.myTextbox1.BorderColorForMouseHover = System.Drawing.SystemColors.ButtonHighlight;
            this.myTextbox1.BorderWidth = 2;
            this.myTextbox1.Location = new System.Drawing.Point(46, 186);
            this.myTextbox1.Multiline = true;
            this.myTextbox1.Name = "myTextbox1";
            this.myTextbox1.Radius = 5;
            this.myTextbox1.Size = new System.Drawing.Size(224, 26);
            this.myTextbox1.TabIndex = 7;
            // 
            // fengTextBoxEx1
            // 
            this.fengTextBoxEx1.BorderColor = System.Drawing.Color.Black;
            this.fengTextBoxEx1.BorderRadius = 0;
            this.fengTextBoxEx1.BorderThickness = 1;
            this.fengTextBoxEx1.Location = new System.Drawing.Point(522, 155);
            this.fengTextBoxEx1.Name = "fengTextBoxEx1";
            this.fengTextBoxEx1.Size = new System.Drawing.Size(224, 18);
            this.fengTextBoxEx1.TabIndex = 6;
            this.fengTextBoxEx1.Text = "fengTextBoxEx1";
            // 
            // circleButton1
            // 
            this.circleButton1.Location = new System.Drawing.Point(695, 18);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(75, 78);
            this.circleButton1.TabIndex = 5;
            this.circleButton1.Text = "circleButton1";
            this.circleButton1.UseVisualStyleBackColor = true;
            // 
            // ellipseButton1
            // 
            this.ellipseButton1.Location = new System.Drawing.Point(589, 18);
            this.ellipseButton1.Name = "ellipseButton1";
            this.ellipseButton1.Size = new System.Drawing.Size(75, 78);
            this.ellipseButton1.TabIndex = 4;
            this.ellipseButton1.Text = "ellipseButton1";
            this.ellipseButton1.UseVisualStyleBackColor = true;
            this.ellipseButton1.Click += new System.EventHandler(this.ellipseButton1_Click);
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEx1.Location = new System.Drawing.Point(12, 49);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Size = new System.Drawing.Size(321, 21);
            this.textBoxEx1.TabIndex = 2;
            // 
            // ucShadowTextBox1
            // 
            this.ucShadowTextBox1.Location = new System.Drawing.Point(229, 12);
            this.ucShadowTextBox1.Name = "ucShadowTextBox1";
            this.ucShadowTextBox1.Size = new System.Drawing.Size(149, 21);
            this.ucShadowTextBox1.TabIndex = 1;
            // 
            // ucImageTextBox1
            // 
            this.ucImageTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucImageTextBox1.Location = new System.Drawing.Point(12, 12);
            this.ucImageTextBox1.Name = "ucImageTextBox1";
            this.ucImageTextBox1.Size = new System.Drawing.Size(134, 21);
            this.ucImageTextBox1.TabIndex = 0;
            this.ucImageTextBox1.TextImage = global::DemoCustom.Properties.Resources.病历;
            this.ucImageTextBox1.Txt = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCu1);
            this.Controls.Add(this.myTextbox1);
            this.Controls.Add(this.fengTextBoxEx1);
            this.Controls.Add(this.circleButton1);
            this.Controls.Add(this.ellipseButton1);
            this.Controls.Add(this.textBoxEx1);
            this.Controls.Add(this.ucShadowTextBox1);
            this.Controls.Add(this.ucImageTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.UcImageTextBox ucImageTextBox1;
        private CustomControl.UcShadowTextBox ucShadowTextBox1;
        private CustomControl.TextBoxEx textBoxEx1;
        private CustomControl.EllipseButton ellipseButton1;
        private CustomControl.CircleButton circleButton1;
        private CustomControl.FengTextBoxEx fengTextBoxEx1;
        private CustomControl.MyTextbox myTextbox1;
        private CustomControl.TextBoxCu textBoxCu1;
    }
}

