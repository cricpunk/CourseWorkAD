using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using CourseWorkAD.Model;
using CourseWorkAD.Serialization;

namespace CourseWorkAD.CustomUserControl {

    public partial class MenuItem : UserControl {

        private ComponentResourceManager resources;
        private Boolean update = false;
        private int updateIndex;
        private static List<Item> itemList;
        internal static List<Item> ItemList { get => itemList; set => itemList = value; }
        public static string dataLocation = Application.StartupPath + @"\ItemsData.dat";

        public MenuItem() {
            InitializeComponent();
            FormValidator.Validator.neumericOnlyTextBoxRate = txtBoxItemPrice;
            resources = new ComponentResourceManager(typeof(MenuItem));
            dropDownItemCategory.Items = ItemCategory();
            dropDownItemCategory.selectedIndex = 0;
            itemList = new List<Item>();
            InsertSearilizedDataIntoTable();
        }

        internal List<Item> ITEMDATA {
            get { return itemList; }
            set { itemList = value; }
        }

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

        private void BtnAddImportData_Click(object sender, EventArgs e) {

            if (txtBoxFileLocation.Text == "") {
                MessageBox.Show("There is no imported file to add into table.", " Missing file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {

                if(ProcessCSVFileData(txtBoxFileLocation.Text)) {
                    txtBoxFileLocation.ResetText();
                }  
                        
            }
            
        }

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

        private void InsertDataIntoTable(Item item) {

            int targetRow = dataGridMenu.Rows.Count - 1;
            dataGridMenu.Rows.Add();
            dataGridMenu.Rows[targetRow].Cells[0].Value = itemList.IndexOf(item) + 1;
            dataGridMenu.Rows[targetRow].Cells[1].Value = item.ItemCode;
            dataGridMenu.Rows[targetRow].Cells[2].Value = item.ItemName;
            dataGridMenu.Rows[targetRow].Cells[3].Value = item.ItemCategory;
            dataGridMenu.Rows[targetRow].Cells[4].Value = item.ItemRate;

        }

        private void InsertSearilizedDataIntoTable() {

            if (File.Exists(dataLocation)) {

                ItemsToSerialize itemsToSerialize = new ItemsToSerialize();
                itemsToSerialize = new Serializer().DeserializeItems("ItemsData.dat");

                itemList = itemsToSerialize.Items;

                for (int i = 0; i < itemList.Count; i++) {
                    InsertDataIntoTable(ItemList[i]);
                }

            }

        }

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

        private void BtnAddItem_Click(object sender, EventArgs e) {

            FormValidator.Validator.neumericOnlyTextBoxRate = txtBoxItemPrice;

            if (FormValidator.Validator.ValidateText(txtBoxItemCode) && FormValidator.Validator.ValidateText(txtBoxItemName) && FormValidator.Validator.ValidateText(txtBoxItemPrice)) {

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

        private void ClearFields() {

            txtBoxItemCode.ResetText();
            txtBoxItemName.ResetText();
            txtBoxItemPrice.ResetText();
            dropDownItemCategory.selectedIndex = 0;

        }

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

        private void BtnCancelImport_Click(object sender, EventArgs e) {
            txtBoxFileLocation.ResetText();
        }

        private void BtnAddCategoryItem_Click_1(object sender, EventArgs e) { 
            MessageBox.Show("Add Category", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}
