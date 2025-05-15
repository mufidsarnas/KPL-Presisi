// TransactionService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using TransaksiLibrary;

namespace TransactionLibrary
{
    public class TransactionService
    {
        private List<TransaksiModel> transaksi = new List<TransaksiModel>();

        public void Add(string voucherName, int quantity, int totalPrice)
        {
            transaksi.Add(new TransaksiModel
            {
                VoucherName = voucherName,
                Quantity = quantity,
                TotalPrice = totalPrice
            });
        }

        public IEnumerable<TransaksiModel> GetAll()
        {
            return transaksi.AsReadOnly();
        }

        //public void Clear()
        //{
        //    transaksi.Clear();
        //}

        //public int GetTotalSpent()
        //{
        //    return transaksi.Sum(t => t.TotalPrice);
        //}
    }
}