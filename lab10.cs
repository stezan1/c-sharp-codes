using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{

    /*1 wap to create a class named student and child class student detail the parent class should have the method
        student name whereas child class should have the method name where the message should be my name is ----
*/


    public class student
    {
        public string name;
        public void student_name()
        {
            Console.WriteLine("i am student ");
        }
    }
    public class student_details : student
    {
        public void names()
        {
            Console.WriteLine("my name is  :" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student_details sd = new student_details();
            sd.student_name();
            sd.name = "chandan";
            sd.names();
            Console.ReadLine();
        }
    }

}




/* 
   2 create two mwthods in each class i.e parent and child class make sure the child can access only one method of parent class and
  another one should be in protected mode */

/*public class Parent
        {
        public void parent_method1()    //private cannot be accessed by child class
           {
            Console.WriteLine("hello i'm public method 1 of parent class");
           }
        protected void parent_method2()      //protected can be accessed by child class
           {
            Console.WriteLine("hello i'm protected method 2 of parent class");
           }
        }
    public class child : Parent     // inheritance
    {
        public void child_method1()
        {
            parent_method1();
        }
        public void child_method2()
        {
            parent_method2();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            child ch = new child();
            ch.child_method1();
            ch.child_method2();
            Console.ReadLine();
        }
    }

}*/








/*
       3 demonstarate the multilevel inheritance whre parent class is my parent and child calss are A and B but bothe the child
      class should not be of same parent
   */


















/*

using System;

namespace Inheritance
{

    // base class
    class student
    {

        public string name;

        public void display()
        {
            Console.WriteLine("I am an student");
        }

    }

    // derived class of Animal 
    class student_details : student
    {

        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            // object of derived class
            student_details sd =new student_details();

            // access field and method of base class
            sd.name = " chandan ";
            sd.display();

            // access method from own class
            sd.getName();

            Console.ReadLine();
        }

    }
}*/