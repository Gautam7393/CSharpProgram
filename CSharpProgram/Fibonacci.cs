using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class Fibonacci
    {
        public static void Fibbo()
        {
            int n1 = 0, n2 = 1, n3, i, num;
            Console.WriteLine("Enter the number ");
            num=int.Parse(Console.ReadLine());
            Console.WriteLine(n1+" "+n2+" ");
                for(i=2; i<num; ++i)
                {
                    n3 = n1 + n2;
                    Console.Write(n3+"");
                    n1 = n2;
                    n2 = n3;
                }
        }
    }
}
