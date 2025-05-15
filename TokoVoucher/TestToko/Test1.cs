using coba;

namespace TestToko
{
    [TestClass]
    public sealed class Test1
    {
        private VoucherSystem sistem;

        [TestInitialize]
        public void Setup()
        {
            sistem = new VoucherSystem();

            // List Voucher
            var vouchers = new List<Voucher>
            {
                new Voucher { Name = "Test Voucher", Price = 10000, Platform = "Test" }
            };

            // Reflection
            typeof(VoucherSystem)
                .GetField("vouchers", System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance)
                .SetValue(sistem, vouchers);
        }

        [TestMethod]
        public void HistoryKosong()
        {
            // Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            // Reflection
            typeof(VoucherSystem)
                .GetMethod("ShowHistory", System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance)
                .Invoke(sistem, null);

            // Assert
            string output = stringWriter.ToString();
            Assert.IsTrue(output.Contains("Tidak ada riwayat transaksi"));
        }
    }
}
