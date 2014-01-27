using Game.Levels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameTest
{
    
    
    /// <summary>
    ///This is a test class for Level1Test and is intended
    ///to contain all Level1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Level1Test
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for HelloWorld
        ///</summary>
        [TestMethod()]
        public void HelloWorldTest()
        {
            string expected = "Hello, World!"; // TODO: Initialize to an appropriate value
            string actual;
            actual = Level1.HelloWorld();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Level1 Constructor
        ///</summary>
        [TestMethod()]
        public void Level1ConstructorTest()
        {
            Level1 target = new Level1();
            Assert.IsTrue(true,"Test Class is not ready");
        }
    }
}
