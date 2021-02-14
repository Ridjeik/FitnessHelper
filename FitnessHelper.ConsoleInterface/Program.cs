using FitnessHelper.UserLib.Creators.Realizations;
using FitnessHelper.UserLib.Models;
using System;

namespace FitnessHelper.ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCreator creator = new UserCreator
                (
                new StorageManipulator(new XmlUsersStorage("users.xml")),
                new ConsoleDataGetter()
                );

            Console.WriteLine("Enter user name: ");
            User user = creator.CreateUser(Console.ReadLine());

            Console.WriteLine(user);
        }
    }
}
