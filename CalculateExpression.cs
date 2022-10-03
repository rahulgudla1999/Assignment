using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            try
            {
                Console.WriteLine("The value is " + p.FindX(7, 1).ToString());
                Console.ReadKey();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero is not possible " + ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot get the value.. some wierd occured " + ex.Message);
                Console.ReadKey();
            }
        }

        public double FindX(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)Math.Sqrt((3 * a) + 1) / b;
        }
    }
}
