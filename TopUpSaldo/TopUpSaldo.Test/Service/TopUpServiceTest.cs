using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TopUpSaldo.Service;
using TopUpSaldo.Model;
using TopUpSaldo.View;
using System.Collections.Generic;

namespace TopUpSaldo.Test.Service
{
    [TestClass]
    public class TopUpServiceTests
    {
        private Mock<SaldoView> mockView;
        private Mock<Saldo> mockSaldo;
        private TopUpService topUpService;

        [TestInitialize]
        public void Setup()
        {
            mockView = new Mock<SaldoView>();
            mockSaldo = new Mock<Saldo>();

            topUpService = new TopUpService(mockView.Object, mockSaldo.Object);
        }

        [TestMethod]
        public void HandleTopUp_SuccessfulTopUp_CallsAddSaldoAndShowsSuccessMessage()
        {
            // Arrange: Setup input sequence untuk GetInput
            var inputSequence = new Queue<string>(new[]
            {
                "15000",   // nominal top up valid
                "1",       // pilih lanjut ke pembayaran
                "1234567890123456", // nomor kartu valid 16 digit
                "123456"   // PIN valid 6 digit
            });

            mockView.Setup(v => v.GetInput(It.IsAny<string>()))
                    .Returns(() => inputSequence.Dequeue());

            // Act
            topUpService.HandleTopUp();

            // Assert
            mockSaldo.Verify(s => s.AddSaldo(15000m), Times.Once);
            mockView.Verify(v => v.LihatPesan("Top up berhasil!"), Times.Once);
        }

        [TestMethod]
        public void HandleTopUp_InvalidNominal_ShowsErrorMessageAndRepeatsInput()
        {
            // Arrange: Input nominal invalid lalu valid, kemudian batal
            var inputSequence = new Queue<string>(new[]
            {
                "5000",    // nominal invalid (kurang dari 10000)
                "15000",   // nominal valid
                "2"        // batal pembayaran
            });

            mockView.Setup(v => v.GetInput(It.IsAny<string>()))
                    .Returns(() => inputSequence.Dequeue());

            // Act
            topUpService.HandleTopUp();

            // Assert
            mockView.Verify(v => v.LihatPesan("Jumlah Nominal tidak valid"), Times.Once);
            mockView.Verify(v => v.LihatPesan("Pembayaran dibatalkan, kembali ke menu utama."), Times.Once);
            mockSaldo.Verify(s => s.AddSaldo(It.IsAny<decimal>()), Times.Never);
        }

        [TestMethod]
        public void HandleTopUp_InvalidCardNumber_ShowsErrorMessageAndRepeatsInput()
        {
            // Arrange: Input valid nominal, pilih lanjut, input kartu invalid, lalu input kartu valid dan PIN valid
            var inputSequence = new Queue<string>(new[]
            {
        "20000",               // nominal valid
        "1",                   // pilih lanjut
        "1234",                // nomor kartu invalid (kurang dari 16 digit)
        "1234567890123456",    // nomor kartu valid
        "123456"               // PIN valid
    });

            mockView.Setup(v => v.GetInput(It.IsAny<string>()))
                    .Returns(() => inputSequence.Dequeue());

            // Act
            topUpService.HandleTopUp();

            // Assert
            mockView.Verify(v => v.LihatPesan("Nomor kartu harus 16 digit angka, silahkan top up ulang"), Times.Once);
            mockSaldo.Verify(s => s.AddSaldo(20000m), Times.Once);
            mockView.Verify(v => v.LihatPesan("Top up berhasil!"), Times.Once);
        }

        [TestMethod]
        public void HandleTopUp_InvalidPin_ShowsErrorMessageAndRepeatsInput()
        {
            // Arrange: Input valid nominal, pilih lanjut, input kartu valid, input PIN invalid, lalu input PIN valid
            var inputSequence = new Queue<string>(new[]
            {
        "25000",               // nominal valid
        "1",                   // pilih lanjut
        "1234567890123456",    // nomor kartu valid
        "123",                 // PIN invalid (kurang dari 6 digit)
        "654321"               // PIN valid
    });

            mockView.Setup(v => v.GetInput(It.IsAny<string>()))
                    .Returns(() => inputSequence.Dequeue());

            // Act
            topUpService.HandleTopUp();

            // Assert
            mockView.Verify(v => v.LihatPesan("PIN harus 6 digit angka, silahkan top up ulang"), Times.Once);
            mockSaldo.Verify(s => s.AddSaldo(25000m), Times.Once);
            mockView.Verify(v => v.LihatPesan("Top up berhasil!"), Times.Once);
        }
    }
}
