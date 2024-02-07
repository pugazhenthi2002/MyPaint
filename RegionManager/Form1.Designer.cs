namespace RegionManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolsLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.objectLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveLbl = new System.Windows.Forms.Label();
            this.drawAreaPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.undoLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.redoLbl = new System.Windows.Forms.Label();
            this.objects1 = new RegionManager.Objects();
            this.tools1 = new RegionManager.Tools();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.toolsLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(148, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 33);
            this.panel4.TabIndex = 3;
            // 
            // toolsLbl
            // 
            this.toolsLbl.BackColor = System.Drawing.Color.Gainsboro;
            this.toolsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsLbl.Location = new System.Drawing.Point(0, 0);
            this.toolsLbl.Name = "toolsLbl";
            this.toolsLbl.Size = new System.Drawing.Size(74, 33);
            this.toolsLbl.TabIndex = 0;
            this.toolsLbl.Text = "Tools";
            this.toolsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolsLbl.Click += new System.EventHandler(this.label3_Click);
            this.toolsLbl.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.toolsLbl.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.objectLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(74, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(74, 33);
            this.panel3.TabIndex = 2;
            // 
            // objectLbl
            // 
            this.objectLbl.BackColor = System.Drawing.Color.Gainsboro;
            this.objectLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectLbl.Location = new System.Drawing.Point(0, 0);
            this.objectLbl.Name = "objectLbl";
            this.objectLbl.Size = new System.Drawing.Size(74, 33);
            this.objectLbl.TabIndex = 0;
            this.objectLbl.Text = "Object";
            this.objectLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.objectLbl.Click += new System.EventHandler(this.label2_Click);
            this.objectLbl.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.objectLbl.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.saveLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 33);
            this.panel2.TabIndex = 1;
            // 
            // saveLbl
            // 
            this.saveLbl.BackColor = System.Drawing.Color.Gainsboro;
            this.saveLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveLbl.Location = new System.Drawing.Point(0, 0);
            this.saveLbl.Name = "saveLbl";
            this.saveLbl.Size = new System.Drawing.Size(74, 33);
            this.saveLbl.TabIndex = 0;
            this.saveLbl.Text = "Save";
            this.saveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveLbl.Click += new System.EventHandler(this.label1_Click);
            this.saveLbl.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.saveLbl.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // drawAreaPanel
            // 
            this.drawAreaPanel.BackColor = System.Drawing.Color.White;
            this.drawAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawAreaPanel.Location = new System.Drawing.Point(0, 33);
            this.drawAreaPanel.Name = "drawAreaPanel";
            this.drawAreaPanel.Size = new System.Drawing.Size(835, 478);
            this.drawAreaPanel.TabIndex = 2;
            this.drawAreaPanel.Click += new System.EventHandler(this.drawAreaPanel_Click);
            this.drawAreaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawAreaPanel_Paint);
            this.drawAreaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawAreaPanel_MouseDown);
            this.drawAreaPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawAreaPanel_MouseMove);
            this.drawAreaPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawAreaPanel_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.undoLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(222, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(74, 33);
            this.panel5.TabIndex = 4;
            // 
            // undoLbl
            // 
            this.undoLbl.BackColor = System.Drawing.Color.Gainsboro;
            this.undoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.undoLbl.Location = new System.Drawing.Point(0, 0);
            this.undoLbl.Name = "undoLbl";
            this.undoLbl.Size = new System.Drawing.Size(74, 33);
            this.undoLbl.TabIndex = 0;
            this.undoLbl.Text = "Undo";
            this.undoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.undoLbl.Click += new System.EventHandler(this.undoLbl_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.redoLbl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(296, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(74, 33);
            this.panel6.TabIndex = 5;
            // 
            // redoLbl
            // 
            this.redoLbl.BackColor = System.Drawing.Color.Gainsboro;
            this.redoLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redoLbl.Location = new System.Drawing.Point(0, 0);
            this.redoLbl.Name = "redoLbl";
            this.redoLbl.Size = new System.Drawing.Size(74, 33);
            this.redoLbl.TabIndex = 0;
            this.redoLbl.Text = "Redo";
            this.redoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // objects1
            // 
            this.objects1.BackColor = System.Drawing.SystemColors.Info;
            this.objects1.Dock = System.Windows.Forms.DockStyle.Right;
            this.objects1.Location = new System.Drawing.Point(835, 33);
            this.objects1.Name = "objects1";
            this.objects1.SelectedRegion = RegionManager.Regions.None;
            this.objects1.Size = new System.Drawing.Size(123, 478);
            this.objects1.TabIndex = 3;
            // 
            // tools1
            // 
            this.tools1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tools1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tools1.Location = new System.Drawing.Point(958, 33);
            this.tools1.Name = "tools1";
            this.tools1.Size = new System.Drawing.Size(90, 478);
            this.tools1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 511);
            this.Controls.Add(this.drawAreaPanel);
            this.Controls.Add(this.objects1);
            this.Controls.Add(this.tools1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label toolsLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label objectLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label saveLbl;
        private System.Windows.Forms.Panel drawAreaPanel;
        private Objects objects1;
        private Tools tools1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label redoLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label undoLbl;
    }
}

