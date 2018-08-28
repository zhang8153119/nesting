namespace myCad
{
    partial class DrawingBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingBoard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ceshipToLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentCoordinates = new System.Windows.Forms.Label();
            this.rightToMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DrawPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.BDrawLine = new System.Windows.Forms.ToolStripMenuItem();
            this.BDrawArc = new System.Windows.Forms.ToolStripMenuItem();
            this.BDrawCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.BDrawEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.BDrawEllipseArc = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyOper = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveOper = new System.Windows.Forms.ToolStripMenuItem();
            this.RotateOper = new System.Windows.Forms.ToolStripMenuItem();
            this.MirrorOper = new System.Windows.Forms.ToolStripMenuItem();
            this.OffsetOper = new System.Windows.Forms.ToolStripMenuItem();
            this.ScalingOper = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOper = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOper = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.cadJieMian = new myCad.CADInterfaceCtrl.CADInterface();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightToMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cadJieMian, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.ceshipToLine,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton4,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1070, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 32);
            this.toolStripButton1.Text = "圆";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(102, 32);
            this.toolStripButton2.Text = "DXF文件导入";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ceshipToLine
            // 
            this.ceshipToLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ceshipToLine.Image = ((System.Drawing.Image)(resources.GetObject("ceshipToLine.Image")));
            this.ceshipToLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ceshipToLine.Name = "ceshipToLine";
            this.ceshipToLine.Size = new System.Drawing.Size(88, 32);
            this.ceshipToLine.Text = "点到线距离";
            this.ceshipToLine.Visible = false;
            this.ceshipToLine.Click += new System.EventHandler(this.ceshipToLine_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(133, 32);
            this.toolStripButton3.Text = "读取排样件号文件";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(118, 32);
            this.toolStripButton5.Text = "输入原材料钢板";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(73, 32);
            this.toolStripButton6.Text = "开始排样";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(118, 32);
            this.toolStripButton7.Text = "余板的保留模式";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(88, 32);
            this.toolStripButton4.Text = "测试用信息";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.currentCoordinates);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 29);
            this.panel1.TabIndex = 1;
            // 
            // currentCoordinates
            // 
            this.currentCoordinates.AutoSize = true;
            this.currentCoordinates.Location = new System.Drawing.Point(9, 8);
            this.currentCoordinates.Name = "currentCoordinates";
            this.currentCoordinates.Size = new System.Drawing.Size(55, 15);
            this.currentCoordinates.TabIndex = 0;
            this.currentCoordinates.Text = "label1";
            // 
            // rightToMenu
            // 
            this.rightToMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawPicture,
            this.CopyOper,
            this.MoveOper,
            this.RotateOper,
            this.MirrorOper,
            this.OffsetOper,
            this.ScalingOper,
            this.ZoomOper,
            this.DeleteOper});
            this.rightToMenu.Name = "contextMenuStrip1";
            this.rightToMenu.Size = new System.Drawing.Size(128, 238);
            // 
            // DrawPicture
            // 
            this.DrawPicture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BDrawLine,
            this.BDrawArc,
            this.BDrawCircle,
            this.BDrawEllipse,
            this.BDrawEllipseArc});
            this.DrawPicture.Name = "DrawPicture";
            this.DrawPicture.Size = new System.Drawing.Size(127, 26);
            this.DrawPicture.Text = "作图";
            // 
            // BDrawLine
            // 
            this.BDrawLine.Name = "BDrawLine";
            this.BDrawLine.Size = new System.Drawing.Size(129, 26);
            this.BDrawLine.Text = "直线";
            this.BDrawLine.Click += new System.EventHandler(this.BDrawLine_Click);
            // 
            // BDrawArc
            // 
            this.BDrawArc.Name = "BDrawArc";
            this.BDrawArc.Size = new System.Drawing.Size(129, 26);
            this.BDrawArc.Text = "圆弧";
            this.BDrawArc.Click += new System.EventHandler(this.BDrawArc_Click);
            // 
            // BDrawCircle
            // 
            this.BDrawCircle.Name = "BDrawCircle";
            this.BDrawCircle.Size = new System.Drawing.Size(129, 26);
            this.BDrawCircle.Text = "圆";
            this.BDrawCircle.Click += new System.EventHandler(this.BDrawCircle_Click);
            // 
            // BDrawEllipse
            // 
            this.BDrawEllipse.Name = "BDrawEllipse";
            this.BDrawEllipse.Size = new System.Drawing.Size(129, 26);
            this.BDrawEllipse.Text = "椭圆";
            this.BDrawEllipse.Click += new System.EventHandler(this.BDrawEllipse_Click);
            // 
            // BDrawEllipseArc
            // 
            this.BDrawEllipseArc.Name = "BDrawEllipseArc";
            this.BDrawEllipseArc.Size = new System.Drawing.Size(129, 26);
            this.BDrawEllipseArc.Text = "椭圆弧";
            this.BDrawEllipseArc.Click += new System.EventHandler(this.BDrawEllipseArc_Click);
            // 
            // CopyOper
            // 
            this.CopyOper.Name = "CopyOper";
            this.CopyOper.Size = new System.Drawing.Size(127, 26);
            this.CopyOper.Text = "复制";
            this.CopyOper.Click += new System.EventHandler(this.CopyOper_Click);
            // 
            // MoveOper
            // 
            this.MoveOper.Name = "MoveOper";
            this.MoveOper.Size = new System.Drawing.Size(127, 26);
            this.MoveOper.Text = "移动";
            this.MoveOper.Click += new System.EventHandler(this.MoveOper_Click);
            // 
            // RotateOper
            // 
            this.RotateOper.Name = "RotateOper";
            this.RotateOper.Size = new System.Drawing.Size(127, 26);
            this.RotateOper.Text = "旋转";
            this.RotateOper.Click += new System.EventHandler(this.RotateOper_Click);
            // 
            // MirrorOper
            // 
            this.MirrorOper.Name = "MirrorOper";
            this.MirrorOper.Size = new System.Drawing.Size(127, 26);
            this.MirrorOper.Text = "镜像";
            this.MirrorOper.Click += new System.EventHandler(this.MirrorOper_Click);
            // 
            // OffsetOper
            // 
            this.OffsetOper.Name = "OffsetOper";
            this.OffsetOper.Size = new System.Drawing.Size(127, 26);
            this.OffsetOper.Text = "偏移";
            this.OffsetOper.Click += new System.EventHandler(this.OffsetOper_Click);
            // 
            // ScalingOper
            // 
            this.ScalingOper.Name = "ScalingOper";
            this.ScalingOper.Size = new System.Drawing.Size(127, 26);
            this.ScalingOper.Text = "缩放";
            this.ScalingOper.Click += new System.EventHandler(this.ScalingOper_Click);
            // 
            // ZoomOper
            // 
            this.ZoomOper.Name = "ZoomOper";
            this.ZoomOper.Size = new System.Drawing.Size(127, 26);
            this.ZoomOper.Text = "Zoom";
            this.ZoomOper.Click += new System.EventHandler(this.ZoomOper_Click);
            // 
            // DeleteOper
            // 
            this.DeleteOper.Name = "DeleteOper";
            this.DeleteOper.Size = new System.Drawing.Size(127, 26);
            this.DeleteOper.Text = "删除";
            this.DeleteOper.Click += new System.EventHandler(this.DeleteOper_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(103, 32);
            this.toolStripButton8.Text = "输入测试角度";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // cadJieMian
            // 
            this.cadJieMian.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.cadJieMian, 2);
            this.cadJieMian.ContextMenuStrip = this.rightToMenu;
            this.cadJieMian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadJieMian.Location = new System.Drawing.Point(3, 38);
            this.cadJieMian.Name = "cadJieMian";
            this.cadJieMian.Size = new System.Drawing.Size(1064, 523);
            this.cadJieMian.TabIndex = 2;
            this.cadJieMian.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cadJieMian_MouseDown);
            this.cadJieMian.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cadJieMian_MouseMove);
            // 
            // DrawingBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DrawingBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawingBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawingBoard_FormClosing);
            this.Load += new System.EventHandler(this.DrawingBoard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rightToMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label currentCoordinates;
        private CADInterfaceCtrl.CADInterface cadJieMian;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton ceshipToLine;
        private System.Windows.Forms.ContextMenuStrip rightToMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyOper;
        private System.Windows.Forms.ToolStripMenuItem MoveOper;
        private System.Windows.Forms.ToolStripMenuItem RotateOper;
        private System.Windows.Forms.ToolStripMenuItem MirrorOper;
        private System.Windows.Forms.ToolStripMenuItem DeleteOper;
        private System.Windows.Forms.ToolStripMenuItem OffsetOper;
        private System.Windows.Forms.ToolStripMenuItem ScalingOper;
        private System.Windows.Forms.ToolStripMenuItem ZoomOper;
        private System.Windows.Forms.ToolStripMenuItem DrawPicture;
        private System.Windows.Forms.ToolStripMenuItem BDrawLine;
        private System.Windows.Forms.ToolStripMenuItem BDrawArc;
        private System.Windows.Forms.ToolStripMenuItem BDrawCircle;
        private System.Windows.Forms.ToolStripMenuItem BDrawEllipse;
        private System.Windows.Forms.ToolStripMenuItem BDrawEllipseArc;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}