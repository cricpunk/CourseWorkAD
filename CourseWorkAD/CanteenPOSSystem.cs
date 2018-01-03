using CourseWorkAD.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CourseWorkAD {

    public partial class CanteenPOSSystem : Form {

        private System.Windows.Forms.Timer timer = null;  // Set timer null initially (Clock)

        public CanteenPOSSystem() {
            InitializeComponent();
            StartTime();                // Start clock
            homePage.BringToFront();           
        }

        /* METHOD : (1)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void BtnSystemClose_Click(object sender, EventArgs e) {

            Model.SerializeItem serializeItem = new Model.SerializeItem { Items = CustomUserControl.MenuItem.ItemList };
            Model.SerializeItem revenueToSerialize = new Model.SerializeItem { TotalSalesCollection = CustomUserControl.BillGenerator.TotalSalesCollection };

            SerializeThis(CustomUserControl.MenuItem.dataLocation, "ItemsData.dat", serializeItem);
            SerializeThis(CustomUserControl.BillGenerator.revenueDataLocation, "RevenuesData.dat", revenueToSerialize);

            this.Close();
        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void SerializeThis(string path, string fileName, Model.SerializeItem serializeItem) {

            if (File.Exists(path)) {
                File.Delete(path);
                new Serializer().SearilizeItems(fileName, serializeItem);
            } else {
                new Serializer().SearilizeItems(fileName, serializeItem);
            }

        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void BtnHamburger_Click(object sender, EventArgs e) {

            if(PnlSideBar.Width == 55) {
                //Expand
                PnlSideBar.Visible = false;
                PnlSideBar.Width = 285;
                PanelAnimator.ShowSync(PnlSideBar);
                LogoAnimator.ShowSync(PbOrgLogoLarge);
            } else {
                //Minimize
                LogoAnimator.Hide(PbOrgLogoLarge);
                PnlSideBar.Visible = false;
                PnlSideBar.Width = 55;
                PanelAnimator.ShowSync(PnlSideBar);
            }
        }

        /* METHOD : (4)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void BtnHomeSideBar_Click(object sender, EventArgs e) {
            homePage.BringToFront();
        }

        /* METHOD : (5)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void BtnMenuSideBar_Click(object sender, EventArgs e) {
            menuItem.BringToFront();
        }

        /* METHOD : (6)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void BtnChartSideBar_Click(object sender, EventArgs e) {
            chartGenerator.BringToFront();
        }

        /* METHOD : (7)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void BtnGenerateBillSideBar_Click(object sender, EventArgs e) {
            billGenerator.BringToFront();
        }

        /* METHOD : (8)
       * ********************************************************************************************************
       * Set timer changed interval for 1 sec i.e. 1000ms
       * Call timer ticking event handaler and start timer.
       * ********************************************************************************************************
       */
        private void StartTime() {
            this.timer = new Timer {
                Interval = 1000
            };
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.timer.Enabled = true;
        }

        /* METHOD : (9)
        * ********************************************************************************************************
        * Set current date into label.
        * ********************************************************************************************************
        */
        void Timer_Tick(Object sender, EventArgs e) {
            lblClock.Text = DateTime.Now.ToString("ddd, dd MMMM - hh : mm : ss tt");
        }

    }
}
