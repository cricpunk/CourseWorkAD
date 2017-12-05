using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAD
{
    public partial class MenuGenerator : Form {

        public MenuGenerator() {
            InitializeComponent();
        }

        private void BtnSystemClose_Click(object sender, EventArgs e) {
            this.Close();
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
    }
}
