using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkAD.FormValidator {

    class Validator {

        public static object neumericOnlyTextBoxRate;

        /* METHOD : (1)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        public static Boolean ValidateText(BunifuMaterialTextbox textBox) {

            if (textBox.Text.Trim() == "") {
                textBox.ResetText();
                textBox.HintText = "Empty field !";
                textBox.HintForeColor = Color.IndianRed;
                return false;
            } else if(textBox.Equals(neumericOnlyTextBoxRate)) {

                if(Convert.ToInt32(textBox.Text) < 1) {
                    textBox.ResetText();
                    textBox.HintText = "Invalid Number !";
                    textBox.HintForeColor = Color.IndianRed;
                    return false;
                } else {
                    return true;
                }
                
            } else {
                return true;
            }

        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        public static String ValidateDropDown(BunifuDropdown dropdown) {
            if (dropdown.selectedIndex == 0) {
                return "N.A";
            } else {
                return dropdown.selectedValue;
            }
        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        public static void TextBox_KeyPress(object sender, KeyPressEventArgs e) {

            BunifuMaterialTextbox textBox = (BunifuMaterialTextbox)sender;

            textBox.HintText = "";
            textBox.HintForeColor = Color.Silver;
            textBox.ForeColor = Color.Silver;

            //if (sender.Equals(neumericOnlyTextBoxRate) || sender.Equals(neumericOnlyTextBoxQty)) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {

                textBox.HintText = "Numeric only !";
                textBox.HintForeColor = Color.IndianRed;
                e.Handled = true;
            }

            //}

        }

    }
}
