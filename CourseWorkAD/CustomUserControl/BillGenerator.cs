using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using CourseWorkAD.Model;
using CourseWorkAD.Serialization;
using CourseWorkAD.FormValidator;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Deserialize total revenue details of items.
 * METHOD 2 : Enter(i.e. When focus) events of BillGenerator (i.e. This user control).
 * METHOD 3 : Setting items name into item dropdown control.
 * METHOD 4 : Dictionary which return items code and name as key value pair.
 * METHOD 5 : Dictionary which return items code and rate as key value pair.
 * METHOD 6 : Item dropdown OnItemSelect listener.
 * METHOD 7 : Button add item click listener.
 * METHOD 8 : Record total sales into a dictionary.
 * METHOD 9 : Total amount received textbox value changed listener.
 * METHOD 10 : Button print bill click listener.
 * METHOD 11 : Button clear bill click listener.
 * METHOD 12 : TextBox itemRate key pressed event for validation purpose. 
 * METHOD 13 : TextBox itemQuantity key pressed event for validation purpose. 
 * METHOD 14 : TextBox receivedAmount key pressed event for validation purpose. 
 */

namespace CourseWorkAD.CustomUserControl {

    public partial class BillGenerator : UserControl {

        // Location of total revenue serialized file
        public static string revenueDataLocation = Application.StartupPath + @"\RevenuesData.dat"; 
        private string SERVICE_CHARGE = "Service Charge 15%   :";   // Change service charge rate from here       
        private double grandTotal;                                  // Bill amount
        private List<Item> itemsList = MenuItem.ItemList;           // Initialize itemlist value from menuItem class
        /* You have to access this dictionary from BillGenerator class so making it static for simplicity.
         * This dictionary will store item name as key and total revenue as value.
         * Getter and Setter is used to set and retrive value.
         */
        private static Dictionary<string, int> totalSalesCollection = new Dictionary<string, int>();
        internal static Dictionary<string, int> TotalSalesCollection { get => totalSalesCollection; set => totalSalesCollection = value; }

        // System build constructor
        public BillGenerator() {

            InitializeComponent();                      // System build method to load all components belongs to this class
            lblServiceChargeRate.Text = SERVICE_CHARGE; // Set service charge rate
            SetDropdownItems(itemsList);                // Set items name into dropdown list
            DeserializeTotalSalesCollection();          // Deserialize total revenues 
            lblBillDate.Text = "Date : " + DateTime.Now.ToString("dd/MM/yyyy");     // Current date

        }

        /* METHOD : (1)
         * ********************************************************************************************************
         * If serialized file is exist in provided location
         * Then create an object of SearializeItem class which store all the data.
         * Asign value to created object which is returned by DeserializeItems methods from Serializer class.
         * Return value will be the dictionary holding item name and total revenu as key and value.
         * Finally assign value to attribute totalSalesCollection 
         * ********************************************************************************************************
         */
        private void DeserializeTotalSalesCollection() {

            if (File.Exists(revenueDataLocation)) {

                SerializeItem serializeItem = new SerializeItem();
                serializeItem = new Serializer().DeserializeItems("RevenuesData.dat");

                totalSalesCollection = serializeItem.TotalSalesCollection;

            }

        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * Item dropdown will be updated each time this control come in focus.
        * ********************************************************************************************************
        */
        private void BillGenerator_Enter(object sender, EventArgs e) {
            SetDropdownItems(MenuItem.ItemList);
        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * If item list received through parameter is not null then proceed.
        * Create array for storing item name of string type.
        * Add first item as --select item-- which will be set as default selection. (Providing information).
        * Loop through itemList and add only itemName into array.
        * Finally set dropdown items by assigning item name array set 1st index as selected index.
        * ********************************************************************************************************
        */
        internal void SetDropdownItems(List<Item> itemsList) {

            if (itemsList != null) {

                string[] itemName = new string[itemsList.Count + 1];
                itemName[0] = "--- Select Item ---";

                for (int i = 0; i < itemsList.Count; i++) {
                    itemName[i + 1] = itemsList[i].ItemName;
                }

                dropDownItemcategoryBill.Items = itemName;
                dropDownItemcategoryBill.selectedIndex = 0;
            }

        }

        /* METHOD : (4)
        * ********************************************************************************************************
        * Create dictionary which hold itemCode and itemName of string data type.
        * Loop through itemList and add itemCode as key and itemName as value.
        * Finaly, return dictionary.
        * ********************************************************************************************************
        */
        private Dictionary<string, string> MenuItemCodeAndName() {

            Dictionary<string, string> itemsAndCode = new Dictionary<string, string>();
   
            for (int i = 0; i < itemsList.Count; i++) {
                itemsAndCode.Add(itemsList[i].ItemCode, itemsList[i].ItemName);
            }

            return itemsAndCode;
        }

        /* METHOD : (5)
        * ********************************************************************************************************
        * Same process followed by METHOD 5 to return dictionary having itemCode and itemRate as key and value.
        * ********************************************************************************************************
        */
        private Dictionary<string, string> MenuItemCodeAndPrice() {

            Dictionary<string, string> codeAndRate = new Dictionary<string, string>();

            for (int i = 0; i < itemsList.Count; i++) {
                codeAndRate.Add(itemsList[i].ItemCode, itemsList[i].ItemRate);
            }

            return codeAndRate;
        }

        /* METHOD : (6)
        * ********************************************************************************************************
        * Make sure selected item is othar than in first index.
        * Set itemCode and itemRate into textbox. Above created dictionary is used to do so.
        * If selected index is first then reset textBox.
        * ********************************************************************************************************
        */
        private void DropDownItemcategoryBill_onItemSelected(object sender, EventArgs e) {

            string itemName = dropDownItemcategoryBill.selectedValue;

            if (dropDownItemcategoryBill.selectedIndex != 0) {
                txtItemCodeBill.Text = MenuItemCodeAndName().Keys.ElementAt(dropDownItemcategoryBill.selectedIndex - 1);
                txtItemRateBill.Text = MenuItemCodeAndPrice()[txtItemCodeBill.Text];
            } else {
                txtItemCodeBill.ResetText();
                txtItemRateBill.ResetText();
                txtItemQtyBill.ResetText();
            }

        }

        /* METHOD : (7)
        * ********************************************************************************************************
        * Perform validation for all textBox.
        * After successful validation add items into dataGridView.
        * As soon as item inserted into table Calculate billing amounts at a same time.
        * Reset textBox and dropdown.
        * Finally, call method to record total sales for that inserted item.
        * ********************************************************************************************************
        */
        private void BtnAddItemInttoBill_Click(object sender, EventArgs e) {
            Validator.neumericOnlyTextBoxRate = txtItemQtyBill;     // For extra validation purpose (Restrict value below 1)
            if (Validator.ValidateText(txtItemCodeBill) && Validator.ValidateText(txtItemRateBill) && Validator.ValidateText(txtItemQtyBill)) {

                // Add item into billing table as sold item
                int targetRow = dataGridBill.Rows.Count - 1;
                dataGridBill.Rows.Add();
                dataGridBill.Rows[targetRow].Cells[0].Value = targetRow + 1;
                dataGridBill.Rows[targetRow].Cells[1].Value = FormValidator.Validator.ValidateDropDown(dropDownItemcategoryBill);
                dataGridBill.Rows[targetRow].Cells[2].Value = Convert.ToInt32(txtItemRateBill.Text);
                dataGridBill.Rows[targetRow].Cells[3].Value = Convert.ToInt32(txtItemQtyBill.Text);
                dataGridBill.Rows[targetRow].Cells[4].Value = Convert.ToInt32(txtItemRateBill.Text) * Convert.ToInt32(txtItemQtyBill.Text);

                
                double totalAmount = 0;

                // Loop through each row and calculate total bill amount
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

                string itemName = dataGridBill.Rows[targetRow].Cells[1].Value.ToString();
                int itemPrice = Convert.ToInt32(dataGridBill.Rows[targetRow].Cells[4].Value);

                // Update total sales (METHOD : 8)
                RecordTotalSales(itemName, itemPrice);

            }

        }

        /* METHOD : (8)
        * ********************************************************************************************************
        * If itemName is already there in totalSales recorded dictionary
        * then update its value by recent amount.
        * If item is sold for the first time then add itemName and price into dictionary.
        * ********************************************************************************************************
        */
        private void RecordTotalSales(string itemName, int itemPrice) {

            if(totalSalesCollection.ContainsKey(itemName)) {
                totalSalesCollection[itemName] += itemPrice;              
            } else {
                totalSalesCollection.Add(itemName, itemPrice);
            }
            ChartGenerator.changesInChart = true;
        }

        /* METHOD : (9)
        * ********************************************************************************************************
        * If amountReceived textBox is not empty then calculate return amount and display it.
        * ********************************************************************************************************
        */
        private void TxtReceivedAmount_OnValueChanged(object sender, EventArgs e) {

            if (txtReceivedAmount.Text != "") {
                int receivedAmount = Convert.ToInt32(txtReceivedAmount.Text);
                double returnAmount = receivedAmount - grandTotal;
                txtRefundAmount.Text = returnAmount.ToString("N");
            }

        }

        /* METHOD : (10)
        * ********************************************************************************************************
        * If there isnt any item in dataGridView then inform user about empty bill.
        * Set customer name and time of bill after validating and provide information to user.
        * ********************************************************************************************************
        */
        private void BtnPrintBill_Click(object sender, EventArgs e) {
            
            if(dataGridBill.RowCount > 1) {

                if (txtCustomerName.Text.Equals("")) {
                    lblCustomerName.Text = "Name : Not Given";
                } else {
                    lblCustomerName.Text = "Name : " + txtCustomerName.Text;
                }
                lblBillCreateTime.Text = "Create Time : " + DateTime.Now.ToString();
                MessageBox.Show("Bill has been printed", " Bill generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("There is nothing to print.", " Bill generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /* METHOD : (11)
        * ********************************************************************************************************
        * Reset textBox 
        * ********************************************************************************************************
        */
        private void BtnClearBill_Click(object sender, EventArgs e) {
            txtCustomerName.ResetText();
            txtReceivedAmount.ResetText();
            txtRefundAmount.ResetText();
        }

        /* METHOD : (12)
        * ********************************************************************************************************
        * This method will call TextBoxKeyPress event method inside Validator class to prevent
        * typing other than neumeric.
        * ********************************************************************************************************
        */
        private void TxtItemRateBill_KeyPress(object sender, KeyPressEventArgs e) {
            FormValidator.Validator.TextBox_KeyPress(sender, e);
        }

        /* METHOD : (13)
        * ********************************************************************************************************
        * This method will call TextBoxKeyPress event method inside Validator class to prevent
        * typing other than neumeric. 
        * ********************************************************************************************************
        */
        private void TxtItemQtyBill_KeyPress(object sender, KeyPressEventArgs e) {
            FormValidator.Validator.TextBox_KeyPress(sender, e);
        }

        /* METHOD : (14)
        * ********************************************************************************************************
        * This method will call TextBoxKeyPress event method inside Validator class to prevent
        * typing other than neumeric.
        * ********************************************************************************************************
        */
        private void TxtReceivedAmount_KeyPress(object sender, KeyPressEventArgs e) {
            FormValidator.Validator.TextBox_KeyPress(sender, e);
        }
    }

}
