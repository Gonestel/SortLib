using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{/// <summary>
/// Represents Insertion sort algrorithm realisation
/// </summary>
    public class Insertion : Checker, ISort
    {
        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            while (checkArr(arr))
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            for (int k = i; k > j; k--)
                            {
                                var temp = arr[k];
                                arr[k] = arr[k-1];
                                arr[k-1] = temp;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(double[] arr)
        {
            while (checkArr(arr))
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            for (int k = i; k > j; k--)
                            {
                                var temp = arr[k];
                                arr[k] = arr[k - 1];
                                arr[k - 1] = temp;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(float[] arr)
        {
            while (checkArr(arr))
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            for (int k = i; k > j; k--)
                            {
                                var temp = arr[k];
                                arr[k] = arr[k - 1];
                                arr[k - 1] = temp;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(char[] arr)
        {
            while (checkArr(arr))
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            for (int k = i; k > j; k--)
                            {
                                var temp = arr[k];
                                arr[k] = arr[k - 1];
                                arr[k - 1] = temp;
                            }
                        }
                    }
                }
            }
        }
    }
}
