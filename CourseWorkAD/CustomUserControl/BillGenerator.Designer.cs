namespace CourseWorkAD.CustomUserControl {

    partial class BillGenerator {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillGenerator));
            this.PnlHomePageContainer = new System.Windows.Forms.Panel();
            this.PnlBillingDetails = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBillCreateTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCustomerName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBillDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBillNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOrgTelNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOrgPanNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOrgAddress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblOrgName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblGrandTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblServiceCharge = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblServiceChargeRate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSubTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTotalAmt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridBill = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColSnBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRateBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COlAmountBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PnlBillItemSelector = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Pnl = new System.Windows.Forms.Panel();
            this.txtRefundAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtReceivedAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCustomerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPrintBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClearBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddItemInttoBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtItemQtyBill = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtItemRateBill = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dropDownItemcategoryBill = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtItemCodeBill = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblBillGeneratorHeading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PnlHomePageContainer.SuspendLayout();
            this.PnlBillingDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            this.PnlBillItemSelector.SuspendLayout();
            this.Pnl.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHomePageContainer
            // 
            this.PnlHomePageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PnlHomePageContainer.Controls.Add(this.PnlBillingDetails);
            this.PnlHomePageContainer.Controls.Add(this.PnlBillItemSelector);
            this.PnlHomePageContainer.Controls.Add(this.LblBillGeneratorHeading);
            this.PnlHomePageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHomePageContainer.Location = new System.Drawing.Point(0, 0);
            this.PnlHomePageContainer.Name = "PnlHomePageContainer";
            this.PnlHomePageContainer.Size = new System.Drawing.Size(1420, 1053);
            this.PnlHomePageContainer.TabIndex = 7;
            // 
            // PnlBillingDetails
            // 
            this.PnlBillingDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.PnlBillingDetails.Controls.Add(this.panel5);
            this.PnlBillingDetails.Controls.Add(this.panel4);
            this.PnlBillingDetails.Controls.Add(this.panel2);
            this.PnlBillingDetails.Controls.Add(this.panel1);
            this.PnlBillingDetails.Controls.Add(this.dataGridBill);
            this.PnlBillingDetails.Controls.Add(this.panel3);
            this.PnlBillingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBillingDetails.Location = new System.Drawing.Point(0, 65);
            this.PnlBillingDetails.Name = "PnlBillingDetails";
            this.PnlBillingDetails.Size = new System.Drawing.Size(803, 988);
            this.PnlBillingDetails.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(763, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(40, 530);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 530);
            this.panel4.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBillCreateTime);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Controls.Add(this.lblBillDate);
            this.panel2.Controls.Add(this.lblBillNo);
            this.panel2.Controls.Add(this.lblOrgTelNo);
            this.panel2.Controls.Add(this.lblOrgPanNo);
            this.panel2.Controls.Add(this.lblOrgAddress);
            this.panel2.Controls.Add(this.lblOrgName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 190);
            this.panel2.TabIndex = 16;
            // 
            // lblBillCreateTime
            // 
            this.lblBillCreateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillCreateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblBillCreateTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCreateTime.ForeColor = System.Drawing.Color.Silver;
            this.lblBillCreateTime.Location = new System.Drawing.Point(3, 151);
            this.lblBillCreateTime.Name = "lblBillCreateTime";
            this.lblBillCreateTime.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblBillCreateTime.Size = new System.Drawing.Size(401, 23);
            this.lblBillCreateTime.TabIndex = 21;
            this.lblBillCreateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblCustomerName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Silver;
            this.lblCustomerName.Location = new System.Drawing.Point(4, 129);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblCustomerName.Size = new System.Drawing.Size(401, 23);
            this.lblCustomerName.TabIndex = 20;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBillDate
            // 
            this.lblBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblBillDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.ForeColor = System.Drawing.Color.Silver;
            this.lblBillDate.Location = new System.Drawing.Point(405, 106);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.lblBillDate.Size = new System.Drawing.Size(401, 23);
            this.lblBillDate.TabIndex = 19;
            this.lblBillDate.Text = "Date : 16 / 08 / 2017";
            this.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBillNo
            // 
            this.lblBillNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblBillNo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.ForeColor = System.Drawing.Color.Silver;
            this.lblBillNo.Location = new System.Drawing.Point(4, 106);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblBillNo.Size = new System.Drawing.Size(401, 23);
            this.lblBillNo.TabIndex = 18;
            this.lblBillNo.Text = "Bill No : 152345";
            this.lblBillNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrgTelNo
            // 
            this.lblOrgTelNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrgTelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblOrgTelNo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgTelNo.ForeColor = System.Drawing.Color.Silver;
            this.lblOrgTelNo.Location = new System.Drawing.Point(-3, 77);
            this.lblOrgTelNo.Name = "lblOrgTelNo";
            this.lblOrgTelNo.Size = new System.Drawing.Size(803, 23);
            this.lblOrgTelNo.TabIndex = 17;
            this.lblOrgTelNo.Text = "TEL No : 9861050106";
            this.lblOrgTelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrgPanNo
            // 
            this.lblOrgPanNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrgPanNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblOrgPanNo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgPanNo.ForeColor = System.Drawing.Color.Silver;
            this.lblOrgPanNo.Location = new System.Drawing.Point(-3, 55);
            this.lblOrgPanNo.Name = "lblOrgPanNo";
            this.lblOrgPanNo.Size = new System.Drawing.Size(803, 23);
            this.lblOrgPanNo.TabIndex = 16;
            this.lblOrgPanNo.Text = "PAN No : 123456789";
            this.lblOrgPanNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrgAddress
            // 
            this.lblOrgAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrgAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblOrgAddress.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgAddress.ForeColor = System.Drawing.Color.Silver;
            this.lblOrgAddress.Location = new System.Drawing.Point(-3, 32);
            this.lblOrgAddress.Name = "lblOrgAddress";
            this.lblOrgAddress.Size = new System.Drawing.Size(803, 23);
            this.lblOrgAddress.TabIndex = 15;
            this.lblOrgAddress.Text = "Kamalpokhari , Kathmandu";
            this.lblOrgAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrgName
            // 
            this.lblOrgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblOrgName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgName.ForeColor = System.Drawing.Color.Silver;
            this.lblOrgName.Location = new System.Drawing.Point(3, 4);
            this.lblOrgName.Name = "lblOrgName";
            this.lblOrgName.Size = new System.Drawing.Size(803, 33);
            this.lblOrgName.TabIndex = 14;
            this.lblOrgName.Text = "Cafe de Islington";
            this.lblOrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuCustomLabel19);
            this.panel1.Controls.Add(this.bunifuCustomLabel18);
            this.panel1.Controls.Add(this.bunifuCustomLabel17);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lblGrandTotal);
            this.panel1.Controls.Add(this.bunifuCustomLabel16);
            this.panel1.Controls.Add(this.lblServiceCharge);
            this.panel1.Controls.Add(this.lblServiceChargeRate);
            this.panel1.Controls.Add(this.lblSubTotal);
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Controls.Add(this.lblTotalAmt);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 759);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 229);
            this.panel1.TabIndex = 15;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(47, 88);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(714, 10);
            this.bunifuSeparator2.TabIndex = 51;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel19.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(402, 170);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(233, 23);
            this.bunifuCustomLabel19.TabIndex = 50;
            this.bunifuCustomLabel19.Text = "Customer signature   :";
            this.bunifuCustomLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(402, 138);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(233, 23);
            this.bunifuCustomLabel18.TabIndex = 49;
            this.bunifuCustomLabel18.Text = "Authorize   :";
            this.bunifuCustomLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(3, 138);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(401, 23);
            this.bunifuCustomLabel17.TabIndex = 48;
            this.bunifuCustomLabel17.Text = "Thank you, visit again.";
            this.bunifuCustomLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(47, 121);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(714, 10);
            this.bunifuSeparator1.TabIndex = 47;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblGrandTotal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Silver;
            this.lblGrandTotal.Location = new System.Drawing.Point(641, 98);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(119, 23);
            this.lblGrandTotal.TabIndex = 46;
            this.lblGrandTotal.Text = "0.00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(402, 98);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(233, 23);
            this.bunifuCustomLabel16.TabIndex = 45;
            this.bunifuCustomLabel16.Text = "Grand Total   :";
            this.bunifuCustomLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblServiceCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblServiceCharge.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharge.ForeColor = System.Drawing.Color.Silver;
            this.lblServiceCharge.Location = new System.Drawing.Point(641, 67);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(119, 23);
            this.lblServiceCharge.TabIndex = 44;
            this.lblServiceCharge.Text = "0.00";
            this.lblServiceCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServiceChargeRate
            // 
            this.lblServiceChargeRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblServiceChargeRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblServiceChargeRate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceChargeRate.ForeColor = System.Drawing.Color.Silver;
            this.lblServiceChargeRate.Location = new System.Drawing.Point(402, 67);
            this.lblServiceChargeRate.Name = "lblServiceChargeRate";
            this.lblServiceChargeRate.Size = new System.Drawing.Size(233, 23);
            this.lblServiceChargeRate.TabIndex = 43;
            this.lblServiceChargeRate.Text = "Service Charge 10%   :";
            this.lblServiceChargeRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Silver;
            this.lblSubTotal.Location = new System.Drawing.Point(641, 43);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(119, 23);
            this.lblSubTotal.TabIndex = 42;
            this.lblSubTotal.Text = "0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(402, 43);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(233, 23);
            this.bunifuCustomLabel12.TabIndex = 41;
            this.bunifuCustomLabel12.Text = "Sub Total   :";
            this.bunifuCustomLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.lblTotalAmt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalAmt.Location = new System.Drawing.Point(641, 19);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(119, 23);
            this.lblTotalAmt.TabIndex = 40;
            this.lblTotalAmt.Text = "0.00";
            this.lblTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(402, 19);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(233, 23);
            this.bunifuCustomLabel9.TabIndex = 39;
            this.bunifuCustomLabel9.Text = "Total   :";
            this.bunifuCustomLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridBill
            // 
            this.dataGridBill.AllowUserToResizeColumns = false;
            this.dataGridBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.dataGridBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBill.ColumnHeadersHeight = 30;
            this.dataGridBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSnBill,
            this.ColItemBill,
            this.ColRateBill,
            this.ColQtyBill,
            this.COlAmountBill});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBill.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridBill.DoubleBuffered = true;
            this.dataGridBill.EnableHeadersVisualStyles = false;
            this.dataGridBill.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.dataGridBill.HeaderForeColor = System.Drawing.Color.Silver;
            this.dataGridBill.Location = new System.Drawing.Point(46, 235);
            this.dataGridBill.MultiSelect = false;
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridBill.RowHeadersVisible = false;
            this.dataGridBill.RowHeadersWidth = 40;
            this.dataGridBill.RowTemplate.Height = 24;
            this.dataGridBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridBill.Size = new System.Drawing.Size(720, 518);
            this.dataGridBill.TabIndex = 14;
            // 
            // ColSnBill
            // 
            this.ColSnBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ColSnBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColSnBill.FillWeight = 15F;
            this.ColSnBill.HeaderText = "SN";
            this.ColSnBill.Name = "ColSnBill";
            this.ColSnBill.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColItemBill
            // 
            this.ColItemBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ColItemBill.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColItemBill.FillWeight = 150F;
            this.ColItemBill.HeaderText = "Particulars";
            this.ColItemBill.Name = "ColItemBill";
            this.ColItemBill.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColRateBill
            // 
            this.ColRateBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ColRateBill.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColRateBill.FillWeight = 25F;
            this.ColRateBill.HeaderText = "Rate";
            this.ColRateBill.Name = "ColRateBill";
            this.ColRateBill.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColQtyBill
            // 
            this.ColQtyBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ColQtyBill.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColQtyBill.FillWeight = 25F;
            this.ColQtyBill.HeaderText = "Qty";
            this.ColQtyBill.Name = "ColQtyBill";
            this.ColQtyBill.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // COlAmountBill
            // 
            this.COlAmountBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.COlAmountBill.DefaultCellStyle = dataGridViewCellStyle7;
            this.COlAmountBill.FillWeight = 35F;
            this.COlAmountBill.HeaderText = "Amount";
            this.COlAmountBill.Name = "COlAmountBill";
            this.COlAmountBill.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 39);
            this.panel3.TabIndex = 4;
            // 
            // PnlBillItemSelector
            // 
            this.PnlBillItemSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.PnlBillItemSelector.Controls.Add(this.panel9);
            this.PnlBillItemSelector.Controls.Add(this.Pnl);
            this.PnlBillItemSelector.Controls.Add(this.panel7);
            this.PnlBillItemSelector.Controls.Add(this.flowLayoutPanel2);
            this.PnlBillItemSelector.Controls.Add(this.panel8);
            this.PnlBillItemSelector.Controls.Add(this.panel6);
            this.PnlBillItemSelector.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlBillItemSelector.Location = new System.Drawing.Point(803, 65);
            this.PnlBillItemSelector.Name = "PnlBillItemSelector";
            this.PnlBillItemSelector.Size = new System.Drawing.Size(617, 988);
            this.PnlBillItemSelector.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(20, 968);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(577, 20);
            this.panel9.TabIndex = 27;
            // 
            // Pnl
            // 
            this.Pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.Pnl.Controls.Add(this.txtRefundAmount);
            this.Pnl.Controls.Add(this.txtReceivedAmount);
            this.Pnl.Controls.Add(this.txtCustomerName);
            this.Pnl.Controls.Add(this.btnPrintBill);
            this.Pnl.Controls.Add(this.btnClearBill);
            this.Pnl.Location = new System.Drawing.Point(20, 683);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(577, 269);
            this.Pnl.TabIndex = 26;
            // 
            // txtRefundAmount
            // 
            this.txtRefundAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRefundAmount.Enabled = false;
            this.txtRefundAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtRefundAmount.HintForeColor = System.Drawing.Color.Silver;
            this.txtRefundAmount.HintText = "Return";
            this.txtRefundAmount.isPassword = false;
            this.txtRefundAmount.LineFocusedColor = System.Drawing.Color.Gray;
            this.txtRefundAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRefundAmount.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtRefundAmount.LineThickness = 1;
            this.txtRefundAmount.Location = new System.Drawing.Point(302, 88);
            this.txtRefundAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRefundAmount.Name = "txtRefundAmount";
            this.txtRefundAmount.Size = new System.Drawing.Size(250, 50);
            this.txtRefundAmount.TabIndex = 29;
            this.txtRefundAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtReceivedAmount
            // 
            this.txtReceivedAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReceivedAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtReceivedAmount.HintForeColor = System.Drawing.Color.Silver;
            this.txtReceivedAmount.HintText = "Received";
            this.txtReceivedAmount.isPassword = false;
            this.txtReceivedAmount.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtReceivedAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtReceivedAmount.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtReceivedAmount.LineThickness = 1;
            this.txtReceivedAmount.Location = new System.Drawing.Point(25, 88);
            this.txtReceivedAmount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtReceivedAmount.Name = "txtReceivedAmount";
            this.txtReceivedAmount.Size = new System.Drawing.Size(250, 50);
            this.txtReceivedAmount.TabIndex = 28;
            this.txtReceivedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReceivedAmount.OnValueChanged += new System.EventHandler(this.TxtReceivedAmount_OnValueChanged);
            this.txtReceivedAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtReceivedAmount_KeyPress);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCustomerName.HintForeColor = System.Drawing.Color.Silver;
            this.txtCustomerName.HintText = "Customer Name";
            this.txtCustomerName.isPassword = false;
            this.txtCustomerName.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtCustomerName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCustomerName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtCustomerName.LineThickness = 1;
            this.txtCustomerName.Location = new System.Drawing.Point(25, 23);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(527, 50);
            this.txtCustomerName.TabIndex = 27;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnPrintBill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintBill.BorderRadius = 7;
            this.btnPrintBill.ButtonText = "P R I N T";
            this.btnPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.Iconimage")));
            this.btnPrintBill.Iconimage_right = null;
            this.btnPrintBill.Iconimage_right_Selected = null;
            this.btnPrintBill.Iconimage_Selected = null;
            this.btnPrintBill.IconMarginLeft = 15;
            this.btnPrintBill.IconMarginRight = 0;
            this.btnPrintBill.IconRightVisible = true;
            this.btnPrintBill.IconRightZoom = 0D;
            this.btnPrintBill.IconVisible = true;
            this.btnPrintBill.IconZoom = 45D;
            this.btnPrintBill.IsTab = false;
            this.btnPrintBill.Location = new System.Drawing.Point(371, 193);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnPrintBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnPrintBill.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnPrintBill.selected = false;
            this.btnPrintBill.Size = new System.Drawing.Size(187, 51);
            this.btnPrintBill.TabIndex = 26;
            this.btnPrintBill.Text = "P R I N T";
            this.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintBill.Textcolor = System.Drawing.Color.White;
            this.btnPrintBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Click += new System.EventHandler(this.BtnPrintBill_Click);
            // 
            // btnClearBill
            // 
            this.btnClearBill.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnClearBill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearBill.BorderRadius = 7;
            this.btnClearBill.ButtonText = "C  L  E  A  R";
            this.btnClearBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnClearBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClearBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClearBill.Iconimage")));
            this.btnClearBill.Iconimage_right = null;
            this.btnClearBill.Iconimage_right_Selected = null;
            this.btnClearBill.Iconimage_Selected = null;
            this.btnClearBill.IconMarginLeft = 15;
            this.btnClearBill.IconMarginRight = 0;
            this.btnClearBill.IconRightVisible = true;
            this.btnClearBill.IconRightZoom = 0D;
            this.btnClearBill.IconVisible = true;
            this.btnClearBill.IconZoom = 45D;
            this.btnClearBill.IsTab = false;
            this.btnClearBill.Location = new System.Drawing.Point(171, 193);
            this.btnClearBill.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnClearBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnClearBill.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnClearBill.selected = false;
            this.btnClearBill.Size = new System.Drawing.Size(187, 51);
            this.btnClearBill.TabIndex = 25;
            this.btnClearBill.Text = "C  L  E  A  R";
            this.btnClearBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClearBill.Textcolor = System.Drawing.Color.White;
            this.btnClearBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBill.Click += new System.EventHandler(this.BtnClearBill_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(20, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(577, 80);
            this.panel7.TabIndex = 25;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(597, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(20, 988);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 988);
            this.panel8.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel6.Controls.Add(this.btnAddItemInttoBill);
            this.panel6.Controls.Add(this.txtItemQtyBill);
            this.panel6.Controls.Add(this.txtItemRateBill);
            this.panel6.Controls.Add(this.dropDownItemcategoryBill);
            this.panel6.Controls.Add(this.txtItemCodeBill);
            this.panel6.Location = new System.Drawing.Point(20, 393);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(577, 272);
            this.panel6.TabIndex = 20;
            // 
            // btnAddItemInttoBill
            // 
            this.btnAddItemInttoBill.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnAddItemInttoBill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddItemInttoBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddItemInttoBill.BorderRadius = 7;
            this.btnAddItemInttoBill.ButtonText = "A D D";
            this.btnAddItemInttoBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItemInttoBill.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddItemInttoBill.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddItemInttoBill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddItemInttoBill.Iconimage")));
            this.btnAddItemInttoBill.Iconimage_right = null;
            this.btnAddItemInttoBill.Iconimage_right_Selected = null;
            this.btnAddItemInttoBill.Iconimage_Selected = null;
            this.btnAddItemInttoBill.IconMarginLeft = 15;
            this.btnAddItemInttoBill.IconMarginRight = 0;
            this.btnAddItemInttoBill.IconRightVisible = true;
            this.btnAddItemInttoBill.IconRightZoom = 0D;
            this.btnAddItemInttoBill.IconVisible = true;
            this.btnAddItemInttoBill.IconZoom = 45D;
            this.btnAddItemInttoBill.IsTab = false;
            this.btnAddItemInttoBill.Location = new System.Drawing.Point(368, 194);
            this.btnAddItemInttoBill.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItemInttoBill.Name = "btnAddItemInttoBill";
            this.btnAddItemInttoBill.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnAddItemInttoBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnAddItemInttoBill.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnAddItemInttoBill.selected = false;
            this.btnAddItemInttoBill.Size = new System.Drawing.Size(187, 51);
            this.btnAddItemInttoBill.TabIndex = 24;
            this.btnAddItemInttoBill.Text = "A D D";
            this.btnAddItemInttoBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddItemInttoBill.Textcolor = System.Drawing.Color.White;
            this.btnAddItemInttoBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItemInttoBill.Click += new System.EventHandler(this.BtnAddItemInttoBill_Click);
            // 
            // txtItemQtyBill
            // 
            this.txtItemQtyBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemQtyBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemQtyBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtItemQtyBill.HintForeColor = System.Drawing.Color.Silver;
            this.txtItemQtyBill.HintText = "Qty";
            this.txtItemQtyBill.isPassword = false;
            this.txtItemQtyBill.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtItemQtyBill.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemQtyBill.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtItemQtyBill.LineThickness = 1;
            this.txtItemQtyBill.Location = new System.Drawing.Point(297, 90);
            this.txtItemQtyBill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtItemQtyBill.Name = "txtItemQtyBill";
            this.txtItemQtyBill.Size = new System.Drawing.Size(256, 50);
            this.txtItemQtyBill.TabIndex = 23;
            this.txtItemQtyBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemQtyBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItemQtyBill_KeyPress);
            // 
            // txtItemRateBill
            // 
            this.txtItemRateBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemRateBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemRateBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtItemRateBill.HintForeColor = System.Drawing.Color.Silver;
            this.txtItemRateBill.HintText = "Rate";
            this.txtItemRateBill.isPassword = false;
            this.txtItemRateBill.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtItemRateBill.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemRateBill.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtItemRateBill.LineThickness = 1;
            this.txtItemRateBill.Location = new System.Drawing.Point(20, 90);
            this.txtItemRateBill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtItemRateBill.Name = "txtItemRateBill";
            this.txtItemRateBill.Size = new System.Drawing.Size(250, 50);
            this.txtItemRateBill.TabIndex = 22;
            this.txtItemRateBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemRateBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItemRateBill_KeyPress);
            // 
            // dropDownItemcategoryBill
            // 
            this.dropDownItemcategoryBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.dropDownItemcategoryBill.BorderRadius = 0;
            this.dropDownItemcategoryBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDownItemcategoryBill.DisabledColor = System.Drawing.Color.Gray;
            this.dropDownItemcategoryBill.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownItemcategoryBill.ForeColor = System.Drawing.Color.Silver;
            this.dropDownItemcategoryBill.Items = new string[0];
            this.dropDownItemcategoryBill.Location = new System.Drawing.Point(297, 24);
            this.dropDownItemcategoryBill.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownItemcategoryBill.Name = "dropDownItemcategoryBill";
            this.dropDownItemcategoryBill.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.dropDownItemcategoryBill.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.dropDownItemcategoryBill.selectedIndex = -1;
            this.dropDownItemcategoryBill.Size = new System.Drawing.Size(256, 50);
            this.dropDownItemcategoryBill.TabIndex = 21;
            this.dropDownItemcategoryBill.onItemSelected += new System.EventHandler(this.DropDownItemcategoryBill_onItemSelected);
            // 
            // txtItemCodeBill
            // 
            this.txtItemCodeBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCodeBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCodeBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtItemCodeBill.HintForeColor = System.Drawing.Color.Silver;
            this.txtItemCodeBill.HintText = "Item Code";
            this.txtItemCodeBill.isPassword = false;
            this.txtItemCodeBill.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.txtItemCodeBill.LineIdleColor = System.Drawing.Color.Gray;
            this.txtItemCodeBill.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.txtItemCodeBill.LineThickness = 1;
            this.txtItemCodeBill.Location = new System.Drawing.Point(20, 24);
            this.txtItemCodeBill.Margin = new System.Windows.Forms.Padding(0);
            this.txtItemCodeBill.Name = "txtItemCodeBill";
            this.txtItemCodeBill.Size = new System.Drawing.Size(250, 50);
            this.txtItemCodeBill.TabIndex = 20;
            this.txtItemCodeBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblBillGeneratorHeading
            // 
            this.LblBillGeneratorHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.LblBillGeneratorHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBillGeneratorHeading.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBillGeneratorHeading.ForeColor = System.Drawing.Color.Silver;
            this.LblBillGeneratorHeading.Location = new System.Drawing.Point(0, 0);
            this.LblBillGeneratorHeading.Name = "LblBillGeneratorHeading";
            this.LblBillGeneratorHeading.Size = new System.Drawing.Size(1420, 65);
            this.LblBillGeneratorHeading.TabIndex = 1;
            this.LblBillGeneratorHeading.Text = "B  I  L  L     G  E  N  E  R  A  T  O  R";
            this.LblBillGeneratorHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlHomePageContainer);
            this.Name = "BillGenerator";
            this.Size = new System.Drawing.Size(1420, 1053);
            this.Enter += new System.EventHandler(this.BillGenerator_Enter);
            this.PnlHomePageContainer.ResumeLayout(false);
            this.PnlBillingDetails.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            this.PnlBillItemSelector.ResumeLayout(false);
            this.PnlBillItemSelector.PerformLayout();
            this.Pnl.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHomePageContainer;
        private System.Windows.Forms.Panel PnlBillingDetails;
        private System.Windows.Forms.Panel PnlBillItemSelector;
        private Bunifu.Framework.UI.BunifuCustomLabel LblBillGeneratorHeading;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridBill;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGrandTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel lblServiceCharge;
        private Bunifu.Framework.UI.BunifuCustomLabel lblServiceChargeRate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSubTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalAmt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBillCreateTime;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCustomerName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBillDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBillNo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOrgTelNo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOrgPanNo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOrgAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOrgName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddItemInttoBill;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemQtyBill;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemRateBill;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtItemCodeBill;
        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintBill;
        private Bunifu.Framework.UI.BunifuFlatButton btnClearBill;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRefundAmount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtReceivedAmount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCustomerName;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSnBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRateBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn COlAmountBill;
        private Bunifu.Framework.UI.BunifuDropdown dropDownItemcategoryBill;
    }
}
