using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class Factorial
    {
        public static void FactorialSeries() 
        {
            int i, fact = 1, num;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            for(i=1; i<=num; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial of " + num +" is : "+ fact);
        }
    }
}
