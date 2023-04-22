using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class Reverse
    {
        public static void ReverseNumber()
        {
            int n, rev = 0, rem;
            Console.WriteLine("Enter a Number :-");
            n=int.Parse(Console.ReadLine());

            while(n!=0)
            {
                rem = n % 10;
                rev=rev*10+rem;
                n /= 10;
            }

            Console.Write("Reversed Number:" + rev);
        }
    }
}
