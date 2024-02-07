using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    static class RegionController
    {
        public static List<IRegion> regionCollection = new List<IRegion>();
        public static List<IRegion> topRegionCollection = new List<IRegion>();
        public static IRegion SelectedRegion;
        public static IRegion SelectedDrawnRegion;
        public static Stack<List<IRegion>> UndoStack= new Stack<List<IRegion>>();
        public static Point OffSet;

        private static int movementFlag = -1;

        public static void AddRegion(Regions region, Point Location, int Width, int Height)
        {
            switch (region)
            {
                case Regions.Circle:
                    SelectedRegion = new CircleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "Circle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;

                case Regions.Rectangle:
                    SelectedRegion = new RectangleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "Rectangle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;

                case Regions.Triangle:
                    SelectedRegion = new TriangleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "Triangle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;

                case Regions.SemiCircle:
                    SelectedRegion = new SemiCircleRegion
                    {
                        RegionID = regionCollection.Count,
                        RegionName = "SemiCircle " + regionCollection.Count,
                        RegionWidth = 0,
                        RegionHeight = 0,
                        RegionCoOrdinates = new Point(Location.X, Location.Y)
                    };
                    break;
            }
            
            regionCollection.Add(SelectedRegion);
            PushRegions();
        }

        public static void ClearRegion()
        {
            var dup = regionCollection;
            regionCollection = new List<IRegion>();
            for(int ctr=0; ctr<dup.Count;ctr++)
            {
                regionCollection.Add(dup[ctr].ShallowCopy());
            }
            SelectedRegion = null;
        }

        public static void DrawRegion(Graphics g)
        {
            if(UndoStack.Count==0)
            {
                regionCollection = new List<IRegion>();
                return;
            }

            if(UndoStack.Count>0)
            topRegionCollection = UndoStack.Peek();

            Brush b = new SolidBrush(Color.Red);
            for (int ctr = 0; ctr < topRegionCollection.Count; ctr++)
            {
                topRegionCollection[ctr].DrawRegion(g);
            }

            if(SelectedDrawnRegion!=null)
            {
                g.DrawRectangle(new Pen(Color.Black), new Rectangle(SelectedDrawnRegion.RegionCoOrdinates, new Size(SelectedDrawnRegion.RegionWidth, SelectedDrawnRegion.RegionHeight)));
            }

        }

        public static bool CheckSelectedDrawnRegion(Point m)
        {
            for (int ctr = 0; ctr < regionCollection.Count; ctr++)
            {
                if ((m.X >= regionCollection[ctr].RegionCoOrdinates.X && m.X <= regionCollection[ctr].RegionCoOrdinates.X + regionCollection[ctr].RegionWidth) && (m.Y >= regionCollection[ctr].RegionCoOrdinates.Y && m.Y <= regionCollection[ctr].RegionCoOrdinates.Y + regionCollection[ctr].RegionHeight))
                {
                    SelectedDrawnRegion = regionCollection[ctr];
                    return true;
                }
            }
            SelectedDrawnRegion = null;
            return false;
        }

        public static int CheckCursorPoint(Point e)
        {
            IRegion IterRegion;
            for (int ctr = 0; ctr < RegionController.regionCollection.Count; ctr++)
            {
                IterRegion = regionCollection[ctr];
                if (IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth - 10 <= e.X && IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth >= e.X && IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight - 10 <= e.Y && IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight >= e.Y)   //Right Bottom
                {
                    OffSet = new Point(IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth - e.X, IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight - e.Y);
                    return movementFlag = 0;
                }
                if (IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth - 10 <= e.X && IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth >= e.X && IterRegion.RegionCoOrdinates.Y <= e.Y && IterRegion.RegionCoOrdinates.Y + 10 >= e.Y)   //Right Top
                {
                    OffSet = new Point(IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth - e.X, e.Y - IterRegion.RegionCoOrdinates.Y);
                    return movementFlag = 1;
                }
                if (IterRegion.RegionCoOrdinates.X <= e.X && IterRegion.RegionCoOrdinates.X + 10 >= e.X && IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight - 10 <= e.Y && IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight >= e.Y) //Left Bottom
                {
                    OffSet = new Point(e.X - IterRegion.RegionCoOrdinates.X, IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight - e.Y);
                    return movementFlag = 2;
                }
                if (IterRegion.RegionCoOrdinates.X <= e.X && IterRegion.RegionCoOrdinates.X + 10 >= e.X && IterRegion.RegionCoOrdinates.Y <= e.Y && IterRegion.RegionCoOrdinates.Y + 10 >= e.Y) //Left Top
                {
                    OffSet = new Point(e.X - IterRegion.RegionCoOrdinates.X, e.Y - IterRegion.RegionCoOrdinates.Y);
                    return movementFlag = 3;
                }
                if (IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth - 10 <= e.X && IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth >= e.X)  //Right
                {
                    OffSet = new Point(IterRegion.RegionCoOrdinates.X + IterRegion.RegionWidth - e.X, 0);
                    return movementFlag = 4;
                }
                if (IterRegion.RegionCoOrdinates.X - 10 <= e.X && IterRegion.RegionCoOrdinates.X + 10 >= e.X)    //Left
                {
                    OffSet = new Point(e.X - IterRegion.RegionCoOrdinates.X, 0);
                    return movementFlag = 5;
                }
                if (IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight - 10 <= e.Y && IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight >= e.Y)    //Bottom
                {
                    OffSet = new Point(0, IterRegion.RegionCoOrdinates.Y + IterRegion.RegionHeight - e.Y);
                    return movementFlag = 6;
                }
                if (IterRegion.RegionCoOrdinates.Y <= e.Y && IterRegion.RegionCoOrdinates.Y + 10 >= e.Y)    // Top
                {
                    OffSet = new Point(0, e.Y - IterRegion.RegionCoOrdinates.Y);
                    return movementFlag = 7;
                }
            }
            OffSet = new Point(0, 0);
            return movementFlag = -1;
        }

        public static void SetOffSet(Point e)
        {
            OffSet = new Point(e.X - SelectedDrawnRegion.RegionCoOrdinates.X, e.Y - SelectedDrawnRegion.RegionCoOrdinates.Y);
        }

        public static void RegionToolManager(Tool toolType, Point Location)
        {
            switch (toolType)
            {
                case Tool.None: SelectedRegion.Draw(Location); break;
                case Tool.Move: SelectedDrawnRegion.MoveRegion(Location, OffSet); UndoStack.Pop(); UndoStack.Push(regionCollection); break;
                case Tool.Resize: SelectedDrawnRegion.Resize(Location, OffSet, movementFlag); UndoStack.Pop(); UndoStack.Push(regionCollection); break;
                case Tool.RotateCW: SelectedDrawnRegion.RotateCW(); UndoStack.Push(regionCollection); break;
                case Tool.RotateAW: SelectedDrawnRegion.RotateAW(); UndoStack.Push(regionCollection); break;
                case Tool.FlipH: SelectedDrawnRegion.FlipH(); UndoStack.Push(regionCollection); break;
                case Tool.FlipV: SelectedDrawnRegion.FlipV(); UndoStack.Push(regionCollection); break;
                case Tool.Erase: regionCollection.Remove(SelectedDrawnRegion); UndoStack.Push(regionCollection); break;
            }
        }

        public static void UpdateRatio(int Width, int Height)
        {
            foreach(var Iter in regionCollection)
            {
                if (Iter.RegionHeight == 0 || Iter.RegionWidth == 0 || Iter.RegionCoOrdinates.X == 0 || Iter.RegionCoOrdinates.Y == 0)
                    continue;

                Iter.WidthRatio = Iter.RegionWidth / (double)Width;
                Iter.HeightRatio = Iter.RegionHeight / (double)Height;
                Iter.XRatio = Iter.RegionCoOrdinates.X / (double)Width;
                Iter.YRatio = Iter.RegionCoOrdinates.Y / (double)Height;
            }
        }

        public static void ResizeRegions(int Width, int Height)
        {
            foreach (var Iter in regionCollection)
            {
                if (Iter.XRatio == 0 || Iter.YRatio == 0 || Iter.WidthRatio == 0 || Iter.HeightRatio == 0) continue;
                Iter.RegionCoOrdinates = new Point((int)(Width * Iter.XRatio), (int)(Height * Iter.YRatio));
                Iter.RegionWidth = (int)(Width * Iter.WidthRatio);
                Iter.RegionHeight = (int)(Height * Iter.HeightRatio);

                if(Iter is TriangleRegion)
                {
                    TriangleRegion Tri = Iter as TriangleRegion;
                    Tri.UpdateTriPoint();
                }
            }
        }

        public static void UndoCollection()
        {
            if (UndoStack.Count > 0)
            {
                UndoStack.Pop();
                regionCollection = new List<IRegion>();
                if (UndoStack.Count > 0)
                {
                    for (int ctr = 0; ctr < UndoStack.Peek().Count; ctr++)
                    {
                        regionCollection.Add(UndoStack.Peek()[ctr].ShallowCopy());
                    }
                }
            }

        }

        public static void PushRegions()
        {
            UndoStack.Push(regionCollection);
        }

    }
}
