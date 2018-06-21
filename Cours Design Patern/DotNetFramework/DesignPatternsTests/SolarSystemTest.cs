using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using SolarSystem;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SolarSystemTest
    {
        [TestMethod]
        public void ShouldContainsOnlyOneSun()
        {
            var firstSun = Sun.instance;
            var secondSun = Sun.instance;

            Check.That(firstSun).IsEqualTo(secondSun);
        }
    }
}
