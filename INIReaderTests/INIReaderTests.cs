using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using INI;

namespace INITests
{
    [TestClass]
    public class INIReaderTest
    {
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
