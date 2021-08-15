using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace UserManagerLibrary.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        public TestContext TestContext { get; set; }

        private UserManager manager = new UserManager();

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                "testData.xml",
                "User",
                DataAccessMethod.Sequential)]
        [TestMethod()]
        public void UserManager_Add_FromXML()
        {
            string userId = Convert.ToString(TestContext.DataRow["userid"]);
            string telephone = Convert.ToString(TestContext.DataRow["telephone"]);
            string  email = Convert.ToString(TestContext.DataRow["email"]);

            bool result = manager.Add(userId, telephone, email);

            Assert.IsTrue(result, "Пользователь не может быть создан");
        }

        
    }
}
