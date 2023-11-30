using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    public abstract class Checker
    {
        internal static bool checkArr(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool checkArr(float[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool checkArr(double[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return true;
                }
            }
            return false;
        }

        internal static bool checkArr(char[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
