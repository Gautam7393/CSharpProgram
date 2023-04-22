using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class Sum_Of_Digit
    {
        public static void Sum_Of_Digit_Number()
        {
            int n, sum = 0, m;
            Console.WriteLine("Enter the number by User = ");
            n=int.Parse(Console.ReadLine());

            while(n > 0)
            {
                m=n%10;
                sum=sum+m;
                n=n/10;
            }

            Console.Write("Sum is = " + sum);
        }
    }
}
