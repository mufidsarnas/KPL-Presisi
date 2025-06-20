using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestTokoVoucher
{
    [TestClass]
    public class LoginTests
    {
        public enum Role
        {
            Admin,
            Customer
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public Role Role { get; set; }
        }

        private Dictionary<string, User> users;
        private Dictionary<string, decimal> customerSaldo;

        [TestInitialize]
        public void Setup()
        {
            users = new Dictionary<string, User>
            {
                ["admin"] = new User { Username = "admin", Password = "adminpass", Role = Role.Admin },
                ["user1"] = new User { Username = "user1", Password = "1234", Role = Role.Customer }
            };

            customerSaldo = new Dictionary<string, decimal>();
        }

        [TestMethod]
        public void LoginCustomer_Success()
        {
            string result = TryLogin("user1", "1234", out string role);
            Assert.AreEqual("Login berhasil", result);
            Assert.AreEqual("Customer", role);
            Assert.IsTrue(customerSaldo.ContainsKey("user1"));
        }

        [TestMethod]
        public void LoginAdmin_Success()
        {
            string result = TryLogin("admin", "adminpass", out string role);
            Assert.AreEqual("Login berhasil", result);
            Assert.AreEqual("Admin", role);
        }

        [TestMethod]
        public void LoginGagal_PasswordSalah()
        {
            string result = TryLogin("user1", "salah", out string role);
            Assert.AreEqual("Login gagal", result);
        }

        [TestMethod]
        public void LoginGagal_UsernameTidakAda()
        {
            string result = TryLogin("unknown", "apaaja", out string role);
            Assert.AreEqual("Login gagal", result);
        }

        private string TryLogin(string username, string password, out string role)
        {
            role = "";

            if (users.ContainsKey(username) && users[username].Password == password)
            {
                role = users[username].Role.ToString();

                if (role == "Customer" && !customerSaldo.ContainsKey(username))
                {
                    customerSaldo[username] = 0;
                }

                return "Login berhasil";
            }

            return "Login gagal";
        }
    }
}
