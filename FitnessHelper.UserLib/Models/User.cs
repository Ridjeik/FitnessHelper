using System;

namespace FitnessHelper.UserLib.Models
{
    public class User
    {
        private string name;
        private Gender gender;
        private DateTime birthDate;
        private double weight;
        private double height;

        public string Name
        {
            get
            {
                return name; 
            }
            init 
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return gender;
            }
            init
            {
                gender = value ?? throw new ArgumentException("Gender cannot be null.");
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            init
            {
                if (value > DateTime.Now || value < DateTime.Parse("01.01.1900")) throw new ArgumentException("Incorrect birth date.");
                birthDate = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("Weight cannot be negative number.");
                weight = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("Height cannot be negitave number.");
                height = value;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - BirthDate.Year;
                if(DateTime.Now.DayOfYear < birthDate.DayOfYear) age--;
                return age;
            }
        }

        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"{Name}: [ Age: {Age}, Weight: {Weight}]";
        }
    }
}
