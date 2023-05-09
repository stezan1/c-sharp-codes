using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1stprog
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //math();
            odd_even();
            Console.ReadLine();
        }
       
     
            //wap to find out the sum diff mul div or two numbers
        static void math()            {
                int a, b,mul,div,sub,sum;
                Console.WriteLine(" enter a and b :");
                a=Convert.ToInt32(Console.ReadLine());    
                b=Convert.ToInt32(Console.ReadLine());
                sum = a + b;
                mul = a * b;
                sub = a - b;
                div = a / b;
                Console.WriteLine("sum of " + a + " and " + b+" = " + sum);
                Console.WriteLine("multiplication of " + a + " and " + b+" = " + mul);
                Console.WriteLine("substraction of " + a + " and " + b+" = " + sub);
                Console.WriteLine("division of " + a + " and " + b+" = " + div);
            }
        //wap to find number is odd or even
        static void odd_even()
        {
            int a;
            Console.WriteLine("enter any number :");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is even");
            }
            else
                Console.WriteLine(a + " is odd");
            }
        }
}

