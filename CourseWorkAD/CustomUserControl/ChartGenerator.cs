using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkAD.CustomUserControl {

    public partial class ChartGenerator : UserControl {

        public ChartGenerator() {
            InitializeComponent();

            //MessageBox.Show(Convert.ToString(BillGenerator.TotalSalesCollection.Count), " Total sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitPieChart(BillGenerator.TotalSalesCollection);
        }

        internal void InitPieChart(Dictionary<string, int> totalSalesCollection) {

            ColorGenerator.ColorGenerator  colorGenerator = new ColorGenerator.ColorGenerator(System.Linq.Enumerable.Range(0, BillGenerator.TotalSalesCollection.Count));
            int index = 0;
            foreach (KeyValuePair<string, int> revenues in totalSalesCollection) {
                //GeneratePieChart(revenues.Key, revenues.Value.ToString("N"), colorGenerator.GetEnumerator().Current, index);
                clbSoldItems.Items.Add(revenues.Key, false);
                index++;
            }
                              
        }

        private void GeneratePieChart(string itemName, string revenue, Color color, int index) {


            pcRevenue.Series["revenue"].Points.Add(int.Parse(revenue, System.Globalization.NumberStyles.Currency));
            pcRevenue.Series["revenue"].Points[index].Color = color;
            pcRevenue.Series["revenue"].Points[index].LegendText = itemName;
            pcRevenue.Series["revenue"].Points[index].Label = revenue.ToString();
            pcRevenue.Series["revenue"].Points[index].ToolTip = "Total revenue of \n" + itemName + " : " + "Rs. " + revenue;

        }

        private void GPC(string itemName, int index) {
            ColorGenerator.ColorGenerator colorGenerator = new ColorGenerator.ColorGenerator(System.Linq.Enumerable.Range(0, BillGenerator.TotalSalesCollection.Count));
            string revenue = BillGenerator.TotalSalesCollection[itemName].ToString("N");

            pcRevenue.Series["revenue"].Points.Add(int.Parse(revenue, System.Globalization.NumberStyles.Currency));
            pcRevenue.Series["revenue"].Points[index].Color = colorGenerator.GetEnumerator().Current;
            pcRevenue.Series["revenue"].Points[index].LegendText = itemName;
            pcRevenue.Series["revenue"].Points[index].Label = revenue.ToString();
            pcRevenue.Series["revenue"].Points[index].ToolTip = "Total revenue of \n" + itemName + " : " + "Rs. " + revenue + "\n" + index;

        }
       
        private void CbSelectAll_CheckedChanged(object sender, EventArgs e) {
            
            for(int i = 0; i < clbSoldItems.Items.Count; i++) {

                if (cbSelectAll.Checked) {
                   
                    clbSoldItems.SetItemChecked(i, true);
                    
                } else {
                    clbSoldItems.SetItemChecked(i, false);   
                }
            }

        }

        private void ClbSoldItems_ItemCheck(object sender, ItemCheckEventArgs e) {

            if (clbSoldItems.GetItemCheckState(e.Index) == CheckState.Unchecked) {
                
                GPC(clbSoldItems.Items[e.Index].ToString(), e.Index);
                //MessageBox.Show(e.Index.ToString(), " Total sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                if (!cbSelectAll.Checked) {
                    pcRevenue.Series["revenue"].Points.Clear();
                } else {
                    pcRevenue.Series["revenue"].Points.RemoveAt(e.Index);
                }
                    
            }

        }

    }

}
