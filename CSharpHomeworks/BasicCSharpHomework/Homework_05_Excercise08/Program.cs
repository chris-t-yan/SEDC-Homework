using System;

namespace Homework_05_Excercise08
{
    public class Person
    {
        public string firstName, lastName;
        public int age;

        public void GetPersonStats()
        {
            Console.WriteLine($"First Name: {firstName} \nLast Name: {lastName} \nAge: {age}" );
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information
            //Call the GetPersonStats method and print the result in the console after the object is created
            
            Console.WriteLine("What's your first name");
            var firstName = Console.ReadLine();
            Console.WriteLine("What's your last name");
            var lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            
            Console.WriteLine("");

            var person = new Person();
            person.firstName = firstName;
            person.lastName = lastName;
            person.age = Convert.ToInt32(age);

            person.GetPersonStats();


            Console.ReadLine();

        }
    }
}
