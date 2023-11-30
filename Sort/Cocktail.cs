using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{/// <summary>
/// Represents Cocktail sort algrorithm realisation
/// </summary>
    public class Cocktail: Checker, ISort
    {
        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            int minEdge = 0;
            int maxEdge = arr.Length;
            while (minEdge < maxEdge)
            {
                for (int i = minEdge; i < maxEdge - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                maxEdge--;

                for (int i = maxEdge - 1; i > minEdge; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                minEdge++;
            }
        }

        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(double[] arr)
        {
            int minEdge = 0;
            int maxEdge = arr.Length;
            while (minEdge < maxEdge)
            {
                for (int i = minEdge; i < maxEdge - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                maxEdge--;

                for (int i = maxEdge - 1; i > minEdge; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                minEdge++;
            }
        }

        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(float[] arr)
        {
            int minEdge = 0;
            int maxEdge = arr.Length;
            while (minEdge < maxEdge)
            {
                for (int i = minEdge; i < maxEdge - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                maxEdge--;

                for (int i = maxEdge - 1; i > minEdge; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                minEdge++;
            }
        }

        /// <summary>
        /// Executes sort algorithm
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(char[] arr)
        {

            int minEdge = 0;
            int maxEdge = arr.Length;
            while (minEdge < maxEdge)
            {
                for (int i = minEdge; i < maxEdge - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        var temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                maxEdge--;

                for (int i = maxEdge - 1; i > minEdge; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                minEdge++;
            }
        }
    }
}
