using System;

namespace MinMaxElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 54, -12, 5, 0, -24, 19 };
            Swap(arr);
            foreach (int num in arr)
            {
                Console.Write(num + ",");
            }
        }
        static void Swap(int[] arr)
        {
            int min = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<arr[min])
                {
                    min = i;
                }
                if (arr[i]>arr[max])
                {
                    max = i;
                }
            }
            arr[min] = arr[max] + arr[min];
            arr[max] = arr[min] - arr[max];
            arr[min] = arr[min] - arr[max];
        }
    }
}
