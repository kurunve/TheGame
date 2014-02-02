using Game.Levels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameTest
{
    
    
    /// <summary>
    ///This is a test class for Level2Test and is intended
    ///to contain all Level2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Level2Test
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


        [TestMethod()]
        public void Level2FirstTest1()
        {
            String testName = "My Name";
            int quality = 22;
            Level2.CoolBuilder builder = new Level2.CoolBuilder();
            Level2.IMyCoolInferface testImplementation = builder.setName(testName).setQuality(quality).build();
            Assert.AreEqual(testName,testImplementation.getName());
            Assert.IsTrue(testImplementation.getDescription().Contains("Name: " + testName));
            Assert.IsTrue(testImplementation.getDescription().Contains("Quality: " + quality));
            testImplementation.increaseQuality();
            Assert.AreNotEqual(quality,testImplementation.getQuality());
        }

        [TestMethod()]
        public void Level2FirstTest2()
        {
            String testName = "some name";
            Level2.CoolBuilder builder = new Level2.CoolBuilder();
            Level2.IMyCoolInferface testImplementation = builder.setName(testName).build();
            Assert.AreEqual(testName, testImplementation.getName());
            Assert.IsTrue(testImplementation.getDescription().Contains("Name: Some Name"));
            Assert.IsTrue(testImplementation.getDescription().Contains("Quality: 0"));
            testImplementation.increaseQuality();
            Assert.AreNotEqual(0, testImplementation.getQuality());
        }

        [TestMethod()]
        public void Level2FirstTest3()
        {

            Level2.CoolBuilder builder = new Level2.CoolBuilder();
            try
            {
                Level2.IMyCoolInferface testImplementation = builder.build();
            }
            catch(Level2.MissingNameException ex)
            {
                Assert.IsTrue(ex.Message.Contains("Name should be specified"));
                return;
            }
            Assert.Fail("Exception should be thrown");
            

        }
    }
}
