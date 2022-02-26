using System;

namespace MaxSubArrayProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, -1, -1, -1, 1, 1 }; // o/p 4 (2,5)
            Console.WriteLine("Maximum SubArray Length which has product = 1 is : " + MaxSubArrayProduct.FindMaxSubArrayProductArrayLength(arr));
            Console.ReadLine();
        }
    }
}
