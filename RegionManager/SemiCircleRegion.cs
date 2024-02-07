using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionManager
{
    class SemiCircleRegion:IRegion
    {
        private int rotateCount = 0, startAngle = 180, sweepAngle = 180;
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public int NoOfEdges { get; }
        public int RegionWidth { get; set; }
        public int RegionHeight { get; set; }
        public double XRatio { get; set; }
        public double YRatio { get; set; }
        public double WidthRatio { get; set; }
        public double HeightRatio { get; set; }
        public Point RegionCoOrdinates { get; set; }

        private Color color = Color.Brown;

        public void MoveRegion(Point e, Point offSet)
        {
            RegionCoOrdinates = new Point(e.X - offSet.X, e.Y - offSet.Y);
        }

        public void Draw(Point e)
        {
            if (RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
            {
                return;
            }
            else
            {
                RegionWidth = e.X - RegionCoOrdinates.X;
                RegionHeight = e.Y - RegionCoOrdinates.Y;
            }
        }

        public void Resize(Point e, Point OffSet, int movementFlag)
        {
            if (RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
            {
                return;
            }
            else
            {
                if (movementFlag == 4 || movementFlag == 0 || movementFlag == 1)
                {
                    RegionWidth = e.X - RegionCoOrdinates.X + OffSet.X;
                }

                if (movementFlag == 5 || movementFlag == 2 || movementFlag == 3)
                {
                    RegionWidth = RegionWidth + RegionCoOrdinates.X - (e.X - OffSet.X);
                    RegionCoOrdinates = new Point(e.X - OffSet.X, RegionCoOrdinates.Y);
                }

                if (movementFlag == 6 || movementFlag == 0 || movementFlag == 2)
                {
                    RegionHeight = e.Y - RegionCoOrdinates.Y + OffSet.Y;
                }

                if (movementFlag == 7 || movementFlag == 1 || movementFlag == 3)
                {
                    RegionHeight = RegionHeight + RegionCoOrdinates.Y - (e.Y - OffSet.Y);
                    RegionCoOrdinates = new Point(RegionCoOrdinates.X, e.Y - OffSet.Y);
                }
            }
        }

        public void DrawRegion(Graphics g)
        {
            Brush b = new SolidBrush(color);
            if (RegionWidth > 0 && RegionHeight > 0)
            g.FillPie(b, new Rectangle(RegionCoOrdinates, new Size(RegionWidth, RegionHeight)), startAngle, sweepAngle);
        }

        public void RotateCW()
        {
            startAngle += 90;
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void RotateAW()
        {
            startAngle -= 90;
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void FlipH()
        {
            if(startAngle%180==90)
            {
                startAngle += 180;
            }
        }

        public void FlipV()
        {
            if(startAngle%180==0)
            {
                startAngle += 180;
            }
        }

        public IRegion ShallowCopy()
        {
            SemiCircleRegion newSemi = new SemiCircleRegion();
            newSemi.RegionID = RegionID;
            newSemi.RegionName = RegionName;
            newSemi.RegionWidth = RegionWidth;
            newSemi.RegionHeight = RegionHeight;
            newSemi.RegionCoOrdinates = RegionCoOrdinates;
            newSemi.XRatio = XRatio;
            newSemi.YRatio = YRatio;
            newSemi.WidthRatio = WidthRatio;
            newSemi.HeightRatio = HeightRatio;

            return newSemi;
        }

    }
}
