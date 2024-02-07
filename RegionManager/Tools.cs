using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public enum Tool
    {
        None,
        Move,
        Resize,
        RotateCW,
        RotateAW,
        FlipH,
        FlipV,
        Erase
    }

    public partial class Tools : UserControl
    {
        public Tools()
        {
            InitializeComponent();
        }
        private int startX, startY;
        public Tool ToolType;

        private void moveTool_Click(object sender, EventArgs e)
        {
            var m = (e as MouseEventArgs).Location;
            var obj = sender as PictureBox;
            m = obj.PointToScreen(m);
            m = tableLayoutPanel1.PointToClient(m);
            startX = 0;
            startY = m.Y / (Height / 7);
            ToolType = (Tool)(startY + 1);
            tableLayoutPanel1.Invalidate();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if(ToolType != Tool.None)
            {
                Pen border = new Pen(Color.Blue);
                e.Graphics.DrawRectangle(border, new Rectangle(startX, startY * (Height/7), Width - this.Margin.Right, Height / 7));
                border.Dispose();
            }
            
        }
    }
}
