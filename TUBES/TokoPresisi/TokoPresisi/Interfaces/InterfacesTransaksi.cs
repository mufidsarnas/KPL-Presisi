using System;
using System.Collections.Generic;
using TokoPresisi.Models;

namespace TokoPresisi.Interfaces
{
    public interface InterfacesTransaksi
    {
        void RegisterTransactionHandler(string transactionType, Action<Transaksi> handler);
        void DisplayTransactions(List<Transaksi> transactions);
    }
}
