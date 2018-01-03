using System;
using System.Windows.Forms;

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
 */

namespace CourseWorkAD.CustomUserControl {

    public partial class HomePage : UserControl {

        public HomePage() {
            InitializeComponent();
        }

    }

}
