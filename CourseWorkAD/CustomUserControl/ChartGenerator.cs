using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Set check list box items
 * METHOD 2 : Check list box item check event handaler
 * METHOD 3 : Generate pie chart
 * METHOD 4 : Button refrech click listener for updating pie chart.
 * ****************************************************************************************************************
 */

namespace CourseWorkAD.CustomUserControl {

    public partial class ChartGenerator : UserControl {

        private Dictionary<string, int> tempTotalSalesCollection = new Dictionary<string, int>();
        private Dictionary<string, int> totalSalesCollection = BillGenerator.TotalSalesCollection;
        public static Boolean changesInChart = false;

        // System build constructor
        public ChartGenerator() {
            InitializeComponent();  // System build method to load all components belongs to this class
            SetCheckListBoxItem();  // Set check list box at the beginning
        }

        /* METHOD : (1)
         * ********************************************************************************************************
         * Clear checkListBox items first to prevent duplication of item name.
         * Then Loop through dectionary totalSalesCollection and add items for checkListBox control.
         * ********************************************************************************************************
         */
        internal void SetCheckListBoxItem() {

            clbSoldItems.Items.Clear();
            foreach (KeyValuePair<string, int> revenues in totalSalesCollection) {
                clbSoldItems.Items.Add(revenues.Key, true);
            }

        }

        /* METHOD : (2)
         * ********************************************************************************************************
         * If CheckListBox item is checked then item name and price will be stored into temp dectionary
         * Chart points will be cleared and finally call GeneratePieChart method to create pie chart.
         * In case of uncheck remove item from temp dectionary, clear points and call GeneratePieChart method.
         * ********************************************************************************************************
         */
        private void ClbSoldItems_ItemCheck(object sender, ItemCheckEventArgs e) {

            if (clbSoldItems.GetItemCheckState(e.Index) == CheckState.Unchecked) {

                // clbSoldItems.SelectedItem.ToString(); This method cannot be called from here to get name of the item 
                //  because item is uncheck before triggering this part.
                // So we ware using below way to get item name
                string itemName = clbSoldItems.Items[e.Index].ToString();
                this.tempTotalSalesCollection.Add(itemName, totalSalesCollection[itemName]);
                pcRevenue.Series["revenue"].Points.Clear();
                GeneratePieChart();

            } else {

                tempTotalSalesCollection.Remove(clbSoldItems.SelectedItem.ToString());
                pcRevenue.Series["revenue"].Points.Clear();
                GeneratePieChart();   
                
            }

        }

        /* METHOD : (3)
         * ********************************************************************************************************
         * ColorGenerator class is used to generate random color for pie chart.
         * Loop through tempTotalSalesCollection dictionary add points to pie chart.
         * ********************************************************************************************************
         */
        private void GeneratePieChart() {
            // Creating object
            // Range has been provided from 0 to size of dectionary because we dont need more distinct color than number of items.
            ColorGenerator.ColorGenerator colorGenerator = new ColorGenerator.ColorGenerator(System.Linq.Enumerable.Range(0, totalSalesCollection.Count));
            int index = 0;  // For pie chart points index

            foreach (KeyValuePair<string, int> totalSales in tempTotalSalesCollection) {
                string itemName = totalSales.Key;
                string revenue = totalSales.Value.ToString("N");
                pcRevenue.Series["revenue"].Points.Add(int.Parse(revenue, System.Globalization.NumberStyles.Currency));
                pcRevenue.Series["revenue"].Points[index].Color = colorGenerator.GetEnumerator().Current;
                pcRevenue.Series["revenue"].Points[index].LabelForeColor = Color.Black;
                pcRevenue.Series["revenue"].Points[index].LegendText = itemName;
                pcRevenue.Series["revenue"].Points[index].Label = revenue.ToString();
                pcRevenue.Series["revenue"].Points[index].ToolTip = "Total revenue of :-\n" + itemName + " : " + "Rs. " + revenue;
                index++;
            }

        }

        /* METHOD : (4)
         * ********************************************************************************************************
         * Clear dectionary tempTotalSalesCollection and call SetCheckListBoxItem method.
         * If there is not anything to update then display message.
         * ********************************************************************************************************
         */
        private void BtnRefresh_Click(object sender, EventArgs e) {

            tempTotalSalesCollection.Clear();
            SetCheckListBoxItem();
            if(!changesInChart) {
                MessageBox.Show("Chart is alrady in updated position. \nNo new data to update.", " Update Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            changesInChart = false;

        }

    }

}
