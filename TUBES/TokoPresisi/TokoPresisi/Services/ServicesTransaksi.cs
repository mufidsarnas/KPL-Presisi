using System;
using System.Collections.Generic;
using TokoPresisi.Interfaces;
using TokoPresisi.Models;

namespace TokoPresisi.Services
{
    public class ServicesTransaksi : InterfacesTransaksi
    {
        private readonly Dictionary<string, Action<Transaction>> _transactionHandlers;

        public ServicesTransaksi()
        {
            _transactionHandlers = new Dictionary<string, Action<Transaction>>();
        }

        public void RegisterTransactionHandler(string transactionType, Action<Transaction> handler)
        {
            if (!_transactionHandlers.ContainsKey(transactionType))
            {
                _transactionHandlers.Add(transactionType, handler);
            }
            else
            {
                _transactionHandlers[transactionType] = handler;
            }
        }

        public void DisplayTransactions(List<Transaction> transactions)
        {
            foreach (var t in transactions)
            {
                if (_transactionHandlers.TryGetValue(t.TransactionType, out var handler))
                {
                    handler(t);
                }
                else
                {
                    Console.WriteLine($"[Unknown] {t.Date}: Transaksi tipe {t.TransactionType} tidak dikenali.");
                }
            }
        }
    }
}
