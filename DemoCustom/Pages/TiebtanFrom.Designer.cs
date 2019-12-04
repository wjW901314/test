namespace DemoCustom.Pages
{
    partial class TiebtanFrom
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
            this.ucTibetan1 = new CustomControl.UcTibetan();
            this.SuspendLayout();
            // 
            // ucTibetan1
            // 
            this.ucTibetan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTibetan1.Location = new System.Drawing.Point(0, 0);
            this.ucTibetan1.Name = "ucTibetan1";
            this.ucTibetan1.Size = new System.Drawing.Size(800, 450);
            this.ucTibetan1.TabIndex = 0;
            // 
            // TiebtanFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucTibetan1);
            this.Name = "TiebtanFrom";
            this.Text = "TiebtanFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.UcTibetan ucTibetan1;
    }
}