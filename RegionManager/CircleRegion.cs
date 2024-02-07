using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    class CircleRegion:IRegion
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public int NoOfEdges { get; }
        public int RegionWidth { get; set; }
        public int RegionHeight { get; set; }
        public Point RegionCoOrdinates { get; set; }
        public double XRatio { get; set; }
        public double YRatio { get; set; }
        public double WidthRatio { get; set; }
        public double HeightRatio { get; set; }

        private Color color = Color.Blue;

        public void MoveRegion(Point e, Point offSet)
        {
            RegionCoOrdinates = new Point(e.X - offSet.X, e.Y - offSet.Y);
        }

        public void Draw(Point e)
        {
            if(RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
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
            if(RegionCoOrdinates.X > e.X || RegionCoOrdinates.Y > e.Y)
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
            g.FillEllipse(b, new Rectangle(RegionCoOrdinates, new Size(RegionWidth, RegionHeight)));
        }

        public void RotateCW()
        {
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void RotateAW()
        {
            int temp = RegionHeight;
            RegionHeight = RegionWidth;
            RegionWidth = temp;
        }

        public void FlipH()
        {
            ;
        }


        public void FlipV()
        {
            ;
        }

        public IRegion ShallowCopy()
        {
            CircleRegion newcir = new CircleRegion();
            newcir.RegionID = RegionID;
            newcir.RegionName = RegionName;
            newcir.RegionWidth = RegionWidth;
            newcir.RegionHeight = RegionHeight;
            newcir.RegionCoOrdinates = RegionCoOrdinates;
            newcir.XRatio = XRatio;
            newcir.YRatio = YRatio;
            newcir.WidthRatio = WidthRatio;
            newcir.HeightRatio = HeightRatio;

            return newcir;
        }
    }
}
