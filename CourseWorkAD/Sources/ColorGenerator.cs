using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace CourseWorkAD.ColorGenerator {

    class ColorGenerator : IEnumerable<Color> {

        // Creating object of IEnumerable which is integer type
        private IEnumerable<int> indexGenerator;

        /* METHOD : (1)
        * ********************************************************************************************************
        * Constructor initializing indexGenerator
        * ********************************************************************************************************
        */
        public ColorGenerator(IEnumerable<int> indexGenerator) {
            this.indexGenerator = indexGenerator;
        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * Loop through index collection and call GetColorFromIndex method to generate distinct color.
        * ********************************************************************************************************
        */
        public IEnumerator<Color> GetEnumerator() {
            foreach (var index in indexGenerator) {
                yield return (Color)GetColorFromIndex(index);
            }
        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * Create colour using index value and color combination.
        * ********************************************************************************************************
        */
        private object GetColorFromIndex(int index) {
            byte red = (byte)(index & 0x000000FF);
            byte green = (byte)((index & 0x0000FF00) >> 08);
            byte blue = (byte)((index & 0x00FF0000) >> 16);
            return Color.FromArgb(red, green, blue);
        }

        /* METHOD : (4)
        * ********************************************************************************************************
        * This method should be compulsory implemente while using IEnumerable<> Interface
        * Method called GetEnumerator along with interface IEnumerator which helps to get current element from the collection.
        * ********************************************************************************************************
        */
        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
        
    }

}
