using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, drawAreaPanel, new object[] { true });
            objects1.Visible = tools1.Visible = false;
        }

        private bool isCreatingRegion = false, isSelectedRegionDragging = false, isResizing = false;
        //private IRegion SelectedDrawnRegion;


        private void drawAreaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var m = e as MouseEventArgs;

            isSelectedRegionDragging = RegionController.CheckSelectedDrawnRegion(m.Location);

            drawAreaPanel.Invalidate();

            if (tools1.ToolType != Tool.None && isSelectedRegionDragging)
            {
                if(tools1.ToolType == Tool.Resize && RegionController.CheckCursorPoint(e.Location)!=-1)
                {
                    isResizing = true;
                    }
                else
                {
                    isResizing = false;
                }

                if (tools1.ToolType == Tool.Move)
                {
                    RegionController.SetOffSet(e.Location);
                }
                else
                {
                    isSelectedRegionDragging = false;
                }

                RegionController.RegionToolManager(tools1.ToolType, e.Location);
            }

            if(objects1.SelectedRegion != Regions.None)
            {
                isCreatingRegion = true;
                RegionController.AddRegion(objects1.SelectedRegion, e.Location, drawAreaPanel.Width, drawAreaPanel.Height);
                RegionController.UpdateRatio(drawAreaPanel.Width, drawAreaPanel.Height);
                tools1.ToolType = Tool.None;
            }
        }

        private void drawAreaPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(isSelectedRegionDragging)
            {
                RegionController.PushRegions();
            }

            if(isResizing)
            {
                RegionController.PushRegions();
            }

            isCreatingRegion = false;
            isSelectedRegionDragging = false;
            isResizing = false;

            RegionController.UpdateRatio(drawAreaPanel.Width, drawAreaPanel.Height);
            if (objects1.SelectedRegion != Regions.None)
            {
                RegionController.ClearRegion();
                objects1.SelectedRegion = Regions.None;
            }
        }

        private void drawAreaPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(tools1.ToolType == Tool.Resize && !isResizing)
                ChangeCursorPoint(e.Location);

            if(isSelectedRegionDragging)
            {
                if (tools1.ToolType == Tool.Move)
                {
                    RegionController.RegionToolManager(tools1.ToolType, e.Location);
                }
            }

            if(isResizing)
            {
                if (tools1.ToolType == Tool.Resize)
                {
                    RegionController.RegionToolManager(tools1.ToolType, e.Location);
                }
            }

            if (isCreatingRegion && objects1.SelectedRegion != Regions.None)
            {
                RegionController.RegionToolManager(tools1.ToolType, e.Location);
            }
            drawAreaPanel.Invalidate();
        }

        private void ChangeCursorPoint(Point location)
        {
            var x = RegionController.CheckCursorPoint(location);

            if(x==0 || x==3)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else if (x==1 || x==2)
            {
                this.Cursor = Cursors.SizeNESW;
            }
            else if(x==4 || x==5)
            {
                this.Cursor = Cursors.SizeWE;
            }
            else if(x==6 || x==7)
            {
                this.Cursor = Cursors.SizeNS;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void drawAreaPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            RegionController.DrawRegion(g);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.Gainsboro;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BackColor = Color.AliceBlue;
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            SaveFileDialog filepath = new SaveFileDialog();
            filepath.Filter = "PNG(*.png)|*.png";
            if(filepath.ShowDialog()==DialogResult.OK)
            {
                Bitmap bm = new Bitmap(drawAreaPanel.Width, drawAreaPanel.Height);
                drawAreaPanel.DrawToBitmap(bm, new Rectangle(0, drawAreaPanel.Location.Y, drawAreaPanel.Width, drawAreaPanel.Height));
                bm.Save(filepath.FileName);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RegionController.ResizeRegions(drawAreaPanel.Width, drawAreaPanel.Height);
            drawAreaPanel.Invalidate();
        }

        private void undoLbl_Click(object sender, EventArgs e)
        {
            RegionController.UndoCollection();
            drawAreaPanel.Invalidate();
        }

        private void drawAreaPanel_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            objects1.Visible = !objects1.Visible;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tools1.Visible = !tools1.Visible;
        }
    }
}
