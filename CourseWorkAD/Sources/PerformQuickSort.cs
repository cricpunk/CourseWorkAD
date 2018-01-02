using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAD.Sources {

    class PerformQuickSort {

        public static int[] NumericQuickSort(int[] array, int left, int right) {

            if (left > right || left < 0 || right < 0) return null;

            int index = NumericPartition(array , left, right);

            if (index != -1) {
                NumericQuickSort(array, left, index - 1);
                NumericQuickSort(array, index + 1, right);
            }

            return array;
        }

        private static int NumericPartition(int[] array, int left, int right) {

            if (left > right) return -1;

            int end = left;

            int pivot = array[right];    // choose last one to pivot, easy to code
            for (int i = left; i < right; i++) {
                if (array[i] < pivot) {
                    NumericSwap(array, i, end);
                    end++;
                }
            }

            NumericSwap(array, end, right);

            return end;

        }

        private static void NumericSwap(int[] array, int left, int right) {
            int tmp = array[left];
            array[left] = array[right];
            array[right] = tmp;
        }

        public static IComparable[] PerformQuickSearch(IComparable[] array, int left, int right) {

            int i = left, j = right;
            IComparable pivot = array[left + (right - left) / 2];

            while (i <= j) {
                while (array[i].CompareTo(pivot) < 0) {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0) {
                    j--;
                }

                if (i <= j) {
                    // Swap
                    IComparable tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j) {
                PerformQuickSearch(array, left, j);
            }

            if (i < right) {
                PerformQuickSearch(array, i, right);
            }

            return array;

        }

    }

}
