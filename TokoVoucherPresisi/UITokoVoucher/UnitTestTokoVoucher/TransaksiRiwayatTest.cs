using System.Text.Json;
using TransactionLibrary;
using TransaksiLibrary;

namespace UnitTestTokoVoucher
{
    [TestClass]
    public sealed class TransaksiRiwayatTest
    {
        //Testing JSON + Library
        private string testFilePath;
        private TransactionService transactionService;

        [TestInitialize]
        public void TestInitialize()
        {
            testFilePath = $"test_transactions_{Guid.NewGuid()}.json";
            transactionService = new TransactionService(testFilePath);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }

        [TestMethod]
        public void AddMultipleTransactions()
        {
            // Arrange
            const int count = 100;
            string baseUsername = "user";
            string baseVoucherName = "Voucher";

            // Act
            for (int i = 0; i < count; i++)
            {
                transactionService.Add(
                    $"{baseUsername}{i}",
                    $"{baseVoucherName}{i}",
                    i + 1,
                    (i + 1) * 10000);
            }

            // Assert
            var allTransactions = transactionService.GetAll().ToList();
            Assert.AreEqual(count, allTransactions.Count);

            for (int i = 0; i < count; i++)
            {
                var transaction = allTransactions[i];
                Assert.AreEqual($"{baseUsername}{i}", transaction.Username);
                Assert.AreEqual($"{baseVoucherName}{i}", transaction.VoucherName);
                Assert.AreEqual(i + 1, transaction.Quantity);
                Assert.AreEqual((i + 1) * 10000, transaction.TotalPrice);
            }
        }

        [TestMethod]
        public void LoadTransactionHistory()
        {
            // Arrange
            const int count = 100;
            var testTransactions = new List<TransaksiModel>();
            string baseUsername = "user";
            string baseVoucherName = "Voucher";

            for (int i = 0; i < count; i++)
            {
                testTransactions.Add(new TransaksiModel
                {
                    Username = $"{baseUsername}{i}",
                    VoucherName = $"{baseVoucherName}{i}",
                    Quantity = i + 1,
                    TotalPrice = (i + 1) * 10000,
                    TransactionDate = DateTime.Now.AddMinutes(-i)
                });
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(testTransactions, options);
            File.WriteAllText(testFilePath, jsonString);

            // Act
            var newService = new TransactionService(testFilePath);

            // Assert
            var loadedTransactions = newService.GetAll().ToList();
            Assert.AreEqual(count, loadedTransactions.Count);

            for (int i = 0; i < count; i++)
            {
                var expected = testTransactions[i];
                var actual = loadedTransactions[i];

                Assert.AreEqual(expected.Username, actual.Username);
                Assert.AreEqual(expected.VoucherName, actual.VoucherName);
                Assert.AreEqual(expected.Quantity, actual.Quantity);
                Assert.AreEqual(expected.TotalPrice, actual.TotalPrice);
                Assert.AreEqual(expected.TransactionDate.ToString("yyyy-MM-dd HH:mm"),
                              actual.TransactionDate.ToString("yyyy-MM-dd HH:mm"));
            }
        }
    }
}
