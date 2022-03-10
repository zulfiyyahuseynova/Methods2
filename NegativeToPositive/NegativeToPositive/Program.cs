using System;

namespace NegativeToPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, -2, 7, -9, 5, 12, -6 };
            NegativeToPositive(ref arr);
            foreach (int num in arr)
            {
                Console.Write(num + ",");
            }

        }
        static void NegativeToPositive(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i] *= -1;
                }
            }
        }
    }
}
