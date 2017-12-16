using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CourseWorkAD {

    public partial class BillGenerator : UserControl {

        private string SERVICE_CHARGE = "Service Charge 15%   :";
        private double grandTotal;

        public BillGenerator() {
            InitializeComponent();
            dropDownItemcategoryBill.Items = ItemName();
            dropDownItemcategoryBill.selectedIndex = 0;
            lblServiceChargeRate.Text =  SERVICE_CHARGE;
        }

        private Dictionary<string, string> MenuItemCodeAndName() {

            Dictionary<string, string> itemsAndCode = new Dictionary<string, string>();

            if (File.Exists(MenuItem.dataLocation)) {

                List<Item> items = new List<Item>();
                ItemsToSerialize itemsToSerialize = new ItemsToSerialize();
                itemsToSerialize = new Serializer().DeserializeItems("ItemsData.dat");

                items = itemsToSerialize.Items;

                for (int i = 0; i < items.Count; i++) {
                    itemsAndCode.Add(items[i].ItemCode, items[i].ItemName);
                }

            }

            return itemsAndCode;
        }

        private Dictionary<string, string> MenuItemCodeAndPrice() {

            Dictionary<string, string> codeAndRate = new Dictionary<string, string>();

            if (File.Exists(MenuItem.dataLocation)) {

                List<Item> items = new List<Item>();
                ItemsToSerialize itemsToSerialize = new ItemsToSerialize();
                itemsToSerialize = new Serializer().DeserializeItems("ItemsData.dat");

                items = itemsToSerialize.Items;

                for (int i = 0; i < items.Count; i++) {
                    codeAndRate.Add(items[i].ItemCode, items[i].ItemRate);
                }

            }

            return codeAndRate;
        }

        private string[] ItemName() {

            string[] itemName = new string[MenuItemCodeAndName().Count+1];
            itemName[0] = "--- Select Item ---";

            for (int i = 0; i < MenuItemCodeAndName().Count; i++) {
                itemName[i+1] = MenuItemCodeAndName()[MenuItemCodeAndName().Keys.ElementAt(i)];
            }

            return itemName;
        }

        private void TxtItemCodeBill_KeyPress(object sender, KeyPressEventArgs e) {
            char chart = e.KeyChar;

            MessageBox.Show(Convert.ToString(chart), " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnAddItemInttoBill_Click(object sender, EventArgs e) {

            FormValidator.Validator.neumericOnlyTextBox1 = txtItemRateBill;
            FormValidator.Validator.neumericOnlyTextBox = txtItemQtyBill;

            if (FormValidator.Validator.ValidateText(txtItemCodeBill) && FormValidator.Validator.ValidateText(txtItemRateBill) && FormValidator.Validator.ValidateText(txtItemQtyBill)) {

                int targetRow = dataGridBill.Rows.Count - 1;
                dataGridBill.Rows.Add();
                dataGridBill.Rows[targetRow].Cells[0].Value = targetRow + 1;
                dataGridBill.Rows[targetRow].Cells[1].Value = FormValidator.Validator.ValidateDropDown(dropDownItemcategoryBill);
                dataGridBill.Rows[targetRow].Cells[2].Value = Convert.ToInt32(txtItemRateBill.Text);
                dataGridBill.Rows[targetRow].Cells[3].Value = Convert.ToInt32(txtItemQtyBill.Text);
                dataGridBill.Rows[targetRow].Cells[4].Value = Convert.ToInt32(txtItemRateBill.Text) * Convert.ToInt32(txtItemQtyBill.Text);

                double totalAmount = 0;

                for (int i = 0; i < dataGridBill.RowCount - 1; i++) {
                    totalAmount += Convert.ToInt32(dataGridBill.Rows[i].Cells[4].Value);
                }

                double subTotal = totalAmount;
                double serviceCharge = subTotal * 12.4 / 100;
                this.grandTotal = subTotal + serviceCharge;

                lblTotalAmt.Text = totalAmount.ToString("N");
                lblSubTotal.Text = subTotal.ToString("N");
                lblServiceCharge.Text = serviceCharge.ToString("N");
                lblGrandTotal.Text = grandTotal.ToString("N");

                txtItemCodeBill.ResetText();
                dropDownItemcategoryBill.selectedIndex = 0;
                txtItemRateBill.ResetText();
                txtItemQtyBill.ResetText();

            }

        }

        private void BtnPrintBill_Click(object sender, EventArgs e) {

        }

        private void BtnCancelBill_Click(object sender, EventArgs e) {

        }

        private void TxtItemCodeBill_OnValueChanged(object sender, EventArgs e) {

        }

        private void DropDownItemcategoryBill_onItemSelected(object sender, EventArgs e) {
            
            string itemName = dropDownItemcategoryBill.selectedValue;

            if(dropDownItemcategoryBill.selectedIndex != 0) {
                txtItemCodeBill.Text = MenuItemCodeAndName().Keys.ElementAt(dropDownItemcategoryBill.selectedIndex - 1);
                txtItemRateBill.Text = MenuItemCodeAndPrice()[txtItemCodeBill.Text];
            }
           
        }

        private void TxtReceivedAmount_OnValueChanged(object sender, EventArgs e) {

            if(txtReceivedAmount.Text != "") {
                int receivedAmount = Convert.ToInt32(txtReceivedAmount.Text);
                double returnAmount = receivedAmount - grandTotal;
                txtRefundAmount.Text = returnAmount.ToString("N");
            }

        }


    }
}
