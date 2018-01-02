using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace CourseWorkAD.ColorGenerator {

    class ColorGenerator : IEnumerable<Color> {

        private IEnumerable<int> indexGenerator;

        public ColorGenerator(IEnumerable<int> indexGenerator) {
            this.indexGenerator = indexGenerator;
        }

        public IEnumerator<Color> GetEnumerator() {
            foreach (var index in indexGenerator) {
                yield return (Color)GetColorFromIndex(index);
            }
        }

        private object GetColorFromIndex(int index) {
            byte red = (byte)(index & 0x000000FF);
            byte green = (byte)((index & 0x0000FF00) >> 08);
            byte blue = (byte)((index & 0x00FF0000) >> 16);
            return Color.FromArgb(red, green, blue);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
        
    }

}
