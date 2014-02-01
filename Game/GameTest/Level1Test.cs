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

        public static Random rand
        {
            get
            {
              //  if (rand == null)
                //{
                    return new Random(int.Parse((DateTime.Now.Millisecond).ToString()));
                //}
                //return rand;
            }
            set { rand = value; }
        }
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

        [TestMethod()]
        public void HelloTest1()
        {
            string param = "My lord";
            string actual;

            string expected = "Hello, My lord!";
            actual = Level1.Hello(param);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void HelloTest4()
        {
            string param = "pavel";
            string actual;

            string expected = "Hello, Pavel.";
            actual = Level1.Hello(param);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void HelloTest2()
        {
            string param = "Igor";
            string actual;

            string expected = "Hello, Igor!";
            actual = Level1.Hello(param);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void HelloTest3()
        {
            string param = "sergei ivanovich";
            string actual;

            string expected = "Hello, Sergei Ivanovich.";
            actual = Level1.Hello(param);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void HelloTest5()
        {
            string param = "Julien";
            string actual;

            string expected = "Hello, Julien!";
            actual = Level1.Hello(param);

            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        public void TestFizzBuzz1()
        {
            int param = 1;
            string actual;

            string expected = "1";
            actual = Level1.FizzBuzzTest(param);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TestFizzBuzz2()
        {
            int param = 2;
            string actual;

            string expected = "2";
            actual = Level1.FizzBuzzTest(param);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void     TestFizzBuzz3()
        {
            Random r = new Random();
            int param = (r.Next() % 100) * 3 * 5 + 1;
            string actual;

            string expected = param.ToString();
            actual = Level1.FizzBuzzTest(param);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void TestFizzBuzz4()
        {
            int param = (rand.Next() % 100)*5 * 3 + 3 ;
            string actual;

            string expected = "Fizz";
            actual = Level1.FizzBuzzTest(param);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void TestFizzBuzz5()
        {
            int param = (rand.Next() % 100) * 3*5 + 5;
            string actual;

            string expected = "Buzz";
            actual = Level1.FizzBuzzTest(param);

            Assert.AreEqual(expected, actual);

        }

        public void TestFizzBuzz6()
        {
            int param = 5;
            string actual;

            string expected = "Buzz";
            actual = Level1.FizzBuzzTest(param);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void TestFizzBuzz7()
        {
            int param = 3;
            string actual;

            string expected = "Fizz";
            actual = Level1.FizzBuzzTest(param);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void TestReverseString()
        {
            string par1 = "abc";
            string par2 = "abc";

            string expected = "aAbBcC";
            string actual = Level1.StringReverse(par1,par2);

            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        public void TestReverseString2()
        {
            string par1 = "abc";
            string par2 = "ABC";

            string expected = "aabbcc";
            string actual = Level1.StringReverse(par1, par2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TestReverseString3()
        {
            string par1 = "abc";
            string par2 = "abcabc";

            string expected = "aAbBcCaAbBcC";
            string actual = Level1.StringReverse(par1, par2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TestReverseString4()
        {
            string par1 = "abc";
            string par2 = "xyzxyz";

            string expected = "aXbYcZaXbYcZ";
            string actual = Level1.StringReverse(par1, par2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TestReverseString5()
        {
            string par1 = "ABC";
            string par2 = "xy";

            string expected = "AXBYCX";
            string actual = Level1.StringReverse(par1, par2);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void testFreakyMethod()
        {
            string par1 = "master1master2master3master5";
            string par2 = "lamaster1lamaster2lamaster4lamaster4";

            int expected = 0;
            int actual = Level1.freakyMethod(par1, par2);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void testFreakyMethod2()
        {
            string par1 = "agfsdfg5adgadfg6adsaadsfk3k34";
            string par2 = "sdhdhdfhjdhjdjketujdfndfyhjdtjmud12";

            int expected = 18;
            int actual = Level1.freakyMethod(par1, par2);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void testFreakyMethod3()
        {
            string par1 = "11223344332211";
            string par2 = "1234123455665566";

            int expected = -32;
            int actual = Level1.freakyMethod(par1, par2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void testFreakyMethod4()
        {
            string par1 = "argagarda1arbbffbbff";
            string par2 = "4errt5";

            int expected = -8;
            int actual = Level1.freakyMethod(par1, par2);

            Assert.AreEqual(expected, actual);
        }
    }
}
