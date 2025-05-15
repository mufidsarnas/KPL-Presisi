using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoPresisi
{
    class ModelProduct
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }

        public ModelProduct(int id, string nama, decimal harga, int stok)
        {
            Id = id;
            Nama = nama;
            Harga = harga;
            Stok = stok;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nama: {Nama}, Harga: {Harga}, Stok: {Stok}";
        }
    }

    
}
