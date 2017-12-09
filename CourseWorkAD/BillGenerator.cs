using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAD {
    public partial class BillGenerator : UserControl {

        MenuItem menuItem;

        public BillGenerator() {
            InitializeComponent();
            menuItem = new MenuItem();
        }

        private void TxtItemCodeBill_KeyPress(object sender, KeyPressEventArgs e) {
            char chart = e.KeyChar;

            var first = menuItem.ItemCodeName.First();

            MessageBox.Show(first.Value, " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnAddItemInttoBill_Click(object sender, EventArgs e) {

        }

        private void BtnPrintBill_Click(object sender, EventArgs e) {

        }

        private void BtnCancelBill_Click(object sender, EventArgs e) {

        }

        private void TxtItemCodeBill_OnValueChanged(object sender, EventArgs e) {

        }

        private void DropDownItemcategoryBill_onItemSelected(object sender, EventArgs e) {

        }

        private void TxtReceivedAmount_Enter(object sender, EventArgs e) {

        }

        private void TxtReceivedAmount_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void TxtReceivedAmount_OnValueChanged(object sender, EventArgs e) {

        }

        
    }
}
