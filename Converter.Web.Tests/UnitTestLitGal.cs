using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter.Business.Class;

namespace Converter.Web.Tests
{
    /// <summary>
    /// Summary description for UnitTestLitGal
    /// </summary>
    [TestClass]
    public class UnitTestLitGal
    {
        public UnitTestLitGal()
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
        public void TestLit2Gal()
        {
            //
            // TODO: Add test logic here
            //
            Liters2Gallons litgal = new Liters2Gallons();

            //Act
            double actual = litgal.Convert('l', 25.7777);
            double actualrounded = Math.Round(actual, 2);
            double expectedrounded = 6.81;

            //Assert
            Assert.AreEqual(expectedrounded, actualrounded);
        }
    }
}
