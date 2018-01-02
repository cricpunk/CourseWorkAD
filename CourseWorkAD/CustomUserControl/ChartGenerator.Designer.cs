namespace CourseWorkAD.CustomUserControl {

    partial class ChartGenerator {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PnlHomePageContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrgName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pcRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.clbSoldItems = new System.Windows.Forms.CheckedListBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlHomePageContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRevenue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHomePageContainer
            // 
            this.PnlHomePageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PnlHomePageContainer.Controls.Add(this.panel2);
            this.PnlHomePageContainer.Controls.Add(this.panel1);
            this.PnlHomePageContainer.Controls.Add(this.bunifuCustomLabel1);
            this.PnlHomePageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHomePageContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlHomePageContainer.Name = "PnlHomePageContainer";
            this.PnlHomePageContainer.Size = new System.Drawing.Size(1420, 1053);
            this.PnlHomePageContainer.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.lblOrgName);
            this.panel2.Controls.Add(this.pcRevenue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 988);
            this.panel2.TabIndex = 4;
            // 
            // lblOrgName
            // 
            this.lblOrgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblOrgName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgName.ForeColor = System.Drawing.Color.Silver;
            this.lblOrgName.Location = new System.Drawing.Point(22, 37);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(975, 33);
            this.lblOrgName.TabIndex = 15;
            this.lblOrgName.Text = "Cafe de Islington Revenue Chart";
            this.lblOrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcRevenue
            // 
            this.pcRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.pcRevenue.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.pcRevenue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pcRevenue.Legends.Add(legend3);
            this.pcRevenue.Location = new System.Drawing.Point(22, 100);
            this.pcRevenue.Name = "pcRevenue";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "revenue";
            this.pcRevenue.Series.Add(series3);
            this.pcRevenue.Size = new System.Drawing.Size(975, 811);
            this.pcRevenue.TabIndex = 3;
            this.pcRevenue.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.cbSelectAll);
            this.panel1.Controls.Add(this.clbSoldItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1020, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 988);
            this.panel1.TabIndex = 3;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.cbSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSelectAll.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAll.ForeColor = System.Drawing.Color.Silver;
            this.cbSelectAll.Location = new System.Drawing.Point(16, 73);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(107, 25);
            this.cbSelectAll.TabIndex = 2;
            this.cbSelectAll.Text = "Select All";
            this.cbSelectAll.UseVisualStyleBackColor = false;
            this.cbSelectAll.CheckedChanged += new System.EventHandler(this.CbSelectAll_CheckedChanged);
            // 
            // clbSoldItems
            // 
            this.clbSoldItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbSoldItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.clbSoldItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSoldItems.CheckOnClick = true;
            this.clbSoldItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbSoldItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSoldItems.ForeColor = System.Drawing.Color.Silver;
            this.clbSoldItems.FormattingEnabled = true;
            this.clbSoldItems.Location = new System.Drawing.Point(16, 101);
            this.clbSoldItems.Margin = new System.Windows.Forms.Padding(0);
            this.clbSoldItems.Name = "clbSoldItems";
            this.clbSoldItems.Size = new System.Drawing.Size(369, 810);
            this.clbSoldItems.TabIndex = 1;
            this.clbSoldItems.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbSoldItems_ItemCheck);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(1420, 65);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "D  A  T  A     A  N  A  L  Y  Z  E  R";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChartGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlHomePageContainer);
            this.Name = "ChartGenerator";
            this.Size = new System.Drawing.Size(1420, 1053);
            this.PnlHomePageContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcRevenue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHomePageContainer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart pcRevenue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbSoldItems;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOrgName;
    }
}
