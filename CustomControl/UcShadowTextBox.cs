using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public sealed class UcShadowTextBox : TextBox
    {
        private const int WM_PAINT = 0x000F;
        private string _txtPlaceHolder = "请在此输入";

        [Category("自定义属性"), Description("文本框里的提示文字"), DefaultValue("请在此输入"), Browsable(true)]
        public string TxtPlaceHolder
        {
            get { return _txtPlaceHolder; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");

                _txtPlaceHolder = value;
                this.Invalidate();
            }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && !this.Focused && (this.TextLength == 0) && (_txtPlaceHolder.Length > 0))
            {
                TextFormatFlags tff = (TextFormatFlags.EndEllipsis |
                                       TextFormatFlags.NoPrefix |
                                       TextFormatFlags.Left |
                                       TextFormatFlags.Top | TextFormatFlags.NoPadding);

                using (Graphics g = this.CreateGraphics())
                {

                    Rectangle rect = this.ClientRectangle;

                    rect.Offset(4, 1);

                    TextRenderer.DrawText(g, _txtPlaceHolder, this.Font, rect, SystemColors.GrayText, tff);
                }
            }
        }
    }
}
