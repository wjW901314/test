using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControl
{
    [ToolboxItem(true)]
    public class MyTextbox:TextBox
    {
        /// <summary>
        /// 圆角值
        /// </summary>
        [Browsable(true)]
        public int Radius { get; set; } = 5;

        public int BorderWidth { get; set; } = 2;

        public Color BorderColorForMouseHover { get; set; } = SystemColors.ButtonHighlight;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region= Region = new Region(GetRegionPath());
            
        }
        /// <summary>
        /// 获取窗体有效区域路径
        /// </summary>
        /// <returns></returns>
        private GraphicsPath GetRegionPath()
        {
            var graphicsPath = new GraphicsPath();

            graphicsPath.StartFigure();
            graphicsPath.AddArc(this.ClientRectangle.Left, this.ClientRectangle.Top, Radius * 2, Radius * 2, 180, 90);
            graphicsPath.AddArc(this.ClientRectangle.Right - Radius * 2, this.ClientRectangle.Top, Radius * 2, Radius * 2, 270, 90);
            graphicsPath.AddArc(this.ClientRectangle.Right - Radius * 2, this.ClientRectangle.Bottom - Radius * 2, Radius * 2, Radius * 2, 0, 90);
            graphicsPath.AddArc(this.ClientRectangle.Left, this.ClientRectangle.Bottom - Radius * 2, Radius * 2, Radius * 2, 90, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }
        /// <summary>
        /// 获取重绘边框的路径
        /// </summary>
        /// <returns></returns>
        private GraphicsPath GetBorderPath()
        {     
            var rec = new Rectangle(ClientRectangle.X + 1, ClientRectangle.Y + 1, ClientRectangle.Width - 2, ClientRectangle.Height - 2);

            var graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rec.Left, rec.Top, Radius * 2, Radius * 2, 180, 90);
            graphicsPath.AddArc(rec.Right - Radius * 2, rec.Top, Radius * 2, Radius * 2, 270, 90);
            graphicsPath.AddArc(rec.Right - Radius * 2, rec.Bottom - Radius * 2, Radius * 2, Radius * 2, 0, 90);
            graphicsPath.AddArc(rec.Left, rec.Bottom - Radius * 2, Radius * 2, Radius * 2, 90, 90);
            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        #region win32
        /// <summary>   
        /// 获得当前进程，以便重绘控件   
        /// </summary>   
        /// <param name="hWnd"></param>   
        /// <returns></returns>   
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        /// <summary>
        /// 释放
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hDC"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            /*
             * 消息0x000F     要求一个窗口重绘自己
             * 消息0x0133     绘制编辑型控件前发送此消息给它的父窗口，可用来设置编辑框的文本和背景颜色
             */
            if (m.Msg == 0x000F || m.Msg == 0x0133)
            {
                IntPtr hDC = GetWindowDC(m.HWnd);
                if (hDC.ToInt32() == 0)
                {
                    return;
                }

                //只有在边框样式为FixedSingle时自定义边框样式才有效   
                if (this.BorderStyle == BorderStyle.FixedSingle)
                {
                    //边框Width为1个像素   
                    System.Drawing.Pen pen = new Pen(Color.Red, BorderWidth);
                    //绘制边框   
                    System.Drawing.Graphics g = Graphics.FromHdc(hDC);
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.DrawPath(pen, GetBorderPath());
                    pen.Dispose();
                }
                //返回结果   
                m.Result = IntPtr.Zero;
                //释放   
                ReleaseDC(m.HWnd, hDC);
            }
        } 

        #endregion


    }

}


