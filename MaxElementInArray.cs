using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementInArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (n <= 0)
                {
                    throw new Exception("please enter n value greater than zero");
                }
                int[] array = new int[n];
                if (n > 1)
                {
                    Console.WriteLine("Enter elements of array....");

                    for (int i = 0; i < n; i++)
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                int max = array[0];
                for (int i = 0; i < n; i++)
                {
                    if (max < array[i])
                        max = array[i];
                }
                Console.WriteLine("Maximum element in array is " + max);
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.Write("Exception - " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
