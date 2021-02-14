using FitnessHelper.UserLib.Creators.Interfaces;
using FitnessHelper.UserLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessHelper.UserLib.Creators.Realizations
{
    public class ConsoleDataGetter : INewUserDataGetter
    {
        public DateTime GetBirthDate()
        {
            Console.Clear();
            Console.WriteLine("Enter your birth date: ");
            string birthDateStr = Console.ReadLine();
            DateTime birthDate;

            while (!DateTime.TryParse(birthDateStr, out birthDate))
            {
                Console.Clear();
                Console.WriteLine("Incorrect birth date format!\n");
                Console.WriteLine("Enter your birth date: ");
                birthDateStr = Console.ReadLine();
            }

            return birthDate;
        }

        public Gender GetGender()
        {
            
            Console.Clear();
            Console.WriteLine("Enter your gender: ");
            string gender_name = Console.ReadLine();

            while (gender_name.Length <= 1)
            {
                Console.Clear();
                Console.WriteLine("Incorrect gender!\n");
                Console.WriteLine("Enter your gender: ");
                gender_name = Console.ReadLine();
            }

            return new Gender(gender_name);
        }

        public double GetHeight()
        {
            Console.Clear();
            Console.WriteLine("Enter your height: ");
            string heightStr = Console.ReadLine();
            double height;

            while (!double.TryParse(heightStr, out height) || height <= 0)
            {
                Console.Clear();
                Console.WriteLine("Incorrect height!\n");
                Console.WriteLine("Enter your height: ");
                heightStr = Console.ReadLine();
            }

            return height;
        }

        public double GetWeight()
        {
            Console.Clear();
            Console.WriteLine("Enter your weight: ");
            string weightStr = Console.ReadLine();
            double weight;

            while (!double.TryParse(weightStr, out weight) || weight <= 0)
            {
                Console.Clear();
                Console.WriteLine("Incorrect weight!\n");
                Console.WriteLine("Enter your weight: ");
                weightStr = Console.ReadLine();
            }

            return weight;
        }
    }
}
