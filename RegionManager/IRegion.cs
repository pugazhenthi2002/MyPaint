using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    interface IRegion
    {
        int RegionID { get; set; }
        string RegionName { get; set; }
        int NoOfEdges { get; }
        int RegionWidth { get; set; }
        int RegionHeight { get; set; }
        double XRatio { get; set; }
        double YRatio { get; set; }
        double WidthRatio { get; set; }
        double HeightRatio { get; set; }
        Point RegionCoOrdinates { get; set; }

        void MoveRegion(Point e, Point offSet);
        void Draw(Point e);
        void Resize(Point e, Point OffSet, int movementFlag);
        void DrawRegion(Graphics g);
        void RotateCW();
        void RotateAW();
        void FlipH();
        void FlipV();
        IRegion ShallowCopy();
    }
}
