using LAB5;
using OpenQA.Selenium;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            Driver driver = new Driver();

            int a = 5;
            int b = 5;
            string oper = "+";
            string result = "10";

            Assert.AreEqual(result, driver.Finder(a, b, oper));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Driver driver = new Driver();

            int a = 5;
            int b = 5;
            string oper = "-";
            string result = "0";

            Assert.AreEqual(result, driver.Finder(a, b, oper));
        }

        [TestMethod]
        public void TestDivision()
        {
            Driver driver = new Driver();

            int a = 5;
            int b = 5;
            string oper = "/";
            string result = "1";

            Assert.AreEqual(result, driver.Finder(a, b, oper));
        }

        [TestMethod]
        public void TestMulti()
        {
            Driver driver = new Driver();

            int a = 5;
            int b = 5;
            string oper = "*";
            string result = "25";

            Assert.AreEqual(result, driver.Finder(a, b, oper));
        }

        [TestMethod]
        public void TestIsNotNull()
        {
            Driver driver = new Driver();

            int a = 5;
            int b = 5;
            string oper = "-";

            Assert.IsNotNull(driver.Finder(a, b, oper));
        }

        [TestMethod]
        public void TestIsString()
        {
            Driver driver = new Driver();

            int a = 5;
            int b = 8;
            string oper = "+";

            Assert.IsInstanceOfType(driver.Finder(a, b, oper), typeof(string));
        }

        [TestMethod]
        public void TestContainsResult()
        {
            Driver driver = new Driver();

            int a = 2;
            int b = 5;
            string oper = "+";
            string result = "7";

            StringAssert.Contains(result, driver.Finder(a, b, oper));
        }
    }
}