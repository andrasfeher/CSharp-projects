using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerTest
{
    
    
    /// <summary>
    ///This is a test class for CustomerTest and is intended
    ///to contain all CustomerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomerTest
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
        ///A test for Pay
        ///</summary>
        [TestMethod()]
        public void PayTest_OK()
        {
            Customer target = new Customer(); // TODO: Initialize to an appropriate value
            target.AccountBalance = 110;
            target.Pay(10);
            Assert.AreEqual(120, target.AccountBalance);
        }

        /// <summary>
        ///A test for Pay
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PayTest_ERROR()
        {
            Customer target = new Customer(); // TODO: Initialize to an appropriate value
            target.AccountBalance = 110;
            target.Pay(-10);
            
        }

        /// <summary>
        ///A test for Charge
        ///</summary>
        [TestMethod()]
        public void ChargeTest_OK()
        {
            Customer target = new Customer(); // TODO: Initialize to an appropriate value
            target.AccountBalance = 100;
            target.Charge(10);
            Assert.AreEqual(90, target.AccountBalance);
        }

        /// <summary>
        ///A test for Customer Constructor
        ///</summary>
        [TestMethod()]
        public void CustomerConstructorTest_OK()
        {
            Customer target = new Customer();
            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void AddCustomerTest_OK()
        {
            CustomerGroup a = new CustomerGroup();
            CustomerGroup b = new CustomerGroup();
            Customer c = new Customer(Guid.NewGuid());

            a.AddCustomer(c);
            Assert.AreEqual(a, c.Group, "a.equal");
            Assert.AreNotEqual(b, c.Group, "b.equal");
            CollectionAssert.Contains(a.Customers, c, "a.contains");
            CollectionAssert.DoesNotContain(b.Customers, c, "a.notcontains"); 

            b.AddCustomer(c);
            Assert.AreNotEqual(a, c.Group);
            Assert.AreEqual(b, c.Group);
            CollectionAssert.DoesNotContain(a.Customers, c);
            CollectionAssert.Contains(b.Customers, c);

            a.AddCustomer(c);
            Assert.AreEqual(a, c.Group);
            Assert.AreNotEqual(b, c.Group);
            CollectionAssert.Contains(a.Customers, c);
            CollectionAssert.DoesNotContain(b.Customers, c);
        
        
        }




    }
}
