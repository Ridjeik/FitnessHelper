using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitnessHelper.UserLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessHelper.UserLib.Tests
{
    [TestClass()]
    public class GenderTests
    {
        [TestMethod()]
        public void GenderTest()
        {
            var name = Guid.NewGuid().ToString();
            Gender gender = new Gender(name);
            Assert.AreEqual(name, gender.Name);

            Assert.ThrowsException<ArgumentException>(() => new Gender("     "));
        }
    }
}