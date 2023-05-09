using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calc();
            grade();
            Console.ReadLine();
        }

        //wap to find out sum ,div,mul,power and subtraction of any two numbers using switch case statement
        static void calc()
        {
            double sum, sub, mul, div, pow, a, b, choice;
            Console.WriteLine("enter a and b :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n1.sum\n2.sub\n3.mul\n4.div\n5.power\n");
            Console.WriteLine("enter ur choice :");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    sum = a + b;
                    Console.WriteLine("sum = " + sum);
                    break;
                case 2:
                    sub = a - b;
                    Console.WriteLine("sub = " + sub);
                    break;
                case 3:
                    mul = a * b;
                    Console.WriteLine("mul = " + mul);
                    break;
                case 4:
                    div = a / b;
                    Console.WriteLine("div = " + div);
                    break;
                case 5:
                    pow = Math.Pow(a, b);
                    Console.WriteLine("power = " + pow);
                    break;
                default:
                    Console.WriteLine("enter valid choice ");
                    break;
            }


        }
        //wap to find out the grade from a to f using switch case statement. assume the suitable condition or cases for the mentiones grade
        static void grade()
        {
            double grade;
            char choice;
            Console.Write("enter grade :");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nA \nB \nC \nD \nE \nF \n");
            Console.WriteLine("enter ur choice :");
            choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'A':
                        Console.WriteLine("Outstading");
                    break;
                case 'B':
                        Console.WriteLine("Excellent");
                    break;
                case 'C':
                        Console.WriteLine("Good");
                    break;
                case 'D':
                        Console.WriteLine("Fair");
                    break;
                case 'E':
                        Console.WriteLine("Need Improvement");
                    break;
                case 'F':
                        Console.WriteLine("Try Again");
                    break;

            }
        }
    }
}   
