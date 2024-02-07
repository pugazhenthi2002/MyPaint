using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    class RectangleRegion:IRegion
    {
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
                if(movementFlag==4 || movementFlag==0 || movementFlag==1)
                {
                    RegionWidth = e.X - RegionCoOrdinates.X + OffSet.X;
                }

                if(movementFlag==5 || movementFlag==2 || movementFlag==3)
                {
                    RegionWidth = RegionWidth + RegionCoOrdinates.X - (e.X - OffSet.X);
                    RegionCoOrdinates = new Point(e.X - OffSet.X,RegionCoOrdinates.Y);
                }

                if(movementFlag==6 || movementFlag==0 || movementFlag==2)
                {
                    RegionHeight = e.Y - RegionCoOrdinates.Y + OffSet.Y;
                }

                if(movementFlag==7 || movementFlag==1 || movementFlag==3)
                {
                    RegionHeight = RegionHeight + RegionCoOrdinates.Y - (e.Y - OffSet.Y);
                    RegionCoOrdinates = new Point(RegionCoOrdinates.X, e.Y - OffSet.Y);
                }

            }
        }

        public void DrawRegion(Graphics g)
        {
            Brush b = new SolidBrush(Color.Red);
            g.FillRectangle(b, new Rectangle(RegionCoOrdinates, new Size(RegionWidth, RegionHeight)));
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
            RectangleRegion newRec = new RectangleRegion();
            newRec.RegionID = RegionID;
            newRec.RegionName = RegionName;
            newRec.RegionWidth = RegionWidth;
            newRec.RegionHeight = RegionHeight;
            newRec.RegionCoOrdinates = RegionCoOrdinates;
            newRec.XRatio = XRatio;
            newRec.YRatio = YRatio;
            newRec.WidthRatio = WidthRatio;
            newRec.HeightRatio = HeightRatio;

            return newRec;
        }
    }
}
