using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITokoVoucher
{
    public static class classData
    {
        public static Dictionary<string, User> users = new Dictionary<string, User>();
        public static Dictionary<string, Saldo> customerSaldo = new Dictionary<string, Saldo>();

        static classData()
        {
            inisiasiUser();
        }
        public class Saldo
        {
            public decimal saldo;

            public Saldo(decimal saldoAwal = 0)
            {
                this.saldo = saldoAwal;
            }

            public decimal GetSaldo()
            {
                return saldo;
            }

            public void AddSaldo(decimal jumlah)
            {
                saldo += jumlah;
            }

        }
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public Role Role { get; set; }
        }
        public enum Role
        {
            Admin,
            Customer
        }

        public static void inisiasiUser()
        {
            users.Clear();
            users["admin"] = new User { Username = "admin", Password = "admin123", Role = Role.Admin };
        }
    }
}
