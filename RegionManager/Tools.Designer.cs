namespace RegionManager
{
    partial class Tools
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.moveTool = new System.Windows.Forms.PictureBox();
            this.resizeTool = new System.Windows.Forms.PictureBox();
            this.rotateCWTool = new System.Windows.Forms.PictureBox();
            this.rotateAWTool = new System.Windows.Forms.PictureBox();
            this.flipHTool = new System.Windows.Forms.PictureBox();
            this.flipVTool = new System.Windows.Forms.PictureBox();
            this.eraseTool = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCWTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAWTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flipHTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flipVTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraseTool)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.eraseTool, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.flipVTool, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.flipHTool, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rotateCWTool, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rotateAWTool, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.moveTool, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resizeTool, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 303);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // moveTool
            // 
            this.moveTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveTool.Image = ((System.Drawing.Image)(resources.GetObject("moveTool.Image")));
            this.moveTool.Location = new System.Drawing.Point(3, 3);
            this.moveTool.Name = "moveTool";
            this.moveTool.Size = new System.Drawing.Size(117, 37);
            this.moveTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moveTool.TabIndex = 0;
            this.moveTool.TabStop = false;
            this.moveTool.Click += new System.EventHandler(this.moveTool_Click);
            // 
            // resizeTool
            // 
            this.resizeTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resizeTool.Image = ((System.Drawing.Image)(resources.GetObject("resizeTool.Image")));
            this.resizeTool.Location = new System.Drawing.Point(3, 46);
            this.resizeTool.Name = "resizeTool";
            this.resizeTool.Size = new System.Drawing.Size(117, 37);
            this.resizeTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeTool.TabIndex = 1;
            this.resizeTool.TabStop = false;
            this.resizeTool.Click += new System.EventHandler(this.moveTool_Click);
            // 
            // rotateCWTool
            // 
            this.rotateCWTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateCWTool.Image = ((System.Drawing.Image)(resources.GetObject("rotateCWTool.Image")));
            this.rotateCWTool.Location = new System.Drawing.Point(3, 89);
            this.rotateCWTool.Name = "rotateCWTool";
            this.rotateCWTool.Size = new System.Drawing.Size(117, 37);
            this.rotateCWTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotateCWTool.TabIndex = 2;
            this.rotateCWTool.TabStop = false;
            this.rotateCWTool.Click += new System.EventHandler(this.moveTool_Click);
            // 
            // rotateAWTool
            // 
            this.rotateAWTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotateAWTool.Image = ((System.Drawing.Image)(resources.GetObject("rotateAWTool.Image")));
            this.rotateAWTool.Location = new System.Drawing.Point(3, 132);
            this.rotateAWTool.Name = "rotateAWTool";
            this.rotateAWTool.Size = new System.Drawing.Size(117, 37);
            this.rotateAWTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rotateAWTool.TabIndex = 3;
            this.rotateAWTool.TabStop = false;
            this.rotateAWTool.Click += new System.EventHandler(this.moveTool_Click);
            // 
            // flipHTool
            // 
            this.flipHTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipHTool.Image = ((System.Drawing.Image)(resources.GetObject("flipHTool.Image")));
            this.flipHTool.Location = new System.Drawing.Point(3, 175);
            this.flipHTool.Name = "flipHTool";
            this.flipHTool.Size = new System.Drawing.Size(117, 37);
            this.flipHTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flipHTool.TabIndex = 6;
            this.flipHTool.TabStop = false;
            this.flipHTool.Click += new System.EventHandler(this.moveTool_Click);
            // 
            // flipVTool
            // 
            this.flipVTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flipVTool.Image = ((System.Drawing.Image)(resources.GetObject("flipVTool.Image")));
            this.flipVTool.Location = new System.Drawing.Point(3, 218);
            this.flipVTool.Name = "flipVTool";
            this.flipVTool.Size = new System.Drawing.Size(117, 37);
            this.flipVTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flipVTool.TabIndex = 7;
            this.flipVTool.TabStop = false;
            this.flipVTool.Click += new System.EventHandler(this.moveTool_Click);
            // 
            // eraseTool
            // 
            this.eraseTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eraseTool.Image = ((System.Drawing.Image)(resources.GetObject("eraseTool.Image")));
            this.eraseTool.Location = new System.Drawing.Point(3, 261);
            this.eraseTool.Name = "eraseTool";
            this.eraseTool.Size = new System.Drawing.Size(117, 39);
            this.eraseTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eraseTool.TabIndex = 8;
            this.eraseTool.TabStop = false;
            this.eraseTool.Click += new System.EventHandler(this.moveTool_Click);
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Tools";
            this.Size = new System.Drawing.Size(123, 303);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moveTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCWTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateAWTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flipHTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flipVTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraseTool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox moveTool;
        private System.Windows.Forms.PictureBox resizeTool;
        private System.Windows.Forms.PictureBox eraseTool;
        private System.Windows.Forms.PictureBox flipVTool;
        private System.Windows.Forms.PictureBox flipHTool;
        private System.Windows.Forms.PictureBox rotateCWTool;
        private System.Windows.Forms.PictureBox rotateAWTool;
    }
}
