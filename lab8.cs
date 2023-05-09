using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //fibonacci series
            /* int i;
            Console.WriteLine("enter number of terms :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fibo(i));*/


            //swap();

            prime();

            //even();

            //add();

            //mul();

            //div();


            // factorial  
            /*
                        int i;
                        Console.WriteLine("enter number :");
                        i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(fact(i));
            */

            Console.ReadLine();
        }
        //wap to find the addition , multiplication ,div 
        static void add()
        {
            int a, b, sum = 0;
            Console.WriteLine("enter a and b :");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("sum is : "+sum);
        } 
        static void mul()
        {
            int a, b, sum = 0;
            Console.WriteLine("enter a and b :");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            sum = a * b;
            Console.WriteLine("mul is : "+sum);
        }
        static void div()
        {
            int a, b, sum = 0;
            Console.WriteLine("enter a and b :");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            sum = a / b;
            Console.WriteLine("div is : "+sum);
        }
        //wap to find the factorial of a number using recursion of a function 
        static int fact(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return (n * fact(n - 1));
            }
        }

        //wap to find fibonacci using recursion 
        static int fibo(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return (fibo(n - 1) + fibo(n - 2));
            }
        }
        //wap to swap to value between two numbers using function
        static void swap()
        {
            int a, b, temp;
            Console.WriteLine("enter a :");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the value before swap of a is "+a+ " and b is "+b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("the value after swap  of a is " + a + " and b is " + b);
        }
        //wap to find our the prime numbers between 1 to 100 using function and recursion function
        static void prime()
        {
            int i,j;
            bool isprime = true;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j < 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                    else
                    {
                        isprime = true;
          
                    }
                
                }
                if(isprime==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //wap to check whether the given number is odd or even using function
        static void even()
        {
            int a;
            Console.WriteLine("enter a :");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is even ");
            }
            else
            {
                Console.WriteLine(a + " is odd ");
            }
        }

    }
}
