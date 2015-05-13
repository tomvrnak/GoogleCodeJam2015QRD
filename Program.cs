using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
//using System.

namespace GoogleQual
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            do
            {
                Console.WriteLine("Enter X(number of squares:");
                int X = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter R:(height)");
                int R = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter C:(width)");
                int C = int.Parse(Console.ReadLine());
                if ((Solve(X, R, C)) == true) Console.WriteLine("Yes, possible");
                else
                    Console.WriteLine("not possible");
                Console.WriteLine("again? y or n");
                resp = Console.ReadLine();
            } while (resp == "y");

        }


        public static bool Solve(int X, int R, int C)
        {
            if (X > 7 || (R * C) % X != 0 || X > R || X > C || R % X != 0 || C % X != 0)
                return false;
            else 
            {
                return true;
            }
        }

    }
}
