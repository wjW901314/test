using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCSoft.Writer.Controls;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ddd();
        }


        private void ddd()
        {
            WriterControl writerControl = new WriterControl();
            writerControl.Dock = DockStyle.Fill;
            this.Controls.Add(writerControl);
        }
    }
}
