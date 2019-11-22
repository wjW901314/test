using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Rectangle r;
        private Font drawFont = new Font("Microsoft Himalaya", 12);
        private Point p;
        private SolidBrush sb;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var strInfo = "བསྒྲིགས";
            var reslut = BoBzLanuge.getCodeName(strInfo);
            textBox1.Text = reslut;
        }

        private bool DrawText(PaintEventArgs e, string drawText)
        {
            Font drawFont = new Font("Microsoft Himalaya", 20);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Point drawPoint = new Point(40, 40);
            e.Graphics.DrawString(drawText, drawFont, drawBrush, drawPoint);
            return false;
        }


        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SaveText(e);
            r = this.ClientRectangle;
            r.Location = new Point(30, 100);
            r.Location = new Point(30, 100);
            r.Location = new Point(30, 100);
            DrawText(e.KeyChar.ToString(),r);
        }

        private void SaveText(KeyPressEventArgs e)
        {
            var filePath = @"D:\123.txt";
            int keyValue = e.KeyChar;
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(keyValue.ToString() + " " + e.KeyChar);
            sw.Close();
            fs.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //g = this.CreateGraphics();
            //r = this.ClientRectangle;
            //p = new Point(10,50);
            sb = new SolidBrush(Color.GhostWhite);
            r.Size = new Size(202,32);
            g.FillRectangle(sb,r);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var drawStr = "བསྒྲིགས བསྒྲིགས བསྒྲིགས";
            r = this.ClientRectangle;
            r.Location = new Point(10, 100);
            DrawText(drawStr,r);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }


        private void DrawText(string drawStr,Rectangle rectangle)
        {
            g = this.CreateGraphics();
            sb = new SolidBrush(Color.DarkRed);
            rectangle.Size = new Size(200, 30);
            pen = new Pen(new SolidBrush(Color.BlueViolet));
            g.DrawRectangle(pen, rectangle);
            g.DrawString(drawStr, drawFont, sb, p);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var filePath = @"D:\迅雷下载\《芒种》赵方婧.mp3";
            ProcessStartInfo psi = new ProcessStartInfo();
            try
            {
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.FileName = @"C:\ProgramData\CDXT\dll\Windows Media Player\wmplayer.exe";
                psi.Arguments = filePath;
                var p = new Process()
                {
                    StartInfo = psi
                };
                p.Start();
                p.Close();
                p.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var g = this.CreateGraphics();
            var s = "床前明月光";
            for (var i = 0; i < s.Length; i++)
            {
                int size = 52;
                using (var p = new GraphicsPath())
                {
                    var b = s[i] == '明' || s[i] == '月' ? Brushes.Red : Brushes.Black;
                    p.AddString(s[i].ToString(), new FontFamily("隶书"), 1, size, new Point(i * size, 20), new StringFormat());
                    g.FillPath(b, p);
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ShowLineAndAlignment();
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var g = this.CreateGraphics();
            var s = e.KeyChar.ToString();
            
            for (var i = 0; i < s.Length; i++)
            {
                int size = 52;
                var a = new Point(i * size, 20);
                using (var p = new GraphicsPath())
                {
                    var b = s[i] == '明' || s[i] == '月' ? Brushes.Red : Brushes.Black;
                    p.AddString(s[i].ToString(), new FontFamily("隶书"), 1, size, a, new StringFormat());
                    g.FillPath(b, p);
                }
            }
        }


        private void ShowLineAndAlignment()
        {

            // Construct a new Rectangle .
            Rectangle displayRectangle =
                new Rectangle(new Point(40, 40), new Size(80, 80));

            // Construct 2 new StringFormat objects
            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            StringFormat format2 = new StringFormat(format1);

            // Set the LineAlignment and Alignment properties for
            // both StringFormat objects to different values.
            format1.LineAlignment = StringAlignment.Near;
            format1.Alignment = StringAlignment.Center;
            //format2.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Far;
            //format2.FormatFlags = StringFormatFlags.DisplayFormatControl;

            // Draw the bounding rectangle and a string for each
            // StringFormat object.
            this.CreateGraphics().DrawRectangle(Pens.Black, displayRectangle);
            this.CreateGraphics().DrawString("Showing Format1", this.Font,
                Brushes.Red, (RectangleF)displayRectangle, format1);
            this.CreateGraphics().DrawString("Showing Format2", this.Font,
                Brushes.Red, (RectangleF)displayRectangle, format2);
        }


        private void Button8_Click_1(object sender, EventArgs e)
        {
            ArrayList CharList = new ArrayList();
            CharList.Add("A");
            CharList.Add("B");
            CharList.Add("C");
            CharList.Add("D");

            int Pointer = CharList.IndexOf("A");
            MessageBox.Show(Pointer.ToString());
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
              PaseForm pase = new PaseForm();
              pase.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {

                String myString = "This is a String from the ClipBoard";

                // Sets the data into the Clipboard.
                Clipboard.SetDataObject(myString);
                IDataObject myDataObject = Clipboard.GetDataObject();
                //检查数据的格式是否为“unicodetext”。
                if (myDataObject.GetDataPresent(DataFormats.UnicodeText))
                {
                    MessageBox.Show("Data in 'UnicodeText' format:" + myDataObject.GetData(DataFormats.UnicodeText));
                }
                else
                {
                    MessageBox.Show("No String information was contained in the clipboard.");
                }

                // 检查数据格式是“文本还是不文本”。
                if (myDataObject.GetDataPresent(DataFormats.Text))
                {
                    String clipString = (String)myDataObject.GetData(DataFormats.StringFormat);
                    MessageBox.Show("Data in 'Text' format:" + clipString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
