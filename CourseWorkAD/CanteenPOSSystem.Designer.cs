using CourseWorkAD.CustomUserControl;

namespace CourseWorkAD
{
    partial class CanteenPOSSystem
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanteenPOSSystem));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.BunifuElipseMain = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.lblClock = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblOrgName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuItem = new CourseWorkAD.CustomUserControl.MenuItem();
            this.billGenerator = new CourseWorkAD.CustomUserControl.BillGenerator();
            this.chartGenerator = new CourseWorkAD.CustomUserControl.ChartGenerator();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.BtnGenerateBillSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnChartSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMenuSideBar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnHamburger = new Bunifu.Framework.UI.BunifuImageButton();
            this.PbOrgLogoLarge = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnSystemClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.PbOrgIcon = new System.Windows.Forms.PictureBox();
            this.PnlSideBar.SuspendLayout();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgLogoLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSystemClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // BunifuElipseMain
            // 
            this.BunifuElipseMain.ElipseRadius = 5;
            this.BunifuElipseMain.TargetControl = this;
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PnlSideBar.Controls.Add(this.BtnGenerateBillSideBar);
            this.PnlSideBar.Controls.Add(this.BtnChartSideBar);
            this.PnlSideBar.Controls.Add(this.BtnMenuSideBar);
            this.PnlSideBar.Controls.Add(this.BtnHamburger);
            this.PnlSideBar.Controls.Add(this.PbOrgLogoLarge);
            this.PanelAnimator.SetDecoration(this.PnlSideBar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PnlSideBar, BunifuAnimatorNS.DecorationType.None);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 51);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(380, 849);
            this.PnlSideBar.TabIndex = 0;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.PnlHeader.Controls.Add(this.btnMinimize);
            this.PnlHeader.Controls.Add(this.lblClock);
            this.PnlHeader.Controls.Add(this.BtnSystemClose);
            this.PnlHeader.Controls.Add(this.PbOrgIcon);
            this.PnlHeader.Controls.Add(this.LblOrgName);
            this.PnlHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.PnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PnlHeader, BunifuAnimatorNS.DecorationType.None);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1800, 51);
            this.PnlHeader.TabIndex = 1;
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.lblClock, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.lblClock, BunifuAnimatorNS.DecorationType.None);
            this.lblClock.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblClock.ForeColor = System.Drawing.Color.Silver;
            this.lblClock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClock.Location = new System.Drawing.Point(797, 14);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(0, 23);
            this.lblClock.TabIndex = 4;
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblOrgName
            // 
            this.LblOrgName.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.LblOrgName, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.LblOrgName, BunifuAnimatorNS.DecorationType.None);
            this.LblOrgName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblOrgName.ForeColor = System.Drawing.Color.Silver;
            this.LblOrgName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblOrgName.Location = new System.Drawing.Point(75, 12);
            this.LblOrgName.Name = "LblOrgName";
            this.LblOrgName.Size = new System.Drawing.Size(206, 23);
            this.LblOrgName.TabIndex = 0;
            this.LblOrgName.Text = "Canteen of Islington";
            // 
            // BunifuDragControl
            // 
            this.BunifuDragControl.Fixed = true;
            this.BunifuDragControl.Horizontal = true;
            this.BunifuDragControl.TargetControl = this.PnlHeader;
            this.BunifuDragControl.Vertical = true;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            this.LogoAnimator.Interval = 5;
            // 
            // menuItem
            // 
            this.LogoAnimator.SetDecoration(this.menuItem, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.menuItem, BunifuAnimatorNS.DecorationType.None);
            this.menuItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuItem.Location = new System.Drawing.Point(380, 51);
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(1420, 849);
            this.menuItem.TabIndex = 4;
            // 
            // billGenerator
            // 
            this.LogoAnimator.SetDecoration(this.billGenerator, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.billGenerator, BunifuAnimatorNS.DecorationType.None);
            this.billGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billGenerator.Location = new System.Drawing.Point(380, 51);
            this.billGenerator.Name = "billGenerator";
            this.billGenerator.Size = new System.Drawing.Size(1420, 849);
            this.billGenerator.TabIndex = 3;
            // 
            // chartGenerator
            // 
            this.LogoAnimator.SetDecoration(this.chartGenerator, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.chartGenerator, BunifuAnimatorNS.DecorationType.None);
            this.chartGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGenerator.Location = new System.Drawing.Point(380, 51);
            this.chartGenerator.Name = "chartGenerator";
            this.chartGenerator.Size = new System.Drawing.Size(1420, 849);
            this.chartGenerator.TabIndex = 2;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            this.PanelAnimator.MaxAnimationTime = 1000;
            // 
            // BtnGenerateBillSideBar
            // 
            this.BtnGenerateBillSideBar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.BtnGenerateBillSideBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGenerateBillSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGenerateBillSideBar.BorderRadius = 0;
            this.BtnGenerateBillSideBar.ButtonText = "Generate Bill";
            this.BtnGenerateBillSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnGenerateBillSideBar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BtnGenerateBillSideBar, BunifuAnimatorNS.DecorationType.None);
            this.BtnGenerateBillSideBar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGenerateBillSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGenerateBillSideBar.Iconimage = global::CourseWorkAD.Properties.Resources.generate_bill;
            this.BtnGenerateBillSideBar.Iconimage_right = null;
            this.BtnGenerateBillSideBar.Iconimage_right_Selected = null;
            this.BtnGenerateBillSideBar.Iconimage_Selected = null;
            this.BtnGenerateBillSideBar.IconMarginLeft = 15;
            this.BtnGenerateBillSideBar.IconMarginRight = 0;
            this.BtnGenerateBillSideBar.IconRightVisible = true;
            this.BtnGenerateBillSideBar.IconRightZoom = 0D;
            this.BtnGenerateBillSideBar.IconVisible = true;
            this.BtnGenerateBillSideBar.IconZoom = 50D;
            this.BtnGenerateBillSideBar.IsTab = true;
            this.BtnGenerateBillSideBar.Location = new System.Drawing.Point(0, 108);
            this.BtnGenerateBillSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnGenerateBillSideBar.Name = "BtnGenerateBillSideBar";
            this.BtnGenerateBillSideBar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnGenerateBillSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.BtnGenerateBillSideBar.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtnGenerateBillSideBar.selected = true;
            this.BtnGenerateBillSideBar.Size = new System.Drawing.Size(380, 55);
            this.BtnGenerateBillSideBar.TabIndex = 5;
            this.BtnGenerateBillSideBar.Text = "Generate Bill";
            this.BtnGenerateBillSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGenerateBillSideBar.Textcolor = System.Drawing.Color.Silver;
            this.BtnGenerateBillSideBar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateBillSideBar.Click += new System.EventHandler(this.BtnGenerateBillSideBar_Click);
            // 
            // BtnChartSideBar
            // 
            this.BtnChartSideBar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.BtnChartSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnChartSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnChartSideBar.BorderRadius = 0;
            this.BtnChartSideBar.ButtonText = "Chart";
            this.BtnChartSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnChartSideBar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BtnChartSideBar, BunifuAnimatorNS.DecorationType.None);
            this.BtnChartSideBar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnChartSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnChartSideBar.Iconimage = global::CourseWorkAD.Properties.Resources.pie_chart;
            this.BtnChartSideBar.Iconimage_right = null;
            this.BtnChartSideBar.Iconimage_right_Selected = null;
            this.BtnChartSideBar.Iconimage_Selected = null;
            this.BtnChartSideBar.IconMarginLeft = 15;
            this.BtnChartSideBar.IconMarginRight = 0;
            this.BtnChartSideBar.IconRightVisible = true;
            this.BtnChartSideBar.IconRightZoom = 0D;
            this.BtnChartSideBar.IconVisible = true;
            this.BtnChartSideBar.IconZoom = 45D;
            this.BtnChartSideBar.IsTab = true;
            this.BtnChartSideBar.Location = new System.Drawing.Point(0, 218);
            this.BtnChartSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnChartSideBar.Name = "BtnChartSideBar";
            this.BtnChartSideBar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnChartSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.BtnChartSideBar.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtnChartSideBar.selected = false;
            this.BtnChartSideBar.Size = new System.Drawing.Size(380, 55);
            this.BtnChartSideBar.TabIndex = 4;
            this.BtnChartSideBar.Text = "Chart";
            this.BtnChartSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnChartSideBar.Textcolor = System.Drawing.Color.Silver;
            this.BtnChartSideBar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChartSideBar.Click += new System.EventHandler(this.BtnChartSideBar_Click);
            // 
            // BtnMenuSideBar
            // 
            this.BtnMenuSideBar.Activecolor = System.Drawing.Color.RoyalBlue;
            this.BtnMenuSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnMenuSideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenuSideBar.BorderRadius = 0;
            this.BtnMenuSideBar.ButtonText = "Menu";
            this.BtnMenuSideBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnMenuSideBar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BtnMenuSideBar, BunifuAnimatorNS.DecorationType.None);
            this.BtnMenuSideBar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnMenuSideBar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnMenuSideBar.Iconimage = global::CourseWorkAD.Properties.Resources.menu;
            this.BtnMenuSideBar.Iconimage_right = null;
            this.BtnMenuSideBar.Iconimage_right_Selected = null;
            this.BtnMenuSideBar.Iconimage_Selected = null;
            this.BtnMenuSideBar.IconMarginLeft = 15;
            this.BtnMenuSideBar.IconMarginRight = 0;
            this.BtnMenuSideBar.IconRightVisible = true;
            this.BtnMenuSideBar.IconRightZoom = 0D;
            this.BtnMenuSideBar.IconVisible = true;
            this.BtnMenuSideBar.IconZoom = 45D;
            this.BtnMenuSideBar.IsTab = true;
            this.BtnMenuSideBar.Location = new System.Drawing.Point(0, 163);
            this.BtnMenuSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenuSideBar.Name = "BtnMenuSideBar";
            this.BtnMenuSideBar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnMenuSideBar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.BtnMenuSideBar.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtnMenuSideBar.selected = false;
            this.BtnMenuSideBar.Size = new System.Drawing.Size(380, 55);
            this.BtnMenuSideBar.TabIndex = 3;
            this.BtnMenuSideBar.Text = "Menu";
            this.BtnMenuSideBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnMenuSideBar.Textcolor = System.Drawing.Color.Silver;
            this.BtnMenuSideBar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenuSideBar.Click += new System.EventHandler(this.BtnMenuSideBar_Click);
            // 
            // BtnHamburger
            // 
            this.BtnHamburger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHamburger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnHamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnHamburger, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BtnHamburger, BunifuAnimatorNS.DecorationType.None);
            this.BtnHamburger.Image = global::CourseWorkAD.Properties.Resources.hamburger1;
            this.BtnHamburger.ImageActive = null;
            this.BtnHamburger.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnHamburger.Location = new System.Drawing.Point(319, 26);
            this.BtnHamburger.Margin = new System.Windows.Forms.Padding(5);
            this.BtnHamburger.Name = "BtnHamburger";
            this.BtnHamburger.Size = new System.Drawing.Size(50, 46);
            this.BtnHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHamburger.TabIndex = 1;
            this.BtnHamburger.TabStop = false;
            this.BtnHamburger.Zoom = 10;
            this.BtnHamburger.Click += new System.EventHandler(this.BtnHamburger_Click);
            // 
            // PbOrgLogoLarge
            // 
            this.PbOrgLogoLarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.LogoAnimator.SetDecoration(this.PbOrgLogoLarge, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PbOrgLogoLarge, BunifuAnimatorNS.DecorationType.None);
            this.PbOrgLogoLarge.Image = global::CourseWorkAD.Properties.Resources.canteen;
            this.PbOrgLogoLarge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PbOrgLogoLarge.Location = new System.Drawing.Point(47, 23);
            this.PbOrgLogoLarge.Name = "PbOrgLogoLarge";
            this.PbOrgLogoLarge.Size = new System.Drawing.Size(156, 49);
            this.PbOrgLogoLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbOrgLogoLarge.TabIndex = 0;
            this.PbOrgLogoLarge.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = global::CourseWorkAD.Properties.Resources.minus;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimize.Location = new System.Drawing.Point(1704, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnSystemClose
            // 
            this.BtnSystemClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSystemClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BtnSystemClose, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BtnSystemClose, BunifuAnimatorNS.DecorationType.None);
            this.BtnSystemClose.Image = global::CourseWorkAD.Properties.Resources.cancel;
            this.BtnSystemClose.ImageActive = null;
            this.BtnSystemClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSystemClose.Location = new System.Drawing.Point(1747, 10);
            this.BtnSystemClose.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSystemClose.Name = "BtnSystemClose";
            this.BtnSystemClose.Size = new System.Drawing.Size(30, 30);
            this.BtnSystemClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSystemClose.TabIndex = 3;
            this.BtnSystemClose.TabStop = false;
            this.BtnSystemClose.Zoom = 10;
            this.BtnSystemClose.Click += new System.EventHandler(this.BtnSystemClose_Click);
            // 
            // PbOrgIcon
            // 
            this.LogoAnimator.SetDecoration(this.PbOrgIcon, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PbOrgIcon, BunifuAnimatorNS.DecorationType.None);
            this.PbOrgIcon.Image = ((System.Drawing.Image)(resources.GetObject("PbOrgIcon.Image")));
            this.PbOrgIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PbOrgIcon.Location = new System.Drawing.Point(33, 3);
            this.PbOrgIcon.Name = "PbOrgIcon";
            this.PbOrgIcon.Size = new System.Drawing.Size(33, 37);
            this.PbOrgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbOrgIcon.TabIndex = 1;
            this.PbOrgIcon.TabStop = false;
            // 
            // CanteenPOSSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1800, 900);
            this.Controls.Add(this.menuItem);
            this.Controls.Add(this.billGenerator);
            this.Controls.Add(this.chartGenerator);
            this.Controls.Add(this.PnlSideBar);
            this.Controls.Add(this.PnlHeader);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CanteenPOSSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.PnlSideBar.ResumeLayout(false);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgLogoLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSystemClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOrgIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse BunifuElipseMain;
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Panel PnlHeader;
        private Bunifu.Framework.UI.BunifuImageButton BtnHamburger;
        private System.Windows.Forms.PictureBox PbOrgLogoLarge;
        private Bunifu.Framework.UI.BunifuCustomLabel LblOrgName;
        private System.Windows.Forms.PictureBox PbOrgIcon;
        private Bunifu.Framework.UI.BunifuImageButton BtnSystemClose;
        private Bunifu.Framework.UI.BunifuDragControl BunifuDragControl;
        private Bunifu.Framework.UI.BunifuFlatButton BtnMenuSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGenerateBillSideBar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnChartSideBar;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private MenuItem menuItem;
        private BillGenerator billGenerator;
        private ChartGenerator chartGenerator;
        private Bunifu.Framework.UI.BunifuCustomLabel lblClock;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
    }
}

