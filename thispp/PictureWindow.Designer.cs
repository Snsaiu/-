namespace programmingQuickSetup
{
    partial class PictureWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssmOpenfile = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirView = new System.Windows.Forms.ToolStripMenuItem();
            this.SecView = new System.Windows.Forms.ToolStripMenuItem();
            this.ThirView = new System.Windows.Forms.ToolStripMenuItem();
            this.FourView = new System.Windows.Forms.ToolStripMenuItem();
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssmCollector = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lvSolo = new System.Windows.Forms.ListView();
            this.tbSoleScal = new System.Windows.Forms.TrackBar();
            this.ttPictureWindows = new System.Windows.Forms.ToolTip(this.components);
            this.cbCollector = new System.Windows.Forms.ComboBox();
            this.ctmsCollectDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteCollectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsCollectorSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDeleteCollector = new System.Windows.Forms.ListBox();
            this.timeLBout = new System.Windows.Forms.Timer(this.components);
            this.timerLBin = new System.Windows.Forms.Timer(this.components);
            this.pictureControl01 = new programmingQuickSetup.PictureControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoleScal)).BeginInit();
            this.ctmsCollectDelete.SuspendLayout();
            this.ctmsCollectorSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.topToolStripMenuItem,
            this.tssmCollector});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(253, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.tssmOpenfile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.ToolTipText = "选择要打开的文件夹，注意不是文件！";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tssmOpenfile
            // 
            this.tssmOpenfile.Name = "tssmOpenfile";
            this.tssmOpenfile.Size = new System.Drawing.Size(126, 22);
            this.tssmOpenfile.Text = "打开文件";
            this.tssmOpenfile.ToolTipText = "此按钮打开指定的文件，注意不是文件夹";
            this.tssmOpenfile.Click += new System.EventHandler(this.tssmOpenfile_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirView,
            this.SecView,
            this.ThirView,
            this.FourView});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "显示";
            this.viewToolStripMenuItem.ToolTipText = "此按钮可以选择打开几个相框";
            // 
            // FirView
            // 
            this.FirView.Name = "FirView";
            this.FirView.Size = new System.Drawing.Size(113, 22);
            this.FirView.Text = "一视图";
            this.FirView.Click += new System.EventHandler(this.FirView_Click);
            // 
            // SecView
            // 
            this.SecView.Name = "SecView";
            this.SecView.Size = new System.Drawing.Size(113, 22);
            this.SecView.Text = "二视图";
            this.SecView.Click += new System.EventHandler(this.SecView_Click);
            // 
            // ThirView
            // 
            this.ThirView.Name = "ThirView";
            this.ThirView.Size = new System.Drawing.Size(113, 22);
            this.ThirView.Text = "三视图";
            this.ThirView.Click += new System.EventHandler(this.ThirView_Click);
            // 
            // FourView
            // 
            this.FourView.Name = "FourView";
            this.FourView.Size = new System.Drawing.Size(113, 22);
            this.FourView.Text = "四视图";
            this.FourView.Click += new System.EventHandler(this.FourView_Click);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.topToolStripMenuItem.Text = "UnTop";
            this.topToolStripMenuItem.ToolTipText = "此按钮可选定是否此窗口永远显示在所有窗体最前端";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // tssmCollector
            // 
            this.tssmCollector.Name = "tssmCollector";
            this.tssmCollector.Size = new System.Drawing.Size(97, 20);
            this.tssmCollector.Text = "添加至收藏夹";
            this.tssmCollector.ToolTipText = "此按钮会将您当前打开的文件夹路径进行收藏";
            this.tssmCollector.Click += new System.EventHandler(this.tssmCollector_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvSolo
            // 
            this.lvSolo.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSolo.AllowDrop = true;
            this.lvSolo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSolo.LargeImageList = this.imageList;
            this.lvSolo.Location = new System.Drawing.Point(12, 29);
            this.lvSolo.MultiSelect = false;
            this.lvSolo.Name = "lvSolo";
            this.lvSolo.ShowItemToolTips = true;
            this.lvSolo.Size = new System.Drawing.Size(927, 76);
            this.lvSolo.SmallImageList = this.imageList;
            this.lvSolo.StateImageList = this.imageList;
            this.lvSolo.TabIndex = 2;
            this.lvSolo.UseCompatibleStateImageBehavior = false;
            this.lvSolo.Click += new System.EventHandler(this.lvSolo_SelectedIndexChanged);
            // 
            // tbSoleScal
            // 
            this.tbSoleScal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoleScal.Location = new System.Drawing.Point(945, 28);
            this.tbSoleScal.Name = "tbSoleScal";
            this.tbSoleScal.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSoleScal.Size = new System.Drawing.Size(45, 77);
            this.tbSoleScal.TabIndex = 3;
            this.ttPictureWindows.SetToolTip(this.tbSoleScal, "滑动浏览更多的缩略图");
            this.tbSoleScal.Scroll += new System.EventHandler(this.tbSoleScal_Scroll);
            // 
            // ttPictureWindows
            // 
            this.ttPictureWindows.IsBalloon = true;
            this.ttPictureWindows.ShowAlways = true;
            this.ttPictureWindows.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttPictureWindows.ToolTipTitle = "SmartTool使用说明";
            // 
            // cbCollector
            // 
            this.cbCollector.ContextMenuStrip = this.ctmsCollectDelete;
            this.cbCollector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCollector.FormattingEnabled = true;
            this.cbCollector.Location = new System.Drawing.Point(256, 1);
            this.cbCollector.Name = "cbCollector";
            this.cbCollector.Size = new System.Drawing.Size(189, 21);
            this.cbCollector.TabIndex = 6;
            this.cbCollector.SelectedIndexChanged += new System.EventHandler(this.cbCollector_SelectedIndexChanged);
            // 
            // ctmsCollectDelete
            // 
            this.ctmsCollectDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteCollectorToolStripMenuItem});
            this.ctmsCollectDelete.Name = "ctmsCollectDelete";
            this.ctmsCollectDelete.Size = new System.Drawing.Size(140, 26);
            // 
            // DeleteCollectorToolStripMenuItem
            // 
            this.DeleteCollectorToolStripMenuItem.Name = "DeleteCollectorToolStripMenuItem";
            this.DeleteCollectorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.DeleteCollectorToolStripMenuItem.Text = "删除收藏夹";
            this.DeleteCollectorToolStripMenuItem.Click += new System.EventHandler(this.DeleteCollectorToolStripMenuItem_Click);
            // 
            // ctmsCollectorSetting
            // 
            this.ctmsCollectorSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.ctmsCollectorSetting.Name = "ctmsCollectorSetting";
            this.ctmsCollectorSetting.Size = new System.Drawing.Size(101, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DeleteToolStripMenuItem.Text = "删除";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // lbDeleteCollector
            // 
            this.lbDeleteCollector.AllowDrop = true;
            this.lbDeleteCollector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDeleteCollector.ContextMenuStrip = this.ctmsCollectorSetting;
            this.lbDeleteCollector.FormattingEnabled = true;
            this.lbDeleteCollector.Location = new System.Drawing.Point(0, 27);
            this.lbDeleteCollector.Name = "lbDeleteCollector";
            this.lbDeleteCollector.ScrollAlwaysVisible = true;
            this.lbDeleteCollector.Size = new System.Drawing.Size(0, 524);
            this.lbDeleteCollector.TabIndex = 8;
            // 
            // timeLBout
            // 
            this.timeLBout.Interval = 50;
            this.timeLBout.Tick += new System.EventHandler(this.timeLBout_Tick);
            // 
            // timerLBin
            // 
            this.timerLBin.Interval = 50;
            this.timerLBin.Tick += new System.EventHandler(this.timerLBin_Tick);
            // 
            // pictureControl01
            // 
            this.pictureControl01.AllowDrop = true;
            this.pictureControl01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureControl01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureControl01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureControl01.Location = new System.Drawing.Point(12, 119);
            this.pictureControl01.Name = "pictureControl01";
            this.pictureControl01.Size = new System.Drawing.Size(978, 413);
            this.pictureControl01.TabIndex = 5;
            // 
            // PictureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1002, 544);
            this.Controls.Add(this.lbDeleteCollector);
            this.Controls.Add(this.cbCollector);
            this.Controls.Add(this.lvSolo);
            this.Controls.Add(this.pictureControl01);
            this.Controls.Add(this.tbSoleScal);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PictureWindow";
            this.Text = "图片查看器";
            this.Load += new System.EventHandler(this.PictureWindow_Load);
            this.SizeChanged += new System.EventHandler(this.PictureWindow_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureWindow_DragDrop);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoleScal)).EndInit();
            this.ctmsCollectDelete.ResumeLayout(false);
            this.ctmsCollectorSetting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView lvSolo;
        private System.Windows.Forms.TrackBar tbSoleScal;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FirView;
        private System.Windows.Forms.ToolStripMenuItem SecView;
        private System.Windows.Forms.ToolStripMenuItem ThirView;
        private System.Windows.Forms.ToolStripMenuItem FourView;
        private PictureControl pictureControl01;
        private System.Windows.Forms.ToolStripMenuItem tssmOpenfile;
        private System.Windows.Forms.ToolStripMenuItem tssmCollector;
        private System.Windows.Forms.ToolTip ttPictureWindows;
        private System.Windows.Forms.ComboBox cbCollector;
        private System.Windows.Forms.ContextMenuStrip ctmsCollectorSetting;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ListBox lbDeleteCollector;
        private System.Windows.Forms.ContextMenuStrip ctmsCollectDelete;
        private System.Windows.Forms.ToolStripMenuItem DeleteCollectorToolStripMenuItem;
        private System.Windows.Forms.Timer timeLBout;
        private System.Windows.Forms.Timer timerLBin;
    }
}