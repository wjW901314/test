using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0xf || m.Msg == 0x14 || m.Msg == 0x85)
            {
                if (this.BorderStyle == BorderStyle.FixedSingle)
                {
                    using (Graphics g = Graphics.FromHwnd(this.Handle))
                    {
                        using (Pen p = new Pen(Color.Blue))
                        {
                            g.DrawRectangle(p,0,0,this.Width -1,this.Height -1);
                        }
                    }
                }
            }
        }
    }
}