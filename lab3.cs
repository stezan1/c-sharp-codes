using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //pal();
            //vow();
            arm();
            Console.ReadLine();
        }
        //wap to check whiven number is palindrome or not
        static void pal()
        {
            int a,rev=0,temp,sum;
            Console.WriteLine(" enter a number :");
            a=Convert.ToInt32(Console.ReadLine());
            temp = a;
            while(a!=0)
            {
                sum = a % 10;
                rev = rev * 10 + sum;
                a = a / 10;
            }
            if(rev==temp)
            {
                Console.WriteLine(temp + " is pallindrome ");
            }
            else
            {
                Console.WriteLine(temp + " is not pallindrome");
            }
        }
        //wap to chech whether the entered charecter is vowel or consonant
        static void vow()
        {
            char a;
            Console.WriteLine(" enter a character : ");
            a=Convert.ToChar(Console.ReadLine());
            if(a=='A' || a=='E'|| a == 'I' || a == 'O' ||a == 'U'|| a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                Console.WriteLine(a + " is vowel ");
            }
            else
            {
                Console.WriteLine(a + " is consonant ");
            }
        }
        //wap to check whether the given number is armstrong or not
        static void arm()
        {
            int a, temp, rev=0, dig;
            Console.WriteLine("enter number : ");
            a = int.Parse(Console.ReadLine());
            temp = a;
            while (a != 0)
            {
                dig = a % 10;
                rev = rev + dig * dig * dig;
                a = a / 10;
            }
            if (rev == temp)
            {
                Console.WriteLine(temp + " is armstrong ");
            }
            else
            {
                Console.WriteLine(temp + " is not armstrong");
            }

        }
    }
}
