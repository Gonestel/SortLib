using Sorter;

namespace TestLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double[] ints = new double[10];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.NextDouble() * 100;
            }
            Insertion.Sort(ints);
            

            foreach (double i in ints)
            {
                Console.Write(i + " ");
            }
        }
    }
}
