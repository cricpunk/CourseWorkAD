using CourseWorkAD.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CourseWorkAD {

    public partial class CanteenPOSSystem : Form {

        public CanteenPOSSystem() {
            InitializeComponent();
            homePage.BringToFront();           
        }

        private void BtnSystemClose_Click(object sender, EventArgs e) {

            Model.SerializeItem serializeItem = new Model.SerializeItem { Items = CustomUserControl.MenuItem.ItemList };
            Model.SerializeItem revenueToSerialize = new Model.SerializeItem { TotalSalesCollection = CustomUserControl.BillGenerator.TotalSalesCollection };

            SerializeThis(CustomUserControl.MenuItem.dataLocation, "ItemsData.dat", serializeItem);
            SerializeThis(CustomUserControl.BillGenerator.revenueDataLocation, "RevenuesData.dat", revenueToSerialize);

            this.Close();
        }

        private void SerializeThis(string path, string fileName, Model.SerializeItem serializeItem) {

            if (File.Exists(path)) {
                File.Delete(path);
                new Serializer().SearilizeItems(fileName, serializeItem);
            } else {
                new Serializer().SearilizeItems(fileName, serializeItem);
            }

        }

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

        private void BtnHomeSideBar_Click(object sender, EventArgs e) {
            homePage.BringToFront();
        }

        private void BtnMenuSideBar_Click(object sender, EventArgs e) {
            menuItem.BringToFront();
        }

        private void BtnChartSideBar_Click(object sender, EventArgs e) {
            chartGenerator.BringToFront();
        }

        private void BtnGenerateBillSideBar_Click(object sender, EventArgs e) {
            billGenerator.BringToFront();
        }

    }
}
