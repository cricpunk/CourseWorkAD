using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkAD.FormValidator {

    class Validator {

        public static object neumericOnlyTextBoxRate;
        public static object neumericOnlyTextBoxQty;

        public static Boolean ValidateText(BunifuMaterialTextbox textBox) {

            if (textBox.Text.Trim() == "") {
                textBox.ResetText();
                textBox.HintText = "Empty field !";
                textBox.HintForeColor = Color.IndianRed;
                return false;
            } else {
                return true;
            }

        }

        public static String ValidateDropDown(BunifuDropdown dropdown) {
            if (dropdown.selectedIndex == 0) {
                return "N.A";
            } else {
                return dropdown.selectedValue;
            }
        }

        public static void TextBox_KeyPress(object sender, KeyPressEventArgs e) {

            BunifuMaterialTextbox textBox = (BunifuMaterialTextbox)sender;

            textBox.HintText = "";
            textBox.HintForeColor = Color.Silver;
            textBox.ForeColor = Color.Silver;

            if (sender.Equals(neumericOnlyTextBoxRate) || sender.Equals(neumericOnlyTextBoxQty)) {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {

                    textBox.HintText = "Numeric only !";
                    textBox.HintForeColor = Color.IndianRed;
                    e.Handled = true;
                }

            }

        }
    }
}
