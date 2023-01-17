using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type a number");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 15)
            {
                Console.WriteLine("Please try again");
                Console.WriteLine("Please Type a number");
                number = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();


            }
            Console.WriteLine("Select a number for countdown:");

            int countNum = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(countNum);
                countNum--;
            }
            while (countNum > 0);
            Console.ReadLine();
        }
    }
}
