using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    public class Person
    {
        // Variable
        private string lastName;
        private string firstName;
        private int age;
        private string address;

        // Empty Default construttor
        public Person()
        {
            age = 20;
        }

        // Default construttor with parameter
        public Person(string first_name, string last_name, int _age, string _address)
        {
            // Class initialization
            firstName = first_name;
            lastName = last_name;
            age = _age;
            address = _address;
        }

        // Method get and set 
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Method get and set 
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Method get and set 
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Method get and set 
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Method print person
        public void printPerson()
        {
            //Console.WriteLine("Hi, my name is " + firstName + " " + lastName + ", i have " + age + " year old and i leave on the street " + address + "...");
            Console.WriteLine(string.Format("Hi, my name is  {0} {1}, i have {2} year old and i leave on the street {3}...", firstName, lastName, age, Address));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Christ", "KEMGANG", 15, "10 settember, 43125 PR");
            Person p3 = new Person();

            p1.FirstName = "Pippo";
            p1.LastName = "PLUTO";
            p1.Address = "17 november, 43126 PR";
            Console.Write("Welcome, please enter your first name? ");
            p3.FirstName = Console.ReadLine();
            Console.Write("please enter your last name? ");
            p3.LastName = Console.ReadLine();
            Console.Write("please enter your age? ");
            p3.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your address? ");
            p3.Address = Console.ReadLine();

            p3.printPerson();
            p1.printPerson();
            p2.printPerson();
            p2.FirstName = "Christian";
            p2.printPerson();

            Console.ReadLine();
        }
    }
}
