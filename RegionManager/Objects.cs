using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public enum Regions
    {
        None,
        Rectangle,
        Circle,
        Triangle,
        SemiCircle        
    }

    class Objects:UserControl
    {

        public Regions SelectedRegion
        {
            get; set;
        }

        public Objects()
        {
            DoubleBuffered = true;
            Initialize();
        }

        private int eachRow, eachColumn, eachShapeRemainingX, eachShapeRemainingY, eachShapeSize;
        private int startX, startY;
        private int selectedStartX, selectedStartY;
        private bool isSelected = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            selectedStartX = e.X / eachColumn;
            selectedStartY = e.Y / eachRow;

            SelecteRegion();

            selectedStartX *= eachColumn;
            selectedStartY *= eachRow;
            isSelected = true;

            this.Invalidate();
        }

        private void SelecteRegion()
        {
            if(selectedStartX==0 && selectedStartY==0)
            {
                SelectedRegion = Regions.Rectangle;
            }
            else if(selectedStartX==1 && selectedStartY==0)
            {
                SelectedRegion = Regions.Circle;
            }
            else if(selectedStartX==0 && selectedStartY==1)
            {
                SelectedRegion = Regions.Triangle;
            }
            else if(selectedStartX==1 && selectedStartY==1)
            {
                SelectedRegion = Regions.SemiCircle;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush recBrush = new SolidBrush(Color.Red);
            Brush cirBrush = new SolidBrush(Color.Blue);
            Brush semiBrush = new SolidBrush(Color.Brown);
            Brush triBrush = new SolidBrush(Color.Green);

            Pen selectedPen = new Pen(Color.Black);
            g.FillRectangle(recBrush, new Rectangle(startX, startY, eachShapeSize, eachShapeSize));
            g.FillEllipse(cirBrush, new Rectangle(startX + eachShapeSize + eachShapeRemainingX / 2, startY, eachShapeSize, eachShapeSize));
            g.FillPolygon(triBrush, new Point[] { new Point(startX + eachShapeSize / 2, startY + eachShapeSize + eachShapeRemainingY / 5), new Point(startX, startY + eachShapeSize*2 + eachShapeRemainingY / 5), new Point(startX + eachShapeSize, startY + eachShapeSize*2 + eachShapeRemainingY / 5) });
            g.FillPie(semiBrush, new Rectangle(startX + eachShapeSize + eachShapeRemainingX / 2, startY + eachShapeSize * 3 / 2 + eachShapeRemainingY / 5, eachShapeSize, eachShapeSize), 180, 180);

            if(isSelected)
            {
                g.DrawRectangle(selectedPen, new Rectangle(selectedStartX, selectedStartY, eachColumn, eachRow));
            }

            recBrush.Dispose(); cirBrush.Dispose(); semiBrush.Dispose(); triBrush.Dispose(); selectedPen.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            eachRow = Height / 5;
            eachColumn = Width / 2;
            eachShapeSize = Math.Min(eachRow, eachColumn);
            eachShapeRemainingX = Width - eachShapeSize * 2;
            eachShapeRemainingY = Height - eachShapeSize * 5;
            startX = eachShapeRemainingX / 4;
            startY = eachShapeRemainingY / 10;

            this.Invalidate();
        }

        protected override void OnResize(EventArgs eventargs)
        {
            eachRow = Height / 5;
            eachColumn = Width / 2;
            eachShapeSize = Math.Min(eachRow, eachColumn);
            eachShapeRemainingX = Width - eachShapeSize*2;
            eachShapeRemainingY = Height - eachShapeSize*5;
            startX = eachShapeRemainingX / 4;
            startY = eachShapeRemainingY / 10;

            this.Invalidate();
        }

        private void Initialize()
        {
            eachRow = Height / 5;
            eachColumn = Width / 2;
            eachShapeSize = Math.Min(eachRow, eachColumn);
            eachShapeRemainingX = Width - eachShapeSize * 2;
            eachShapeRemainingY = Height - eachShapeSize * 5;
            startX = eachShapeRemainingX / 4;
            startY = eachShapeRemainingY / 10;
        }
    }
}
