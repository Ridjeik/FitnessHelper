using System;

namespace FitnessHelper.UserLib
{
    public class Gender
    {
        private readonly string name;

        public string Name
        {
            get
            {
                return name;
            }
            init
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("The name of gender cannot be null.");
                name = value;
            }
        }

        public Gender(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Gender: {Name}";
        }
    }
}