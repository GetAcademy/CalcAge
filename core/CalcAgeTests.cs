using NUnit.Framework;

namespace core
{
    [TestFixture]
    public class CalcAgeTests
    {
        [Test]
        public void returnCurrentAgeTest()
        {

            var calcAge = new CalcAge(1994);
            bool hadBirthday = false;


            var result = calcAge.returnCurrentAge(
                hadBirthday);


            Assert.That(result, Is.EqualTo(31));
        }

        [Test]
        public void calculateAgeTest()
        {
            var calcAge = new CalcAge(1994);
            var result = calcAge.calculateAge();


            Assert.That(result, Is.EqualTo(32));
        }
    }
}
