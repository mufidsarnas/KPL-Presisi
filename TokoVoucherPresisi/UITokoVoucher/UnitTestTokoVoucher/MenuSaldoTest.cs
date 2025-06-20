using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestTokoVoucher
{
    public class Saldo
    {
        public decimal Amount { get; set; }

        public Saldo(decimal amount)
        {
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            if (obj is Saldo other)
            {
                return this.Amount == other.Amount;
            }
            return false;
        }

        public override int GetHashCode() => Amount.GetHashCode();
    }

    public class SaldoService
    {
        private Dictionary<string, Saldo> _customers = new Dictionary<string, Saldo>();

        public SaldoService(Saldo initialSaldo, string initialUser)
        {
            _customers[initialUser] = initialSaldo;
        }

        public void AddOrUpdateCustomerSaldo(string customerId, Saldo saldo)
        {
            _customers[customerId] = saldo;
        }

        public Saldo GetCustomerSaldo(string customerId)
        {
            _customers.TryGetValue(customerId, out var saldo);
            return saldo;
        }

        public void SetCustomerSaldo(string customerId, decimal newBalance)
        {
            if (_customers.ContainsKey(customerId))
            {
                _customers[customerId] = new Saldo(newBalance);
            }
        }
    }

    [TestClass]
    public class SaldoServiceTest
    {
        private SaldoService saldoService;

        [TestInitialize]
        public void Setup()
        {
            saldoService = new SaldoService(new Saldo(0), "mufid");
        }

        [TestMethod]
        public void TestAddOrUpdateCustomer_Tambah()
        {
            for (int i = 0; i < 100; i++)
            {
                var saldo = new Saldo(100000);
                string userId = "UserBaru_" + i;
                saldoService.AddOrUpdateCustomerSaldo(userId, saldo);

                var result = saldoService.GetCustomerSaldo(userId);
                Assert.IsNotNull(result);
                Assert.AreEqual(saldo, result);
            }
        }

        [TestMethod]
        public void TestAddOrUpdateCustomer_Update()
        {
            for (int i = 0; i < 100; i++)
            {
                var saldo = new Saldo(50000 + i);
                string userId = "mufid";
                saldoService.AddOrUpdateCustomerSaldo(userId, saldo);

                var result = saldoService.GetCustomerSaldo(userId);
                Assert.IsNotNull(result);
                Assert.AreEqual(saldo, result);
            }
        }

        [TestMethod]
        public void TestSetCustomerBalance_Sukses()
        {
            for (int i = 0; i < 100; i++)
            {
                decimal newBalance = 150000 + i;
                string userId = "mufid";
                saldoService.SetCustomerSaldo(userId, newBalance);

                var result = saldoService.GetCustomerSaldo(userId);
                Assert.IsNotNull(result);
                Assert.AreEqual(new Saldo(newBalance), result);
            }
        }

        [TestMethod]
        public void TestGetCustomerSaldo_Gagal()
        {
            for (int i = 0; i < 100; i++)
            {
                string userId = "random_" + i;
                var result = saldoService.GetCustomerSaldo(userId);
                Assert.IsNull(result);
            }
        }
    }
}
