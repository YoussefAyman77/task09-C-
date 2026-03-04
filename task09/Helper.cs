using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task09
{
    internal class Helper<T>
    {
        public static int SearchArray(T[] arr, T target)
        {
            for (int i = 0; i < arr?.Length; i++)
            {
                if (target.Equals(arr[i])) return i;
            }
            return -1;
        }

        public static T Max<T>(T first, T second) where T : IComparable
        {
            return first.CompareTo(second) > 0 ? first : second;
        }

        public static void ReplaceArray(T[] arr, T target, T newValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(target)) arr[i] = newValue;
            }
        }

        public static void SwapRectangle(ref Rectangle_Stru r1, ref Rectangle_Stru r2)
        {
            Rectangle_Stru temp = r1;
            r1 = r2;
            r2 = temp;
        }

        public static void ReverseArray(T[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                T temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }

        public static void SwapInd(T[] arr, int idx1, int idx2)
        {
            T temp = arr[idx1];
            arr[idx1] = arr[idx2];
            arr[idx2] = temp;
        }

        public static T ArrayMax<T>(T[] arr) where T : IComparable
        {
            T maxi = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (maxi.CompareTo(arr[i]) < 0) maxi = arr[i];
            }
            return maxi;
        }


    }
}
