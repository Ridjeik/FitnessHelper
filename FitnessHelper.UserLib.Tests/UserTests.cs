using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FitnessHelper.UserLib.Models;

namespace FitnessHelper.UserLib.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void UserTest()
        {
            var name = Guid.NewGuid().ToString();
            var gender = new Gender(Guid.NewGuid().ToString());
            var birthDate = DateTime.Parse("22.07.2004");
            var weight = 20.5;
            var height = 212;

            var user = new User(name, gender, birthDate, weight, height);

            Assert.AreEqual(name, user.Name);
            Assert.AreSame(gender, user.Gender);
            Assert.AreEqual(birthDate, user.BirthDate);
            Assert.AreEqual(weight, user.Weight);
            Assert.AreEqual(height, user.Height);
            Assert.AreEqual(16, user.Age);

            Assert.ThrowsException<ArgumentException>(() => new User("   ", gender, birthDate, weight, height));
            Assert.ThrowsException<ArgumentException>(() => new User(name, null, birthDate, weight, height));
            Assert.ThrowsException<ArgumentException>(() => new User(name, gender, DateTime.Parse("22.07.2300"), weight, height));
            Assert.ThrowsException<ArgumentException>(() => new User(name, gender, birthDate, -5, height));
            Assert.ThrowsException<ArgumentException>(() => new User(name, gender, birthDate, weight, -20));
        }
    }
}