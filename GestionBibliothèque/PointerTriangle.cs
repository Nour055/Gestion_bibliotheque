using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBibliothèque
{
    public partial class PointerTriangle : UserControl
    {
        public Color FillColor { get; set; } = Color.LightSteelBlue;
        public PointerTriangle()
        {
            this.Size = new Size(30, 20); // width, height
            this.BackColor = Color.Transparent;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Point[] trianglePoints = new Point[]
                 {
            new Point(0, this.Height),         // Bottom left
            new Point(this.Width / 2, 0),      // Top middle
            new Point(this.Width, this.Height) // Bottom right
        };
            using (SolidBrush brush = new SolidBrush(FillColor))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPolygon(brush, trianglePoints);
            }
        }
        private void PointerTriangle_Load(object sender, EventArgs e)
        {

        }
    }
}
