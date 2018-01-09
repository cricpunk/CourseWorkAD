using Bunifu.Framework.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Validate text box
 * METHOD 2 : Validate dropdown
 * METHOD 3 : Key press event for textbox
 * ****************************************************************************************************************
 */

namespace CourseWorkAD.FormValidator {

    class Validator {

        //While setting validation rules for textbox which only support numeric number this field will be set from that class.
        public static object neumericOnlyTextBoxRate;

        /* METHOD : (1)
        * ********************************************************************************************************
        * This method will validate textbox weather it is empty or not. In case of empty value textbox hint will be set as empty field with red colour. 
        * If textbox only support numeric values this method will restrict user from providing value less than 1. 
        * For invalid cases method will return false else return true.
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
        * If user proceed without selecting any value from dropdown list then, select value of dropdown will by default set as other.
        * If nothing is selected return string value other else return selected value.
        * ********************************************************************************************************
        */
        public static String ValidateDropDown(BunifuDropdown dropdown) {
            if (dropdown.selectedIndex == 0) {
                return "Other";
            } else {
                return dropdown.selectedValue;
            }
        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * This method will handle key press event for textbox. 
        * This method will prevent users from inserting values other then numeric one in the textbox.
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
