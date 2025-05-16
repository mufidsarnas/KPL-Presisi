using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopUpSaldo.Service;
using TopUpSaldo.View;

namespace TopUpSaldo.Controller
{
    public class SaldoController
    {
        private readonly SaldoView view;
        private readonly TopUpService topupS;
        private readonly SaldoService saldoS;

        public SaldoController(SaldoView view, TopUpService topupS, SaldoService saldoS)
        {
            this.view = view;
            this.topupS = topupS;
            this.saldoS = saldoS;
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                view.LihatMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        topupS.HandleTopUp();
                        break;
                    case "2":
                        saldoS.HandleLihatSaldo();
                        break;
                    case "3":
                        running = false;
                        view.LihatPesan("Terima kasih!");
                        break;
                    default:
                        view.LihatPesan("Pilihan tidak valid, Silakan coba lagi.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
