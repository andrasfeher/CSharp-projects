using WebService1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Collections.Generic;
using System.Threading;
using System.Security.Principal;
using System;
using System.Web.Services.Protocols;
using System.Data.SqlClient;

namespace DefectServiceTest
{
    [TestClass()]
    public class Service1Test
    {

        private TestContext testContextInstance;

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


        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void SetDefectStateTestInvalid()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("WAVEBU\\batori"), new string[] { });

            Service1 target = new Service1();
            Defect item = new Defect();
            DefectState newState = DefectState.Opened;
            Defect expected = new Defect();
            expected.SetState(newState);
            Defect actual = target.SetDefectState(item, newState);
            Assert.AreEqual(expected.State, actual.State);
        }
        [TestMethod()]
        public void SetDefectStateTestOK()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("WAVEBU\\batori"), new string[] { });

            Service1 target = new Service1();
            Defect item = new Defect();
            DefectState newState = DefectState.UnderDevelopement;
            Defect expected = new Defect();
            expected.SetState(newState);
            Defect actual = target.SetDefectState(item, newState);
            Assert.AreEqual(expected.State, actual.State);
        }

/*        [TestMethod()]
        public void SetDefectStateTestOK2()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("fejleszto"), new string[] { });

            Service1 target = new Service1();
            int Id = 8;
            Defect actual = target.GetDefect(Id);
            target.SetDefectState(actual, DefectState.Resolved);
        }*/

        [TestMethod()]
        public void GetDefectsTest()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("WAVEBU\\batori"), new string[] { });

            Service1 target = new Service1();
            List<Defect> actual = target.GetDefects();
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        public void GetDefectsTestTesztelo()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("tesztelo"), new string[] { });

            Service1 target = new Service1();
            List<Defect> actual = target.GetDefects();
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        public void GetDefectsTestFejleszto()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("fejleszto"), new string[] { });

            Service1 target = new Service1();
            List<Defect> actual = target.GetDefects();
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(SoapException))]
        public void GetDefectsTestNobody()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("nobody"), new string[] { });

            Service1 target = new Service1();
            List<Defect> actual = target.GetDefects();
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod()]
        public void GetDefectTest()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("WAVEBU\\batori"), new string[] { });

            Service1 target = new Service1();
            int Id = 8;
            Defect actual = target.GetDefect(Id);
            Assert.IsNotNull(actual);
            Assert.AreEqual("TestDefect", actual.Title);
        }

        [TestMethod()]
        public void AddDefectTest()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("WAVEBU\\batori"), new string[] { });

            Service1 target = new Service1();
            Defect item = null;
            item = new Defect();
            item.Title = "Inserted by UnitTest @ " + DateTime.Now;
            item.Description = item.Title + "\nThis item can be deleted.";
            Defect actual;
            actual = target.AddDefect(item);
            Assert.IsNotNull(actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(SoapException))]
        public void AddDefectTestNoTitle()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("WAVEBU\\batori"), new string[] { });

            Service1 target = new Service1();
            Defect item = null;
            item = new Defect();
            Defect actual;
            actual = target.AddDefect(item);
            Assert.IsNull(actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(SoapException))]
        public void AddDefectTestNobody()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("nobody"), new string[] { });

            Service1 target = new Service1();
            Defect item = null;
            item = new Defect();
            Defect actual;
            actual = target.AddDefect(item);
            Assert.IsNull(actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(SoapException))]
        public void AddDefectTestNobodyInConfig()
        {
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("nobody_in_config"), new string[] { });

            Service1 target = new Service1();
            Defect item = null;
            item = new Defect();
            Defect actual;
            actual = target.AddDefect(item);
            Assert.IsNull(actual);
        }
    }
}
