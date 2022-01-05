using System;
using System.Collections.Generic;

namespace ConsoleAppTest
{
    class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string name { get; set; }

            public int Age { get; set; }

            
        }
        public void method()
        {
            Console.WriteLine("hena");
        }

        public static void method2()
        {
            int a = 5;
            Console.WriteLine("hena");
        }
        public static void method3()
        {
            Console.WriteLine(a);
            Console.WriteLine("hena");
            method2();
            method();
        }
        public void Main(string[] args)
        {
            method();
            method2();
            method3();
            List<Employee> employees = new List<Employee>()
        {
            new Employee{ Id=4 , name="hema", Age=23},
            new Employee{ Id=2 , name="hema", Age=20},
            new Employee{ Id=3 , name="hema",Age=19}

        };
            foreach (var item in employees)
            {
                Console.WriteLine();
                Console.WriteLine("enter a num");
                Console.WriteLine("name is {0} and id is {1}",item.name,item.Id);
            }
            
        }

    }
}
//        class MyClass
//        {
//            class myder
//            {
//                public static void MyMethod()
//                {
//                    Console.WriteLine("This is my method");
//                }

//            }

//        }


//     public void name()
//        {
//            MyClass obj = new MyClass();
//            MyClass.MyMethod();
//        }
// static void Main(string[] args)
//       {

//            //MyClass myClass = new MyClass();
//            //myClass.MyMethod();
//           MyClass.MyMethod();

List<string> mylist = new List<string>()
        {
            "hema",
            "deep",
            "vino"
        };

List<string> list = new List<string>()
            {
                "love",
                "poor"
            };
mylist.AddRange(list);

foreach (var item in mylist)
{
    Console.WriteLine(item);
            }

//            }


//            //Console.WriteLine("Hello World!");
//        }
//  }

