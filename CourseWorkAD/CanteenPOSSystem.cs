using CourseWorkAD.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CourseWorkAD.Model;
using CourseWorkAD.CustomUserControl;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Close system after serializing data. (Button click listener)
 * METHOD 2 : Minimize system. (Button click listener)
 * METHOD 3 : Serializing method.
 * METHOD 4 : Resize panel. (Button click listener)
 * METHOD 5 : Bring menu control to front. (Button click listener)
 * METHOD 6 : Bring chart generator control to front. (Button click listener)
 * METHOD 7 : Bring bill generator control to front. (Button click listener)
 * METHOD 8 : Start timer of the clock.
 * METHOD 9 : Timer tick event handler.
 */

namespace CourseWorkAD {

    public partial class CanteenPOSSystem : Form {

        private System.Windows.Forms.Timer timer = null;  // Set timer null initially (Clock)

        // System build constructor
        public CanteenPOSSystem() {
            InitializeComponent();              // System build method to load all components belongs to this class
            StartTime();                        // Start clock
            billGenerator.BringToFront();       // Disply bill generator control at begining       
        }

        /* METHOD : (1)
        * ********************************************************************************************************
        * Close the window after serializing items list and revenue details.
        * ********************************************************************************************************
        */
        private void BtnSystemClose_Click(object sender, EventArgs e) {

            // Initializing itemList for serialization.
            SerializeItem serializeItem = new SerializeItem { Items = CustomUserControl.MenuItem.ItemList };
            // Initializing revenue dictionary for serialization.
            SerializeItem revenueToSerialize = new SerializeItem { TotalSalesCollection = BillGenerator.TotalSalesCollection };

            SerializeThis(CustomUserControl.MenuItem.dataLocation, "ItemsData.dat", serializeItem);
            SerializeThis(BillGenerator.revenueDataLocation, "RevenuesData.dat", revenueToSerialize);

            this.Close();
        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * Minimize current window.
        * ********************************************************************************************************
        */
        private void BtnMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * If old serialize file is there in folder location replace by new one else create one.
        * ********************************************************************************************************
        */
        private void SerializeThis(string path, string fileName, SerializeItem serializeItem) {

            if (File.Exists(path)) {
                File.Delete(path);
                new Serializer().SearilizeItems(fileName, serializeItem);
            } else {
                new Serializer().SearilizeItems(fileName, serializeItem);
            }

        }

        /* METHOD : (4)
        * ********************************************************************************************************
        * Resize panel sidebar 
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

        /* METHOD : (5)
        * ********************************************************************************************************
        * Bring menuItem control to front
        * ********************************************************************************************************
        */
        private void BtnMenuSideBar_Click(object sender, EventArgs e) {
            menuItem.BringToFront();
        }

        /* METHOD : (6)
        * ********************************************************************************************************
        * Bring chartGenerator control to front
        * ********************************************************************************************************
        */
        private void BtnChartSideBar_Click(object sender, EventArgs e) {
            chartGenerator.BringToFront();
        }

        /* METHOD : (7)
        * ********************************************************************************************************
        * Bring billGenerator control to front
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
