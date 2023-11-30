namespace Sorter
{
/// <summary>
/// Represents Bubble sort algrorithm realisation
/// </summary>
    public class Bubble : Checker, ISort
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
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
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
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
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
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
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
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
            }
        }
    }
}
