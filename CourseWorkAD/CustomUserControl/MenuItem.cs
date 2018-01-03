using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using CourseWorkAD.Model;
using CourseWorkAD.Serialization;
using CourseWorkAD.FormValidator;
using CourseWorkAD.Sources;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Return category item list.
 * METHOD 2 : Deserialize item details and insert into table.
 * METHOD 3 : Import CSV file from file explorer. (Button click listener) 
 * METHOD 4 : Add imported CSV file into table. (Button click listener) 
 * METHOD 5 : Cancle import. (Button click listener) 
 * METHOD 6 : Process CSV file which is imported by METHOD:3 and inserted by METHOD:4.
 * METHOD 7 : Add single item at a time into table. (Button click listener) 
 * METHOD 8 : Clear all textbox. 
 * METHOD 9 : Cancle item insertation process. (Button click listener)
 * METHOD 10 : Main method which insert data into table.
 * METHOD 11 : Data table row header double click listener for updating purpose. (Double click listener)
 * METHOD 12 : Delete item from table. (Button click listener)
 * METHOD 13 : Check box checked change listener for sorting tables by item name. (Check box checked change listener)
 * METHOD 14 : Check box checked change listener for sorting tables by item price. (Check box checked change listener)
 * METHOD 15 : Update data table after sorting.
 * METHOD 16 : List of items which is sorted by item price.
 * METHOD 17 : List of items which is sorted by item name.
 * METHOD 18 : TextBox key press event handaler (For validation purpose).
 */

namespace CourseWorkAD.CustomUserControl {

    public partial class MenuItem : UserControl {

        public static string dataLocation = Application.StartupPath + @"\ItemsData.dat";    // Serialize file location
        private ComponentResourceManager resources;
        private Boolean update = false;     // Check either to update or insert item
        private int updateIndex;            // Updating item index
        private static List<Item> itemList = new List<Item>();  // Generic type list which holds items
        internal static List<Item> ItemList { get => itemList; set => itemList = value; }   // Getter and setter

        // System build constructor
        public MenuItem() {

            InitializeComponent();           // System build method to load all components belongs to this class
            resources = new ComponentResourceManager(typeof(MenuItem));     // For using images
            dropDownItemCategory.Items = ItemCategory();                    // Set itemCategory values
            dropDownItemCategory.selectedIndex = 0;                         // Select first index from dropdown items
            InsertSerializeDataIntoTable();                                 // Call method to insert data into table

        }

        /* METHOD : (1)
        * ********************************************************************************************************
        * Custom categories which return array of string type
        * ********************************************************************************************************
        */
        private string[] ItemCategory() {

            string[] items = {
                "--- Item Category ---",
                "Drinks",
                "Food",
                "Beverage",
                "Breakfast",
                "Nepali",
                "Chinees",
                "Indian",
                "Coffee & Soup"};

            return items;
        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * Deserialize items from file location only if file is exist.
        * There is DeserializeItems method inside Serializer class which will carry Deserializing process.
        * Store results into SerializeItem class through object.
        * Assign value to attribute, loop through each items and call method to insert data into table.
        * ********************************************************************************************************
        */
        private void InsertSerializeDataIntoTable() {

            if (File.Exists(dataLocation)) {

                SerializeItem serializeItem = new SerializeItem();
                serializeItem = new Serializer().DeserializeItems("ItemsData.dat");

                itemList = serializeItem.Items;

                for (int i = 0; i < itemList.Count; i++) {
                    InsertDataIntoTable(ItemList[i]);
                }

            }

        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * First open file dialog with some filters(File extension) to select files from the system.
        * If result is ok then check either this import is hapinning first time or not.
        * If this was'nt the first time then ask if it is a updated one. If yes then proceed else cancle import.
        * ********************************************************************************************************
        */
        private void BtnImport_Click(object sender, EventArgs e) {

            OpenFileDialog fileDialog = new OpenFileDialog {
                Filter = "Files(*.txt, *.csv) | *.txt; *.csv; | All files (*.*) | *.* "
            };

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK) {

                if(File.Exists(dataLocation)) {

                    if (MessageBox.Show("It seems like data has been already imported. \n Is this updated one ? ", "Import Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes) {

                        txtBoxFileLocation.Text = fileDialog.FileName;                       

                    } else {
                        txtBoxFileLocation.ResetText();
                    }  
                    
                } else {
                    txtBoxFileLocation.Text = fileDialog.FileName;
                }

            }

        }

        /* METHOD : (4)
        * ********************************************************************************************************
        * If textbox is empty inform user.
        * Else, call method ProcessCSVFileData to proceed with imported CSV file.
        * If ProcessCSVFileData method returns true (Which means process completed) then reset textbox.
        * ********************************************************************************************************
        */
        private void BtnAddImportData_Click(object sender, EventArgs e) {

            if (txtBoxFileLocation.Text == "") {
                MessageBox.Show("There is no imported file to add into table.", " Missing file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {

                if(ProcessCSVFileData(txtBoxFileLocation.Text)) {
                    txtBoxFileLocation.ResetText();
                }  
                        
            }
            
        }

        /* METHOD : (5)
        * ********************************************************************************************************
        * Cancle import process by clearing filelocation from textbox.
        * ********************************************************************************************************
        */
        private void BtnCancelImport_Click(object sender, EventArgs e) {
            txtBoxFileLocation.ResetText();
        }

        /* METHOD : (6)
        * ********************************************************************************************************
        * This method will read CSV file data and if file is correct one this will insert all datas into table.
        * Otherwise, informe users about wrong file.
        * ********************************************************************************************************
        */
        private Boolean ProcessCSVFileData(string filePath) {

            try {
                //Reading cvs file using pre-defined method 
                TextFieldParser csvReader = new TextFieldParser(filePath);

                //Set delimiter for the reader
                csvReader.SetDelimiters(new string[] { "," });

                //If fields are enclose in quotation marks use this
                csvReader.HasFieldsEnclosedInQuotes = true;

                // Skipping header from the csv file
                //csvReader.ReadLine();

                // This process itself help to skipping header from csv file.
                string[] heading = csvReader.ReadFields();

                // Validating is file is correct on or not
                if (heading.Length == 4 && heading[0].ToLower().Equals("code") && heading[1].ToLower().Equals("particular") && heading[2].ToLower().Equals("category") && heading[3].ToLower().Equals("price")) {

                    dataGridMenu.Rows.Clear();      // Clear rows from table
                    ItemList.Clear();               // Clear items from List which is generic type

                    while (!csvReader.EndOfData) {  // Loop untill last data come to focus
                        // Read all fields of current line
                        string[] fieldData = csvReader.ReadFields();

                        // Add into Item class which store all the details. (See Item class structure for better understsnd)
                        Item item = new Item {
                            ItemCode = fieldData[0],
                            ItemName = fieldData[1],
                            ItemCategory = fieldData[2],
                            ItemRate = fieldData[3]
                        };

                        ItemList.Add(item);         // Add items into List. This is the list which we will serialize later.
                        InsertDataIntoTable(item);  // Add items into table

                    }

                    return true;    // Return true after successful insertation of data

                } else {
                    // Inform user for wrong file and return false.
                    MessageBox.Show("Opps ! This might be wrong data.", " Data Mismach", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxFileLocation.ResetText();
                    return false;
                }
            } catch (Exception e) {
                // In case of any other exception print message
                MessageBox.Show(e.Message, " Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /* METHOD : (7)
        * ********************************************************************************************************
        * Validate each textbox and dropdown. After validation check if action is to update or insert.
        * If action is to add then add into list and table both finally clear fields.
        * If actioni is to update then update both table and list.
        * ********************************************************************************************************
        */
        private void BtnAddItem_Click(object sender, EventArgs e) {

            Validator.neumericOnlyTextBoxRate = txtBoxItemPrice;       

            if (Validator.ValidateText(txtBoxItemCode) && Validator.ValidateText(txtBoxItemName) && Validator.ValidateText(txtBoxItemPrice)) {

                if (!update) {

                    // ADD ITEM
                    Item item = new Item {
                        ItemCode = txtBoxItemCode.Text,
                        ItemName = txtBoxItemName.Text,
                        ItemCategory = Validator.ValidateDropDown(dropDownItemCategory),
                        ItemRate = txtBoxItemPrice.Text
                    };

                    itemList.Add(item);
                    InsertDataIntoTable(item);
                    ClearFields();

                } else {

                    // UPDATE ITEM
                    Item editItem = itemList[updateIndex];

                    // Updating table and updating list is done at the same time.
                    dataGridMenu.Rows[updateIndex].Cells[1].Value = (editItem.ItemCode = txtBoxItemCode.Text);
                    dataGridMenu.Rows[updateIndex].Cells[2].Value = (editItem.ItemName = txtBoxItemName.Text);
                    dataGridMenu.Rows[updateIndex].Cells[3].Value = (editItem.ItemCategory = FormValidator.Validator.ValidateDropDown(dropDownItemCategory));
                    dataGridMenu.Rows[updateIndex].Cells[4].Value = (editItem.ItemRate = txtBoxItemPrice.Text);

                    ClearFields();
                    btnAddItem.ButtonText = "A D D   I T E M";  // After update set button name as additem and change icon too
                    btnAddItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Iconimage")));
                }

            }

        }

        /* METHOD : (8)
        * ********************************************************************************************************
        * Clear textbox fields and change selected index of dropdown control to 0 as well
        * ********************************************************************************************************
        */
        private void ClearFields() {

            txtBoxItemCode.ResetText();
            txtBoxItemName.ResetText();
            txtBoxItemPrice.ResetText();
            dropDownItemCategory.selectedIndex = 0;

        }

        /* METHOD : (9)
        * ********************************************************************************************************
        * Clear textbox and dropdown select to default.
        * And if task was for update then clear table selection as well.
        * ********************************************************************************************************
        */
        private void BtnCancelItem_Click(object sender, EventArgs e) {
            txtBoxItemCode.ResetText();
            txtBoxItemName.ResetText();
            txtBoxItemPrice.ResetText();
            dropDownItemCategory.selectedIndex = 0;

            // Clear selected row from table.
            if (update) {
                dataGridMenu.ClearSelection();
            }
        }

        /* METHOD : (10)
        * ********************************************************************************************************
        * Insert data into table as per item value received through parameter.
        * ********************************************************************************************************
        */
        private void InsertDataIntoTable(Item item) {

            int targetRow = dataGridMenu.Rows.Count - 1;    // Data insertable row of the data table
            dataGridMenu.Rows.Add();                        // Add new row
            // Add values in row
            dataGridMenu.Rows[targetRow].Cells[0].Value = itemList.IndexOf(item) + 1;
            dataGridMenu.Rows[targetRow].Cells[1].Value = item.ItemCode;
            dataGridMenu.Rows[targetRow].Cells[2].Value = item.ItemName;
            dataGridMenu.Rows[targetRow].Cells[3].Value = item.ItemCategory;
            dataGridMenu.Rows[targetRow].Cells[4].Value = item.ItemRate;

        }

        /* METHOD : (11)
        * ********************************************************************************************************
        * When row header is double clicked set textbox with corresponding values.
        * Set button name as update and change button icon as well.
        * ********************************************************************************************************
        */
        private void DataGridMenu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {

            this.updateIndex = e.RowIndex;      // Set attribute value by index which is going to be updated
            txtBoxItemCode.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[1].Value);
            txtBoxItemName.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[2].Value);
            txtBoxItemPrice.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[4].Value);
            btnAddItem.Text = "U P D A T E";
            btnAddItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.update = true;     // Set update attribute as true which will be used to identify either to add an item or update

        }

        /* METHOD : (12)
        * ********************************************************************************************************
        * Delete item from list as well as data.
        * ********************************************************************************************************
        */
        private void BtnDeleteMenuItem_Click(object sender, EventArgs e) {

            // Check if any row is selected or not
            if (dataGridMenu.SelectedRows.Count != 0) {

                /*  Last row is always an empty row so never select that row
                 *  Check last row is selected or not. If it is selected then unselect it.
                 */
                var lastRow = dataGridMenu.Rows[dataGridMenu.RowCount - 1];
                if (lastRow.Selected) {
                    lastRow.Selected = false;
                }

                // Delete items after confirmation
                if (MessageBox.Show(" You cannot retrive these data once you delete.\n Proceed anyway ?", "Delete Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes) {

                    // Looping through all selected rows and remove them
                    foreach (DataGridViewRow rows in dataGridMenu.SelectedRows) {
                        itemList.RemoveAt(rows.Index);
                        dataGridMenu.Rows.RemoveAt(rows.Index);
                    }

                } else {
                    // Looping through all selected rows and unselect them
                    foreach (DataGridViewRow rows in dataGridMenu.SelectedRows) {
                        rows.Selected = false;
                    }
                }

                // Re-setting symbool number after deleting rows
                for (int i = 0; i < dataGridMenu.RowCount - 1; i++) {
                    dataGridMenu.Rows[i].Cells[0].Value = i + 1;
                }
                //dataGridMenu.Rows.RemoveAt(dataGridMenu.CurrentCell.RowIndex);
            } else {
                MessageBox.Show("No rows selected", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /* METHOD : (13)
        * ********************************************************************************************************
        * Allow user to sort table either by item or price but not by both at the same time.
        * While selecting one another will be disabled.
        * Update data table as per sort selection
        * ********************************************************************************************************
        */
        private void CbSortItems_CheckedChanged(object sender, EventArgs e) {

            if(cbSortItems.Checked) {
                UpdateDataTable(SortedItemsByItem());   // Sort data tabel by item name
                cbSortPrice.Enabled = false;            // Disable price sorting
            } else {
                UpdateDataTable(itemList);              // Restore data table to default
                cbSortPrice.Enabled = true;             // Enable item price sorting
            }

        }

        /* METHOD : (14)
        * ********************************************************************************************************
        * Allow user to sort table either by item or price but not by both at the same time.
        * While selecting one another will be disabled.
        * Update data table as per sort selection
        * ********************************************************************************************************
        */
        private void CbSortPrice_CheckedChanged(object sender, EventArgs e) {

            if (cbSortPrice.Checked) {
                UpdateDataTable(SortedItemsByPrice());      // Sort data tabel by item price
                cbSortItems.Enabled = false;                // Disable item name sorting
            } else {
                UpdateDataTable(itemList);                  // Restore data table to default
                cbSortItems.Enabled = true;                 // Enable item name sorting
            }

        }

        /* METHOD : (15)
        * ********************************************************************************************************
        * Clear all rows befor updting table.
        * Update table by sorted list
        * Set symboll number serially
        * ********************************************************************************************************
        */
        private void UpdateDataTable(List<Item> itemList) {

            dataGridMenu.Rows.Clear();
            for (int i = 0; i < itemList.Count; i++) {
                InsertDataIntoTable(itemList[i]);
                dataGridMenu.Rows[i].Cells[0].Value = i + 1;    // SN re-formated
            }

        }

        /* METHOD : (16)
        * ********************************************************************************************************
        * Return sorted generic list by item price. 
        * ********************************************************************************************************
        */
        private static List<Item> SortedItemsByPrice() {

            int[] unsortedArray = new int[itemList.Count];      // Creat new array having same size of itemlist.

            // Loop through itemList and add price of the item into above created array
            for (int i = 0; i < itemList.Count; i++) {
                unsortedArray[i] = Convert.ToInt32(itemList[i].ItemRate);
            }

            // Method NumericQuickSort inside PerformQuickSort will return sorted array. Check it out.
            // It takes three arguments array, start point and end point of array.
            int[] sortedArray = PerformQuickSort.NumericQuickSort(unsortedArray, 0, unsortedArray.Length - 1);

            // To store final sorted items. This list will be returned as result by this method.
            List<Item> sortedItems = new List<Item>();     
            List<Item> tempItemList = new List<Item>(ItemList);     // Temporary list to manupulate data. Copy of the item list.

            for (int i = 0; i < sortedArray.Length; i++) {      // Loop into sorted array

                for (int j = 0; j < tempItemList.Count; j++) {  // Loop into temp item list

                    /* If value from sorted item is matched to items value inside temItemList
                    * This process will work serially according to sorted array values
                    * which result as list of sorted items by price.
                    */
                    if (sortedArray[i] == Convert.ToInt32(tempItemList[j].ItemRate)) {  
                        sortedItems.Add(tempItemList[j]);   // Add item to sortedList
                        tempItemList.RemoveAt(j);           // Remove item from temp list. Dont need that item again.
                        break;                              // As soon as search item found dont run loop further.
                    }

                }

            }

            return sortedItems;
        }

        /* METHOD : (17)
        * ********************************************************************************************************
        * Return sorted generic list by item name. 
        * ********************************************************************************************************
        */
        private static List<Item> SortedItemsByItem() {

            string[] unsortedArray = new string[itemList.Count];    // Creat new array having same size of itemlist.

            // Loop through itemList and add item name of into above created array
            for (int i = 0; i < itemList.Count; i++) {
                unsortedArray[i] = itemList[i].ItemName;
            }

            // Method CharacterQuickSort inside PerformQuickSort will return sorted array. Check it out.
            // It takes three arguments array, start point and end point of array.
            // The role of IComparable is to provide a method of comparing two objects of a particular type.
            IComparable[] sortedArray = PerformQuickSort.CharacterQuickSort(unsortedArray, 0, unsortedArray.Length - 1);

            // To store final sorted items. This list will be returned as result by this method.
            List<Item> sortedItems = new List<Item>();
            List<Item> tempItemList = new List<Item>(ItemList);     // Temporary list to manupulate data. Copy of the item list.

            for (int i = 0; i < sortedArray.Length; i++) {      // Loop into sorted array

                for (int j = 0; j < tempItemList.Count; j++) {  // Loop into temp item list

                    /* If value from sorted item is matched to items value inside tempItemList
                    * This process will work serially according to sorted array values
                    * which result as list of sorted items by name.
                    */
                    if (sortedArray[i].Equals(tempItemList[j].ItemName)) {
                        sortedItems.Add(tempItemList[j]);       // Add item to sortedList
                        tempItemList.RemoveAt(j);               // Remove item from temp list. Dont need that item again.
                        break;                                  // As soon as search item found dont run loop further.
                    }

                }

            }

            return sortedItems;
        }

        /* METHOD : (18)
        * ********************************************************************************************************
        * Call method TextBox_KeyPress which is inside Validator class to prevent user from providing input other 
        * then numeric one. 
        * ********************************************************************************************************
        */
        private void TxtBoxItemPrice_KeyPress(object sender, KeyPressEventArgs e) {
            Validator.TextBox_KeyPress(sender, e);
        }
    }

}
