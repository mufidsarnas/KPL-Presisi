using TopUpSaldo.Service;
using TopUpSaldo.Controller;
using TopUpSaldo.Model;
using TopUpSaldo.Service;
using TopUpSaldo.View;

namespace TopUpSaldo
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new SaldoView();
            var saldo = new Saldo();
            var topupS = new TopUpService(view, saldo);
            var saldoS = new SaldoService(view, saldo);
            var controller = new SaldoController(view, topupS, saldoS);

            controller.Run();
        }
    }
}