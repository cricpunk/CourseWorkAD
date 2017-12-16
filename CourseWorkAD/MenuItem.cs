using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Bunifu.Framework.UI;

namespace CourseWorkAD {

    public partial class MenuItem : UserControl {

        private ComponentResourceManager resources;
        private Boolean update = false;
        private int updateIndex;
        public static string dataLocation = Application.StartupPath + @"\ItemsData.dat";


        public MenuItem() {
            InitializeComponent();
            resources = new ComponentResourceManager(typeof(MenuItem));
            dropDownItemCategory.Items = ItemCategory();
            dropDownItemCategory.selectedIndex = 0;
            InsertIntoTable();
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
                    dataGridMenu.Rows.Clear();
                    InsertIntoTable();
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

                    File.Delete(dataLocation);

                    // List which store imported items
                    List<Item> items = new List<Item>();

                    while (!csvReader.EndOfData) {
                        // Read all fields of current line
                        string[] fieldData = csvReader.ReadFields();

                        Item item = new Item {
                            ItemCode = fieldData[0],
                            ItemName = fieldData[1],
                            ItemCategory = fieldData[2],
                            ItemRate = fieldData[3]
                        };

                        items.Add(item);
                    }

                    ItemsToSerialize itemsToSerialize = new ItemsToSerialize {
                        Items = items
                    };
                    new Serializer().SearilizeItems("ItemsData.dat", itemsToSerialize);

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

        private void InsertIntoTable() {

            if (File.Exists(dataLocation)) {

                List<Item> items = new List<Item>();
                ItemsToSerialize itemsToSerialize = new ItemsToSerialize();
                itemsToSerialize = new Serializer().DeserializeItems("ItemsData.dat");

                items = itemsToSerialize.Items;

                for (int i = 0; i < items.Count; i++) {
                    int targetRow = dataGridMenu.Rows.Count - 1;
                    dataGridMenu.Rows.Add();
                    dataGridMenu.Rows[targetRow].Cells[0].Value = targetRow + 1;
                    dataGridMenu.Rows[targetRow].Cells[1].Value = items[i].ItemCode;
                    dataGridMenu.Rows[targetRow].Cells[2].Value = items[i].ItemName;
                    dataGridMenu.Rows[targetRow].Cells[3].Value = items[i].ItemCategory;
                    dataGridMenu.Rows[targetRow].Cells[4].Value = items[i].ItemRate;
                }

            }   

        }

        private void BtnAddItem_Click(object sender, EventArgs e) {

            FormValidator.Validator.neumericOnlyTextBox = txtBoxItemPrice;

            if (FormValidator.Validator.ValidateText(txtBoxItemCode) && FormValidator.Validator.ValidateText(txtBoxItemName) && FormValidator.Validator.ValidateText(txtBoxItemPrice)) {

                if (!update) {
                    int targetRow = dataGridMenu.Rows.Count - 1;
                    dataGridMenu.Rows.Add();
                    dataGridMenu.Rows[targetRow].Cells[0].Value = targetRow + 1;
                    dataGridMenu.Rows[targetRow].Cells[1].Value = txtBoxItemCode.Text;
                    dataGridMenu.Rows[targetRow].Cells[2].Value = txtBoxItemName.Text;
                    dataGridMenu.Rows[targetRow].Cells[3].Value = FormValidator.Validator.ValidateDropDown(dropDownItemCategory);
                    dataGridMenu.Rows[targetRow].Cells[4].Value = txtBoxItemPrice.Text;
                    //itemCode = "COD" + ++targetRow;
                    //txtBoxItemCode.Text = itemCode;
                } else {
                    dataGridMenu.Rows[updateIndex].Cells[1].Value = txtBoxItemCode.Text;
                    dataGridMenu.Rows[updateIndex].Cells[2].Value = txtBoxItemName.Text;
                    dataGridMenu.Rows[updateIndex].Cells[3].Value = FormValidator.Validator.ValidateDropDown(dropDownItemCategory);
                    dataGridMenu.Rows[updateIndex].Cells[4].Value = txtBoxItemPrice.Text;

                    txtBoxItemCode.ResetText();
                    txtBoxItemName.ResetText();
                    txtBoxItemPrice.ResetText();
                    btnAddItem.ButtonText = "A D D   I T E M";
                    btnAddItem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Iconimage")));
                }

            }
            //targetRow++;

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

        private void DataGridMenu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            this.updateIndex = e.RowIndex;
            txtBoxItemCode.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[1].Value);
            txtBoxItemName.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[2].Value);
            txtBoxItemPrice.Text = Convert.ToString(dataGridMenu.Rows[updateIndex].Cells[4].Value);
            //txtBoxItemCode.Text = Convert.ToString(dataGridMenu.Rows[selectedIndex].Cells[3].Value);
            btnAddItem.Text = "U P D A T E";
            btnAddItem.Iconimage = ((Image)(resources.GetObject("btnUpdateMenuItem.Iconimage")));
            this.update = true;
        }

        private void BtnAddCategoryItem_Click_1(object sender, EventArgs e) { 
            MessageBox.Show("Add Category", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
