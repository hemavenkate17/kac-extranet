using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public partial class Car
        {
            private int modelnumber;
            private string modelname;

            public Car(int a, string b)
            {
                this.modelnumber = a;
                this.modelname = b;
            }
        }
        public partial class Car
        {
            public void Display()
            {
                Console.WriteLine("model number of the car is " + modelnumber);
                Console.WriteLine("model name of the car is " + modelname);

            }
        }

        abstract class BaseClass
        {
            public abstract int add(int a, int b);
        }

        class DerivedClass : BaseClass
        {
            public override int add(int a, int b)
            {
                return a + b;
            }
        }

        sealed class Animal
        {
            public void Movement()
            {
                Console.WriteLine("tok tok");
            }
        }

        class Printer
        {
            public virtual void Show()
            {
                Console.WriteLine("Printing printing");
            }
        }

        class Laser:Printer
        {
            public sealed override void Show()
            {
                Console.WriteLine("laser printing");
            }
        }
        static class Student
        {
            public static void work()
            {
                Console.WriteLine("work done by student");
            }
        }

        public class DataStore<T>
        {
            public T Data { get; set; }
        }

       public enum Weekdays{
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        public class School
        {
            public int ID { get; set; }
            public string Name {get; set; }
            public string branch { get; set; }

        }

        public string model;
        public Program()
        {
            model = "Ford";
        }
        
        public Program(int ID, String name)
        {
            Console.WriteLine("Student ID is {0} and Name is {1}",ID, name);
        }

        public class Office
        {
            string name;
            int Age;

            public Office(string name, int Age)
            {
                this.name = name;
                this.Age = Age;
            }

            public Office(Office office)
            {
                name = office.name;
                Age = office.Age;
                Console.WriteLine(name +  Age);
            }
        }
         void Main(string[] args)
        {
            //Console.WriteLine("shamitha");
            //List<string> mylist = new List<string>()
            //{
            //   "hema",
            //   "deep"
            //};


            
            //foreach (var item in mylist)
            //{
            //    Console.WriteLine(item);
            //}
            //Office office1 = new Office("hema",23);
            //Office office = new Office(office1);

            //Console.WriteLine("today weekday is "+ Weekdays.wednesday);
            //int day = (int)Weekdays.monday;
            //Console.WriteLine(day);
            //var wd = (Weekdays)4;
            //Console.WriteLine(wd);


            //IList<School> schools = new List<School>()
            //{
            //    new School(){ ID = 1, Name= "svu", branch="uthandi" },
            //    new School(){ ID = 2, Name= "vvu", branch="uthandi" },
            //};
            //foreach (var item in schools)
            //{
            //    Console.WriteLine(item.ID + " " + item.Name + " " + item.branch);
            //}
            //array
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] += 10;
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            ////mularray
            //int[,] mularr = new int[3, 2] { { 1, 2, }, { 4, 5 }, { 7, 8 } };

            //foreach (var item in mularr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(mularr[0, 0]);

            ////jagged array
            //int[][] Jarray = new int[2][]
            //{
            //    new int[3]{1,2,3},
            //    new int[4]{4,5,6,7}
            //};
            //for (int i = 0; i < Jarray.Length; i++)
            //{
            //    for (int j = 0; j < Jarray[i].Length; j++)
            //    {
            //        Console.WriteLine(Jarray[i][j]);
            //    }

            //}

            ////list
            //List<int> mylist = new List<int>();
            //mylist.Add(1);
            //mylist.Add(2);
            //mylist.Add(3);
            //mylist.Add(4);
            //mylist.Add(5);

            //Console.WriteLine(mylist[0]);
            //for (int i = 0; i < mylist.Count; i++)
            //{
            //    Console.WriteLine(mylist[i]);
            //}
            //mylist.Insert(1, 11); //1 index 11 element
            //mylist.Remove(1); //remove first 1
            //mylist.RemoveAt(2); // remove the 3 rd element
            //mylist.Contains(5); // returns true

            ////arraylist
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("hema");
            //arrayList.Add(true);

            //arrayList.Insert(1, "item"); // index 1 add item

            //arrayList.Remove(1); //remove first occurence
            //arrayList.RemoveAt(2); // remove with index 
            //arrayList.RemoveRange(0, 2); // remove 2 elem starts with index 0

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////dictionary
            //Dictionary<int, string> Student = new Dictionary<int, string>();
            //Student.Add(1, "hema");
            //Student.Add(2, "vino");
            //Student.Add(3, "deep");

            //Student[1] = "jaya"; //update
            //Student.Remove(3); // remove 3 rd key

            //foreach (var item in Student.Keys)
            //{
            //    Console.WriteLine("key : {0} , value : {1}", item, Student[item]);
            //}
            //foreach (KeyValuePair<int, string> kvp in Student)
            //{
            //    Console.WriteLine("key {0} Value {1} ", kvp.Key, kvp.Value);
            //}
            //for (int i = 0; i < Student.Count; i++)   //linq
            //{
            //    Console.WriteLine("key {0} Value {1} ", Student.ElementAt(i).Key, Student.ElementAt(i).Value);

            //}

            ////stack
            //Stack<int> mystack = new Stack<int>();
            //mystack.Push(1);
            //mystack.Push(2);
            //mystack.Push(3);

            //if (mystack.Count > 0)
            //{
            //    Console.WriteLine(mystack.Peek());
            //}
            //foreach (var item in mystack)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < mystack.Count; i++)
            //{
            //    Console.WriteLine(mystack.Pop() + " ");
            //}

            ////queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(100);
            //queue.Enqueue(101);
            //queue.Enqueue(102);
            //queue.Enqueue(103);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //if (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Peek());
            //}
            //for (int i = 0; i < queue.Count; i++)
            //{
            //    Console.WriteLine(queue.Dequeue() + " ");
            //}

            //Car car = new Car(100, "Ford");
            //car.Display();

            //DerivedClass derivedClass = new DerivedClass();
            //int result = derivedClass.add(4, 5);
            //Console.WriteLine("sum is " + result);

            //Animal animal = new Animal();
            //animal.Movement();

            //Printer printer = new Printer();
            //printer.Show();
            //Laser p = new Laser();
            //p.Show();

            //Student.work();

            //DataStore<string> dataStore = new DataStore<string>();

            //Console.WriteLine("enter a number");

            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int res = 100 / num;
            //    Console.WriteLine("Division result" + res);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("cannot divide by zero");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine("invalid operation");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("invalid format");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error occured");
            //}
            //finally
            //{
            //    Console.WriteLine("memory deleted");
            //}

        }
    }
}
