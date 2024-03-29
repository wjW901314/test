﻿using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public class CircleButton:Button
    {
        protected override void OnPaint(PaintEventArgs e)//重新设置控件的形状   protected 保护  override重新
        {
            base.OnPaint(e);//递归  每次重新都发生此方法,保证其形状为自定义形状
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(2, 2, this.Width - 6, this.Height - 6);
            Graphics g = e.Graphics;
            g.DrawEllipse(new Pen(Color.Black, 2), 2, 2, Width - 6, Height - 6);
            Region = new Region(path);
        }
    }
}