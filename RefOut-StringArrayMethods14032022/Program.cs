using System;

namespace RefOut_StringArrayMethods14032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, -4, 2, -5, 0, -3 };

            Console.WriteLine("Arrayimizin ilk hali");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(" \n Arrayimizin son hali");
            BePositive(ref arr); 
        }

        static void BePositive(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
