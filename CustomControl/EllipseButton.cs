using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControl
{
    public class EllipseButton: Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddEllipse(2,2,this.ClientSize.Width - 6,this.ClientSize.Height - 6);
            this.Region = new Region(gPath);
            base.OnPaint(e);
        }
    }
}