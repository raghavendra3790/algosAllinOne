using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch
{
    public class Sort<T> where T : IComparable
    {
        public static void SelectionSort(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for(int j = i+1;j < array.Length;j++)
                {
                    if(Less(array[j], array[minIndex]))
                        minIndex = j;
                }

                Swap(array, minIndex, i);
            }
        }

        public static void InsertionSort(T[] array)
        {
            for(int i = 0;i < array.Length;i++)
            {
                for(int j = i;j > 0;j--)
                {
                    if (Less(array[j], array[j - 1]))
                        Swap(array, j, j - 1);
                }
            }
        }

        public static void MergeSort(T[] array)
        {
            T[] aux = new T[array.Length];
            MergeSort(array, aux, 0, array.Length - 1);
        }

        private static void MergeSort(T[] array, T[] aux, int lo, int hi)
        {
            if (hi <= lo) return;
            int mid = (hi + lo) / 2;
            MergeSort(array, aux, lo, mid);
            MergeSort(array, aux, mid + 1, hi);
            Merge(array, aux, lo, mid, hi);
        }

        private static void Merge(T[] array, T[] aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
                aux[k] = array[k];

            int i = lo;
            int j = mid+1;
            for(int k = lo;k <= hi;k++)
            {
                if (j > hi) array[k] = aux[i++];
                else if (i > mid) array[k] = aux[j++];
                else if (Less(aux[i], aux[j])) array[k] = aux[i++];
                else array[k] = aux[j++];
            }
        }

        public static void QuickSort(T[] array)
        {
        }

        private static int Partition(T[] array, int lo, int hi)
        {
            int i = lo + 1;
            int j = hi;

            while(true)
            {

            }
        }
        private static bool Less(T elem1, T elem2)
        {
            int compare = elem1.CompareTo(elem2);
            return compare <= 0 ? true : false;
        }

        private static void Swap(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
