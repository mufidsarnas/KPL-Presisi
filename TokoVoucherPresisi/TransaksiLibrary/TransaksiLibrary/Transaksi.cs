using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using TransaksiLibrary;

namespace TransactionLibrary
{
    public class TransactionService
    {
        private List<TransaksiModel> transactions = new List<TransaksiModel>();
        private readonly string historyFilePath;

        public TransactionService(string filePath = "transaction_history.json")
        {
            historyFilePath = filePath;
            LoadTransactionHistory();
        }

        public void Add(string username, string voucherName, int quantity, int totalPrice)
        {
            var transaction = new TransaksiModel
            {
                Username = username,
                VoucherName = voucherName,
                Quantity = quantity,
                TotalPrice = totalPrice,
                TransactionDate = DateTime.Now
            };

            transactions.Add(transaction);
            SaveTransactionHistory();
        }

        public IEnumerable<TransaksiModel> GetAll()
        {
            return transactions;
        }

        private void SaveTransactionHistory()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(transactions, options);
                File.WriteAllText(historyFilePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to save transaction history: {ex.Message}");
            }
        }

        private void LoadTransactionHistory()
        {
            try
            {
                if (File.Exists(historyFilePath))
                {
                    string jsonString = File.ReadAllText(historyFilePath);
                    if (!string.IsNullOrEmpty(jsonString))
                    {
                        transactions = JsonSerializer.Deserialize<List<TransaksiModel>>(jsonString);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load transaction history: {ex.Message}");
            }
        }
    }
}