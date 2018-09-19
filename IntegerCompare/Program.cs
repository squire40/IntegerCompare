using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first 3 digit integer");
            var int1 = Console.ReadLine();
            while (!IsThreeDigitInt(int1))
            {
                Console.WriteLine("Please enter a 3 digit integer: ");
                int1 = Console.ReadLine();
            }
            Console.WriteLine("Enter second 3 digit integer");
            var int2 = Console.ReadLine();
            while (!IsThreeDigitInt(int2))
            {
                Console.WriteLine("Please enter a 3 digit integer: ");
                int2 = Console.ReadLine();
            }

            var totals = new List<int>();

            for (int i = 0; i < int1.Length; i++)
            {
                totals.Add(int.Parse(int1[i].ToString()) + int.Parse(int2[i].ToString()));
            }

            var resposne = totals[0] == totals[1] && totals[1] == totals[2] ? "True" : "False";

            Console.WriteLine(resposne);
            Console.ReadLine();
        }

        private static bool IsThreeDigitInt(string input)
        {
            int result;
            return int.TryParse(input, out result) && input.Length == 3;
        }
    }
}
