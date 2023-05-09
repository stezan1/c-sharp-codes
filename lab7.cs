using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort1();
           // small_large();
            add();
            //mul();
            Console.ReadLine();
        }
        
        //wap to sort the array elements in ascending as well as descending order
        static void sort1()
        {
            int[] a = new int[5];
            Console.Write("enter value of array :");
            for(int i = 0; i < a.Length; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sorted array ");
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
             Console.WriteLine(a[i]);
            }

            Console.WriteLine("reverse array ");
            Array.Reverse(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        //wap to find the largsst and smalest element in an array
        static void small_large()
        {
            int[] a = new int[5];
            Console.Write("enter value of array :");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = a[0];
            for(int i=0;i<a.Length; i++)
            {
                if(a[i] > temp)
                {
                    temp = a[i];
                }    
            }
            Console.WriteLine(temp + " is greatest ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < temp)
                {
                    temp = a[i];
                }
            }
            
            Console.WriteLine(temp + " is smallest ");
        }

        //wap to find thw addition  between two matrices 
        static void add()
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] sum = new int[5] {0,0,0,0,0};
            int  i;
            Console.Write("enter value of 1st array :");
            for (i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("enter value of 2nd array :");
            for (i = 0; i < 5; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("the sum is :");
            for (i = 0; i < 5; i++)
            {
                
                
                    sum[i] = a[i] + b[i];
                    Console.WriteLine(sum[i]);
                
            }
           
        }
        //wap to find the multiplication between twi matricds
        static void mul()
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int[] mul = new int[5] { 0, 0, 0, 0, 0 };
            int i;
            Console.Write("enter value of 1st array :");
            for (i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("enter value of 2nd array :");
            for (i = 0; i < 5; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("the sum is :");
            for (i = 0; i < 5; i++)
            {


                mul[i] = a[i] * b[i];
                Console.WriteLine(mul[i]);

            }

        }
    

    }
}
