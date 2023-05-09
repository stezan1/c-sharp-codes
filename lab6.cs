using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prime();
            //series();
            //fibo();
            //ser2();
            //patt1();
            patt2();
            //patt3();
            //patt4();
            Console.ReadLine();
        }
        //wap to find the prime numbers from 1 to 100
        static void prime()
        {
            int i, j;
            bool isprime = true;
            for(i=2; i <=100; i++)
            {
                for(j=2; j <= 100; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        isprime = false;
                        break;
                    }
                    else
                    {
                        isprime = true;
                    }
                }
                if(isprime)
                {
                    Console.Write("\t"+i);
                    

                }

            }
        }
        //wap to print the following series 1,3,5,7,,11,... upto nth term
        static void series()
        {
            int i,n,a=1;
            Console.WriteLine("enter n terms : ");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                Console.Write("\t"+a);
                a = a + 2;
                
            }
        }
        //wap to print fibonacci series
        static void fibo()
        {
            int a=0,b=1,c,n,i;
            Console.Write("enter series :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (i= 1; i<=n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
        //0,2,3,6,9,12,15,.... upto nth term 
        static void ser2()
        {
            int i, a=0, b=2, c=0, n;
            Console.Write("enter series :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(i= 1; i<=n; i++)
            {
                
                c = i * 3;
                Console.WriteLine(c);
            }
           
        }
        //wap to print the following pattern 
        /*      1
                12
                123
                1234
                12345
        */
        static void patt1()
        {
            int i, j;
            for(i=1;i<=5;i++)

            {
                for(j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
        /*
                1
                22
                333
                4444
                55555
        */
        static void patt2()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }

        }
        /*

                NAST 
                 AST
                  ST
                   T
        */
        static void patt3()
        {
            int i, j, l;
            string s = "NAST";
            l = s.Length;
            for (i =0; i<=l; i++)
            {
                for (j = 0; j <=i; j++)
                {
                    Console.Write(s[j]);
                }
                Console.Write("\n");
            }

        }

        /*
         
             1
        2       2
    3       3        3

        */


    }
}
