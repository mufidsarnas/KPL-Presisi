using System;
using System.Collections.Generic;
using TokoPresisi.Models;

namespace GameVoucherAppSOLID.Interfaces
{
    public interface InterfacesTransaksi
    {
        void RegisterTransactionHandler(string transactionType, Action<Transaction> handler);
        void DisplayTransactions(List<Transaction> transactions);
    }
}
