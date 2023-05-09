using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fact();
            //even();
           // div();
            prime();
            Console.ReadLine();
        }
        //wap to find the factorial of a given number 
        static void fact()
        {
            int num, i, fact = 1;
            Console.WriteLine("enter any number :");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of " + num + " = " + fact);
        }
        //wap to find the sum of 1st ten even numbers
        static void even()
        {
            int i, sum = 0, a = 0;
            for (i = 0; i < 5; i++)
            {
                a = a + 2;
                sum = sum + a;

            }
            Console.WriteLine("sum = " + sum);

        }
        //wap to find out perfecetly divisible by 5 or  3
        static void div()
        {
            int num;
            Console.WriteLine("enter number :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0 & num % 3 == 0)
            {
                Console.WriteLine("perfectly divisible by 3 and 5");
            }
            else if(num % 5 == 0 && num % 3 != 0)
            {
                Console.WriteLine("divisible by 5 ");
            }
            else if(num % 5 != 0 && num % 3 == 0)
            {
                Console.WriteLine("divisible by 3 ");
            }   
            else 
            {
                Console.WriteLine("not divisible by 3 or 5 ");
            }

        }
        //wap to check a number is prime or composite
        static void prime()
        {
            int num,i,j,flag=0;
            Console.WriteLine("enter any number :");
            num= Convert.ToInt32(Console.ReadLine());
            for(i= 2;i<num;i++)
            {
                if(num %i == 0)
                flag = 1;
            }
            if(flag==0)
            {
                Console.WriteLine(num + " is prime");
            }
            else
            {
                Console.WriteLine(num + " is composite");
            }
        }
    }
}
