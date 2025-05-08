using System;
using System.Collections.Generic;
using TokoPresisi.Interfaces;

namespace TokoPresisi.Services
{
    public class ServicesVoucher : InterfacesVoucher
    {
        public void DisplayVouchers<T>(List<T> items) where T : class
        {
            foreach (var item in items)
            {
                var nameProp = item.GetType().GetProperty("Name");
                var priceProp = item.GetType().GetProperty("Price");

                if (nameProp != null && priceProp != null)
                {
                    var name = nameProp.GetValue(item);
                    var price = priceProp.GetValue(item);
                    Console.WriteLine($"- {name} | Harga: {price}");
                }
                else
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
