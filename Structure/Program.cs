using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        struct Person
        {
            public string firstName;
            public int age;
        } 

        static void Main(string[] args)
        {
// assignment by value

            /*
            Person p = new Person();
            p.firstName = "Ivan";
            p.age = 28;

            Console.WriteLine("The person is: {0}. Hi is {1} years old.", p.firstName, p.age);
            */

//assignment of array values

            const int size = 2;
            Person[] persons = new Person[size];

            persons[0].firstName = "Ivan";
            persons[0].age = 28;

            persons[1].firstName = "Slavon";
            persons[1].age = 27;

            // foreach (Person p in persons) Console.WriteLine("The person is: {0}, the age is: {1}.", p.firstName, p.age);

            string[] head= { "Name", "Age" };

            foreach (string h in head) Console.Write(h + "\t\t");

            Console.WriteLine();

            foreach (Person p in persons) Console.WriteLine(p.firstName + "\t\t" + p.age);


            Console.ReadLine();
        }
    }
}
