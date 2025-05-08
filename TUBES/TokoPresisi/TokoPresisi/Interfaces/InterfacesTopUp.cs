using System;
using TokoPresisi.Models;

namespace TokoPresisi.Interfaces
{
    public interface InterfacesTopUp
    {
        void TopUp(User user, decimal amount, string accountNumber);
    }
}
