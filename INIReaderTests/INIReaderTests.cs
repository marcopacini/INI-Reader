using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INI;

namespace INITests
{
    [TestClass]
    public class INIReaderTest
    {
        /* Test getProperty Method */
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void getProperty_NotFoundKey_Test()
        { 
            var properties = new INIReader();
            var property = properties.getProperty("key");
        }

        /* Static Method GetProperty */
        [TestMethod]
        public void GetProperties_Test()
        {
            var filepath = "properties.ini";
            var properties = INIReader.GetProperties(filepath);

            Assert.AreEqual(properties["host"], "localhost");
            Assert.AreEqual(properties["user"], "admin");
            Assert.AreEqual(properties["password"], "qwerty");
        }
    }
}
