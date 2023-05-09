using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area_perimeter ap=new area_perimeter();
            ap.area(5);
            ap.perimeter(5);


            be_computer bc=new be_computer();
           // bc.registration();
            //bc.exam();


            area a=new area();
            area b=new area();
          // a.circle_area(7);
          //b.circle_area(5);

            student s=new student();
            s.total_marks();
            //s.grade();



            Console.ReadLine();
        }
        



        //there is a class name becomputer where there are two methods namely exam() and registration() display the message by crating an object
        //i.e i am  registerd under be computer faculty and eliglible for examinationn 
        public class be_computer
        {
            public void exam()
            {
                Console.WriteLine(" i am  registerd under be computer faculty");
            }
            public void registration()
            {
                Console.WriteLine(" i am eligible for examination ");

            }


        }
        

        
        //find the area of a circle using the method circlearea() for two diff circle


        public class area
        {
            public void circle_area(int r)
            {
                Console.WriteLine(" area of circle : " + (3.14 * r * r));
            }
        }
    }

    //wap to find out the area and perimeter uing method getareaa and getperimeter for any square object
    public class area_perimeter
    {
        public void area(int a)
        {
            Console.WriteLine("area of square : "+a * a);
        }
        public void perimeter(int a)
        {
            Console.WriteLine("perimeter of square : "+(4*a));
        }

    }
    //demonstrate the multiple classes and multiple object alog with the required methods under class an object

   //create a class named student and create an instance of that class with two methods of a class student i.e total marks and grade .
   //find out the total marks obtained by an object as well as the grade of that object

    public class student
    {
        public void total_marks()
        {
            int math_marks,eng,sci, total=0;
            Console.WriteLine("enter marks out of 100 ");
            Console.Write("enter math marks ");
            math_marks=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter english marks ");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter science marks ");
            sci = Convert.ToInt32(Console.ReadLine());
            total = math_marks + eng + sci;
            Console.WriteLine("total = " + total);


            if (total > 280)
            {
                Console.WriteLine("A grade ");
            }
            else if (total > 250 && total < 280)
            {
                Console.WriteLine("B grade ");
            }
            else if (total > 230 && total < 250)
            {
                Console.WriteLine("C grade ");
            }
            else if (total > 200 && total < 230)
            {
                Console.WriteLine("D grade ");
            }
            else if (total > 180 && total < 200)
            {
                Console.WriteLine("E grade ");
            }
            else
            {
                Console.WriteLine("F grade ");
            }



        }

        public void grade()
        {
       
        }
    }
   

    //suppose we have two obj of a same class but pointing towards diff methods find out the individual methods for those twi obj
}
