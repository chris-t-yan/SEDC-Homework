using System;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //userNames = ["user1", "user2", "user3"]
            //passwords = ["first", "second", "third"]
            //Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password.


            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".

            while (true)
            {
                string[] userNames = new string[] { "user1", "user2", "user3" };
                string[] passwords = new string[] { "first", "second", "third" };

                Console.WriteLine("Please enter username");
                string userName = Console.ReadLine();
                int indexUsername = Array.IndexOf(userNames, userName);

                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                int indexPassword = Array.IndexOf(passwords, password);

                if (indexUsername != -1 & indexPassword != -1 & indexPassword == indexUsername)
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password!");
                    continue;
                }
            }
        }
    }
}
