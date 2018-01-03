using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
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
 * METHOD 12 : Start timer.
 * METHOD 13 : Timer tick event handler. 
 * METHOD 14 : Total amount received textbox value changed listener.
 * METHOD 15 : Button print bill click listener.
 * METHOD 16 : Button clear bill click listener.
 * METHOD 17 : Start timer.
 * METHOD 18 : Timer tick event handler. 
 */

namespace CourseWorkAD.CustomUserControl {

    public partial class MenuItem : UserControl {

        private ComponentResourceManager resources;
        private Boolean update = false;
        private int updateIndex;
        private static List<Item> itemList = new List<Item>();
        internal static List<Item> ItemList { get => itemList; set => itemList = value; }
        public static string dataLocation = Application.StartupPath + @"\ItemsData.dat";

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
        * 
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
        * 
        * ********************************************************************************************************
        */
        private void InsertSerializeDataIntoTable() {

            if (File.Exists(dataLocation)) {

                //ItemsToSerialize itemsToSerialize = new ItemsToSerialize();

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
        * 
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
        * 
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
        * 
        * ********************************************************************************************************
        */
        private void BtnCancelImport_Click(object sender, EventArgs e) {
            txtBoxFileLocation.ResetText();
        }

        /* METHOD : (6)
        * ********************************************************************************************************
        * 
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

                string[] heading = csvReader.ReadFields();

                if (heading.Length == 4 && heading[0].ToLower().Equals("code") && heading[1].ToLower().Equals("particular") && heading[2].ToLower().Equals("category") && heading[3].ToLower().Equals("price")) {

                    dataGridMenu.Rows.Clear();
                    ItemList.Clear();

                    while (!csvReader.EndOfData) {
                        // Read all fields of current line
                        string[] fieldData = csvReader.ReadFields();

                        Item item = new Item {
                            ItemCode = fieldData[0],
                            ItemName = fieldData[1],
                            ItemCategory = fieldData[2],
                            ItemRate = fieldData[3]
                        };

                        ItemList.Add(item);
                        InsertDataIntoTable(item);

                    }

                    return true;

                } else {
                    MessageBox.Show("Opps ! This might be wrong data.", " Data Mismach", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxFileLocation.ResetText();
                    return false;
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, " Import CSV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /* METHOD : (7)
        * ********************************************************************************************************
        * 
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
                        ItemCategory = FormValidator.Validator.ValidateDropDown(dropDownItemCategory),
                        ItemRate = txtBoxItemPrice.Text
                    };

                    itemList.Add(item);
                    InsertDataIntoTable(item);
                    ClearFields();

                } else {

                    // UPDATE ITEM
                    Item editItem = itemList[updateIndex];

                    dataGridMenu.Rows[updateIndex].Cells[1].Value = (editItem.ItemCode = txtBoxItemCode.Text);
                    dataGridMenu.Rows[updateIndex].Cells[2].Value = (editItem.ItemName = txtBoxItemName.Text);
                    dataGridMenu.Rows[updateIndex].Cells[3].Value = (editItem.ItemCategory = FormValidator.Validator.ValidateDropDown(dropDownItemCategory));
                    dataGridMenu.Rows[updateIndex].Cells[4].Value = (editItem.ItemRate = txtBoxItemPrice.Text);

                    ClearFields();
                    btnAddItem.ButtonText = "A D D   I T E M";
                    btnAddItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Iconimage")));
                }

            }

        }

        /* METHOD : (8)
        * ********************************************************************************************************
        * 
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
        * 
        * ********************************************************************************************************
        */
        private void BtnCancelItem_Click(object sender, EventArgs e) {
            txtBoxItemCode.ResetText();
            txtBoxItemName.ResetText();
            txtBoxItemPrice.ResetText();
            dropDownItemCategory.selectedIndex = 0;

            if (update) {
                dataGridMenu.ClearSelection();
            }
        }

        /* METHOD : (10)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void InsertDataIntoTable(Item item) {

            int targetRow = dataGridMenu.Rows.Count - 1;
            dataGridMenu.Rows.Add();
            dataGridMenu.Rows[targetRow].Cells[0].Value = itemList.IndexOf(item) + 1;
            dataGridMenu.Rows[targetRow].Cells[1].Value = item.ItemCode;
            dataGridMenu.Rows[targetRow].Cells[2].Value = item.ItemName;
            dataGridMenu.Rows[targetRow].Cells[3].Value = item.ItemCategory;
            dataGridMenu.Rows[targetRow].Cells[4].Value = item.ItemRate;

        }

        /* METHOD : (11)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void DataGridMenu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {

            this.updateIndex = e.RowIndex;
            txtBoxItemCode.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[1].Value);
            txtBoxItemName.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[2].Value);
            txtBoxItemPrice.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[4].Value);
            //txtBoxItemCode.Text = Convert.ToString(dataGridMenu.Rows[selectedIndex].Cells[3].Value);
            btnAddItem.Text = "U P D A T E";
            btnAddItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.update = true;

        }

        /* METHOD : (12)
        * ********************************************************************************************************
        * 
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
        * 
        * ********************************************************************************************************
        */
        private void CbSortItems_CheckedChanged(object sender, EventArgs e) {

            if(cbSortItems.Checked) {
                UpdateDataTable(SortedItemsByItem());
                cbSortPrice.Enabled = false;
            } else {
                UpdateDataTable(itemList);
                cbSortPrice.Enabled = true;
            }

        }

        /* METHOD : (14)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void CbSortPrice_CheckedChanged(object sender, EventArgs e) {

            if (cbSortPrice.Checked) {
                UpdateDataTable(SortedItemsByPrice());
                cbSortItems.Enabled = false;
            } else {
                UpdateDataTable(itemList);
                cbSortItems.Enabled = true;
            }

        }

        /* METHOD : (15)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void UpdateDataTable(List<Item> itemList) {

            dataGridMenu.Rows.Clear();
            for (int i = 0; i < itemList.Count; i++) {
                InsertDataIntoTable(itemList[i]);
                dataGridMenu.Rows[i].Cells[0].Value = i + 1;
            }

        }

        /* METHOD : (16)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private static List<Item> SortedItemsByPrice() {

            int[] array = new int[itemList.Count]; 

            for (int i = 0; i < itemList.Count; i++) {
                array[i] = Convert.ToInt32(itemList[i].ItemRate);
            }

            int[] sortedArray = Sources.PerformQuickSort.NumericQuickSort(array, 0, array.Length - 1);

            List<Item> sortedItems = new List<Item>();
            List<Item> tempItemList = new List<Item>(ItemList);

            for (int i = 0; i < sortedArray.Length; i++) {

                for (int j = 0; j < tempItemList.Count; j++) {

                    if (sortedArray[i] == Convert.ToInt32(tempItemList[j].ItemRate)) {
                        sortedItems.Add(tempItemList[j]);
                        tempItemList.RemoveAt(j);
                        break;
                    }

                }

            }

            return sortedItems;
        }

        /* METHOD : (17)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private static List<Item> SortedItemsByItem() {

            string[] unsortedArray = new string[itemList.Count];

            for (int i = 0; i < itemList.Count; i++) {
                unsortedArray[i] = itemList[i].ItemName;
            }

            IComparable[] sortedArray = Sources.PerformQuickSort.CharacterQuickSort(unsortedArray, 0, unsortedArray.Length - 1);

            List<Item> sortedItems = new List<Item>();
            List<Item> tempItemList = new List<Item>(ItemList);

            for (int i = 0; i < sortedArray.Length; i++) {

                for (int j = 0; j < tempItemList.Count; j++) {

                    if (sortedArray[i].Equals(tempItemList[j].ItemName)) {
                        sortedItems.Add(tempItemList[j]);
                        tempItemList.RemoveAt(j);
                        break;
                    }

                }

            }

            return sortedItems;
        }

        /* METHOD : (18)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        private void TxtBoxItemPrice_KeyPress(object sender, KeyPressEventArgs e) {
            Validator.TextBox_KeyPress(sender, e);
        }
    }

}
