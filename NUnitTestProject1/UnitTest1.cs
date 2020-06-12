using Checkpoint2;
using NUnit.Framework;


namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Employee test = new Employee("01.02.2020", "Tomas", 46);
            var ExpectedName = "Tomas";
            var ExpectedAge = 46;
            var ExpectedHireDate = "01.02.2020";
            Assert.AreEqual(test.HireDate, ExpectedHireDate);
            Assert.AreEqual(test.Age, ExpectedAge);
            Assert.AreEqual(test.Name, ExpectedName);
        }
    }
}