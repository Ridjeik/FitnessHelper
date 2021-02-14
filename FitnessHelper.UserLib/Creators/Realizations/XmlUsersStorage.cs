using FitnessHelper.UserLib.Creators.Interfaces;
using FitnessHelper.UserLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace FitnessHelper.UserLib.Creators.Realizations
{
    public class XmlUsersStorage : IUsersStorage
    {
        private string filePath;

        public string FilePath
        {
            get
            {
                return filePath;
            }
            init
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
                filePath = value;
            }
        }

        private List<User> Users { get; }

        public XmlUsersStorage(string filePath)
        {
            FilePath = filePath;
            Users = GetUsers();
        }

        public List<User> GetUsers()
        {
            if (!(Users is null)) return Users;
            List<User> result = new List<User>();
            using (FileStream fileStream = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                XDocument document;
                try
                {
                    document = XDocument.Load(fileStream);
                }
                catch
                {
                    return result;
                }

                XElement users = document.Element("users");

                if (!(users is null))
                {
                    foreach (var user in users.Elements("user"))
                    {
                        var name = user.Attribute("name").Value;
                        var gender = new Gender(user.Attribute("gender").Value);
                        var birth_date = DateTime.Parse(user.Attribute("birthDate").Value);
                        var weight = double.Parse(user.Attribute("weight").Value);
                        var height = double.Parse(user.Attribute("height").Value);

                        result.Add(new User(name, gender, birth_date, weight, height));
                    }
                }

                return result;
            }


        }

        public void SaveUser(User user)
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                XDocument document;
                try
                {
                    document = XDocument.Load(fs);
                }
                catch
                {
                    document = new XDocument();
                }

                XElement root = document.Element("users");
                if (root is null)
                {
                    root = new XElement("users");
                    document.Add(root);
                }
                var userElem = new XElement("user");
                var nameAttr = new XAttribute("name", user.Name);
                var genderAttr = new XAttribute("gender", user.Gender.Name);
                var birthDateAttr = new XAttribute("birthDate", user.BirthDate.ToShortDateString());
                var weightAttr = new XAttribute("weight", user.Weight.ToString());
                var heightAttr = new XAttribute("height", user.Height.ToString());

                userElem.Add(nameAttr, genderAttr, birthDateAttr, weightAttr, heightAttr);

                root.Add(userElem);

                fs.SetLength(0);
                document.Save(fs);
                Users.Add(user);
            }
        }
    }
}
