using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TopUpSaldo.Service;
using TopUpSaldo.Model;
using TopUpSaldo.View;

namespace TopUpSaldo.Test.Service
{
    [TestClass]
    public class SaldoServiceTests
    {
        private Mock<SaldoView> mockView;
        private Mock<Saldo> mockSaldo;
        private SaldoService saldoService;

        [TestInitialize]
        public void Setup()
        {
            // Membuat mock objek untuk SaldoView dan Saldo
            mockView = new Mock<SaldoView>();
            mockSaldo = new Mock<Saldo>();

            // Pastikan method GetSaldo() di kelas Saldo dideklarasikan virtual agar bisa dimock
            mockSaldo.Setup(s => s.GetSaldo()).Returns(10m);

            // Membuat instance SaldoService dengan mock objek
            saldoService = new SaldoService(mockView.Object, mockSaldo.Object);
        }

        [TestMethod]
        public void HandleLihatSaldo_ShouldUpdateSaldoAndCallViewMethods()
        {
            // Act
            saldoService.HandleLihatSaldo();

            // Assert
            mockSaldo.Verify(s => s.GetSaldo(), Times.AtLeastOnce);
            mockView.Verify(v => v.LihatSaldo(10m), Times.Once);
            mockView.Verify(v => v.GetInput("Tekan Enter untuk kembali"), Times.Once);
        }
    }
}
