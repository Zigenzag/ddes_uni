using DDES_Server.Controllers;
using DDES_Server.Models;
using System.Collections.Generic;

namespace DDES_UnitTests
{
    [TestClass]
    public class ParentTests
    {
        [TestMethod]
        public void T1GetAllEmpty()
        {
            Assert.AreEqual(0, ParentController.GetAll().Count());
        }

        [TestMethod]
        public void T2AddParentValidateReturn()
        {
            Parent NewParentT2 = ParentController.Add("Test", "Two", "TestTwoUserName", "TestPassword");
            Assert.AreEqual("Test", NewParentT2.FirstName);
            Assert.AreEqual("Two", NewParentT2.LastName);
            Assert.AreEqual("TestTwoUserName", NewParentT2.UserName);
            Assert.AreEqual("TestPassword", NewParentT2.Password);
        }

        [TestMethod]
        public void T3AddParentFindParent()
        {
            Parent NewParentT3 = ParentController.Add("Test", "Three", "TestThreeUserName", "TestPassword");
            Parent? TestParentT3 = ParentController.FindByID(NewParentT3.ID);
            Assert.IsNotNull(TestParentT3);
            Assert.AreEqual(TestParentT3.FirstName, NewParentT3.FirstName);
            Assert.AreEqual(TestParentT3.LastName, NewParentT3.LastName);
            Assert.AreEqual(TestParentT3.UserName, NewParentT3.UserName);
            Assert.AreEqual(TestParentT3.Password, NewParentT3.Password);
            
        }

        [TestMethod]
        public void T4AddParentDoLogin()
        {
            Parent NewParentT4 = ParentController.Add("Test", "Four", "TestFourUserName", "TestPassword");
            Assert.IsNotNull(NewParentT4);
            Assert.AreEqual(NewParentT4.Token, ParentController.Login(NewParentT4.UserName, NewParentT4.Password));
        }
    }
}