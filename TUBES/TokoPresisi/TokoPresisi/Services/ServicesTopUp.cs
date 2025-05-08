using System;
using System.Linq;
using TokoPresisi.Interfaces;
using TokoPresisi.Models;

namespace TokoPresisi.Services
{
    public class ServicesTopUp : InterfacesTopUp
    {
        public void TopUp(User user, decimal amount, string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber) || accountNumber.Length < 12 || !accountNumber.All(char.IsDigit))
            {
                Console.WriteLine("Nomor rekening tidak valid. Minimal 12 digit angka.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Jumlah top up harus lebih dari 0.");
                return;
            }

            try
            {
                user.AddBalance(amount);
                Console.WriteLine($"Top up berhasil. Saldo baru: {user.Balance}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
