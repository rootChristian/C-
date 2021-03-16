using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    
    public class Person
    {
        // Variable
        public string lastName;
        public string firstName;
        public int age;

        // Default construttor with parameter
        public Person(string first_name, string last_name, int _age)
        {
            // Class initialization
            firstName = first_name;
            lastName = last_name;
            age = _age;
        }

        // Method print person
        public void printPerson()
        {
            Console.WriteLine("Hi, my name is " + firstName + " " + lastName + " i have " + age + " year old!");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Christ", "Kemgang", 15);
            p1.printPerson();

            Console.ReadLine();
        }
    }
}
