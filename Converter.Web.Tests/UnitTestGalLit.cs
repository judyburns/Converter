using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter.Business.Class;

namespace Converter.Web.Tests
{
    /// <summary>
    /// Summary description for UnitTestGalLit
    /// </summary>
    [TestClass]
    public class UnitTestGalLit
    {
        public UnitTestGalLit()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestGal2Lit()
        {
            //
            // TODO: Add test logic here
            //
            Liters2Gallons gallit = new Liters2Gallons();

            //Act
            double actual = gallit.Convert('g', 55.7777);
            double actualrounded = Math.Round(actual, 2);
            double expectedrounded = 211.14;

            //Assert
            Assert.AreEqual(expectedrounded, actualrounded);
        }
    }
}
