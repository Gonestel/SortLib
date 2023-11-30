using Sorter;

namespace TestLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            float[] ints = new float[10];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.NextSingle() * 100;
            }
            Insertion.Sort(ints);
            

            foreach (float i in ints)
            {
                Console.Write(i + " ");
            }
        }
    }
}
