using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person r = new Person("Rodrigo", "4.851.322-1", "01/01/1998");
            string expected = "Rodrigo";
            Assert.AreEqual(expected, r.Name);
        }

        [Test]
        public void TestID()
        {
            Person r = new Person("Rodrigo", "4.851.322-0", "01/01/1998");
            string expected = null;
            Assert.AreEqual(expected, r.ID);
        }

        [Test]
        public void TestDate()
        {
            Person r = new Person("Rodrigo", "4.851.322-0", "01/01/1998");
            string expected = "01/01/1990";
            Assert.AreEqual(expected, r.Date);
        }
    }
}