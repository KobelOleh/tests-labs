using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using System;

namespace AnalaizerClassLibraryTests
{
    [TestClass]
    public class AnalaizerClassTests
    {

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "Test",
            DataAccessMethod.Sequential)]

        [TestMethod()]
        public void RunEstimateTest()
        {
            // Arrange
            string expected = Convert.ToString(TestContext.DataRow["expected"]);
            AnalaizerClass.expression = Convert.ToString(TestContext.DataRow["initial"]);

            // Actual
            string actual = AnalaizerClass.RunEstimate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}