using System;
using System.Collections.Generic;
using TokoPresisi.Interfaces;
using TokoPresisi.Models;

namespace TokoPresisi.Services
{
    public class ServicesTransaksi : InterfacesTransaksi
    {
        private readonly Dictionary<string, Action<Transaksi>> _transactionHandlers;

        public ServicesTransaksi()
        {
            _transactionHandlers = new Dictionary<string, Action<Transaksi>>();
        }

        public void RegisterTransactionHandler(string transactionType, Action<Transaksi> handler)
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

        public void DisplayTransactions(List<Transaksi> transactions)
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
