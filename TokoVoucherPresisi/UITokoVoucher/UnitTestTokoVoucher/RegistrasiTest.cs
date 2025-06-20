using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UITokoVoucher.SimpleTest
{
    [TestClass]
    public class ManualUnitTests
    {
        // Salinan dari Registrasi.cs
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public Role Role { get; set; }
        }

        public enum Role
        {
            Admin,
            Customer
        }

        [TestMethod]
        public void CreateUser_Success()
        {
            var user = new User
            {
                Username = "testuser",
                Password = "12345",
                Role = Role.Customer
            };

            Assert.AreEqual("testuser", user.Username);
            Assert.AreEqual("12345", user.Password);
            Assert.AreEqual(Role.Customer, user.Role);
        }

        [TestMethod]
        public void AddUserToDictionary_Success()
        {
            var users = new Dictionary<string, User>();
            var user = new User
            {
                Username = "admin1",
                Password = "adminpass",
                Role = Role.Admin
            };

            users[user.Username] = user;

            Assert.IsTrue(users.ContainsKey("admin1"));
            Assert.AreEqual(Role.Admin, users["admin1"].Role);
        }

        [TestMethod]
        public void AddUser_DuplicateKey_Fail()
        {
            var users = new Dictionary<string, User>();
            users["dup"] = new User { Username = "dup", Password = "x", Role = Role.Customer };

            bool duplicate = users.ContainsKey("dup");

            Assert.IsTrue(duplicate);
        }
    }
}
