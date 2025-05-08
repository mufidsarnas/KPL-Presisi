using System;
using System.Collections.Generic;

namespace TokoPresisi.Interfaces
{
    public interface InterfacesVoucher
    {
        void DisplayVouchers<T>(List<T> items) where T : class;
    }
}
