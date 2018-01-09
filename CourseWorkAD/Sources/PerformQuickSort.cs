using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAD.Sources {

    class PerformQuickSort {

        /* METHOD : (1)
        * ********************************************************************************************************
        * In case of wrong arguments method will return null value.
        * NumericPartition method will be called to make partation of array into two sub array using pivot.
        * NumericPartition method will return index of pivot value after partetioning array.
        * If index value is not equal to -1. (NumericPartition method will return -1 only when there is no need to perform partetion i.e. array is sorted)
        * Call NumericQuickSort method again for left side sub array by providing last index as index of pivot - 1.
        * Call NumericQuickSort method again for right side sub array by providing first index as index of pivot + 1.
        * Same process will be carried out until we got sorted array.
        * ********************************************************************************************************
        */
        public static int[] NumericQuickSort(int[] array, int left, int right) {

            // Invalid format return null
            if (left > right || left < 0 || right < 0) return null;

            // Accurate position of the pivot
            int index = NumericPartition(array , left, right);

            // If array is not sorted do this part.
            // If index return -1 that will be end of process i.e we got sorted value
            if (index != -1) {

                // Sort left side of the pivot after partetion
                NumericQuickSort(array, left, index - 1);

                // Sort right side of the pivot after partetion
                NumericQuickSort(array, index + 1, right);
            }

            return array;
        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * This method will make partetion of array into two sub array using pivot value.
        * If left index is greater then right index return -1 which means array is sorted.
        * Else, create temporary variable end and assign its value by value of left index.
        * Set value of pivot as value of the last index of array.
        * Loop through left index to right index. This loop will work until left index if less than right index.
        * Inside loop if value of array[i] is less than pivot value NumericSwap method will be called.
        * NumericSwap method will take array, loop curent value and end value as a parameter.
        * NumericSwap will swap array values of loop curent value (i.e. i) index with values of end index.
        * Whenever NumericSwap ic called from inside for loop array will be same even though swap took place. 
        * This is because pivot is in right place and it does not need to swap.
        * After swapping value increase value of end by 1.
        * If value of left index is not less than value of right index for loop will be terminate.
        * After that NumericSwap method will be called to swap value inside array.
        * At this point value hold by end is the correct index of pivot.
        * Pivot will be swapped to end index and end index value will take place of pivot position which is last index.
        * Finally value of end will be returned which will be index of the pivot. Once this process is completed 
        * we will get two sub array which will have lesser value then pivot in left side and larger value in right side.
        * ********************************************************************************************************
        */
        private static int NumericPartition(int[] array, int left, int right) {

            // If left index is larger than right index return -1
            if (left > right) return -1;

            // Temp variable end assigned by left value
            int end = left;

            // choose last one to pivot, easy to code
            int pivot = array[right];    

            // Loop through left index to right index
            for (int i = left; i < right; i++) {

                // If value is less then pivot
                if (array[i] < pivot) {

                    // Swap value of array[i] by value of array[end]
                    NumericSwap(array, i, end);
                    // Increment end value by one
                    end++;
                }
            }

            // Swap value in array
            NumericSwap(array, end, right);

            // This will be the pivot index
            return end;

        }

        /* METHOD : (3)
        * ********************************************************************************************************
        * This metho will swap value of array as per provided two index
        * ********************************************************************************************************
        */
        private static void NumericSwap(int[] array, int left, int right) {

            // Store value of array[left] into temp
            int tmp = array[left];

            // Change value of array[left] by array[right]
            array[left] = array[right];

            // Change value of array[right] by temp
            array[right] = tmp;
        }

        /* METHOD : (4)
        * ********************************************************************************************************
        * Mechanisum is same as above.
        * ********************************************************************************************************
        */
        public static IComparable[] CharacterQuickSort(IComparable[] array, int left, int right) {

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
                CharacterQuickSort(array, left, j);
            }

            if (i < right) {
                CharacterQuickSort(array, i, right);
            }

            return array;

        }

    }

}
