using ExceptionProblem;
namespace AgeMSTest
{
    [TestClass]
    public class ExceptionTestCases
    {
        [TestMethod]
        [TestCategory("Custom Exception")]
        public void GivenNullAgeTestCustomException()
        {
            int expected = 0;
            PersonAge person = new PersonAge(0);

            int actual = person.Category();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChildrenTestCustomException()
        {
            int expected = 1;
            PersonAge person = new PersonAge(20);

            int actual = person.Category();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void YouthTestCustomException()
        {
            int expected = 18;
            PersonAge person = new PersonAge(18);

            int actual = person.Category();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AdultsTestCustomException()
        {
            int expected = 45;
            PersonAge person = new PersonAge(12);

            int actual = person.Category();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SeniorsTestCustomException()
        {
            int expected = 99;
            PersonAge person = new PersonAge(19);

            int actual = person.Category();

            Assert.AreEqual(expected, actual);
        }
    }
}