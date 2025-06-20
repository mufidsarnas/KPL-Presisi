using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static UITokoVoucher.FormLogin;

namespace UITokoVoucher
{
    public partial class MenuSaldo : Form
    {
        public MenuSaldo()
        {
            InitializeComponent();
        }

        private void btnLihatSaldo_Click(object sender, EventArgs e)
        {
            decimal saldo = classData.customerSaldo[Session.username].GetSaldo();
            MessageBox.Show("Saldo Anda : " + saldo.ToString());
        }

        public class SaldoService
        {
            private Dictionary<string, Saldo> tabelSaldo;

            public SaldoService(Saldo initialSaldo, string initialUserId = "a")
            {
                this.tabelSaldo = new Dictionary<string, Saldo>();
                AddOrUpdateCustomer(initialUserId, initialSaldo);
            }

            public void AddOrUpdateCustomer(string username, Saldo saldo)
            {
                tabelSaldo[username] = saldo;
            }

            public void SetCustomerBalance(string username, decimal amount)
            {
                tabelSaldo[username] = new Saldo(amount);
            }

            public Saldo GetCustomerSaldo(string customerId)
            {
                return tabelSaldo.TryGetValue(customerId, out var saldo) ? saldo : null;
            }
        }

        private void btnSumbitTopUp_Click(object sender, EventArgs e)
        {
            try
            {
                decimal nominal = decimal.Parse(textNominal.Text);
                if (nominal < 10000 || nominal > 10000000)
                {
                    MessageBox.Show("Nominal Tidak Valid!");
                    return;
                }

                if (textBoxNoRek.Text.Length < 8)
                {
                    MessageBox.Show("No. Rekening Minimal 8 Digit");
                    return;
                }

                if (textBoxPin.Text.Length < 6)
                {
                    MessageBox.Show("PIN Minimal 8 Digit");
                    return;
                }

                classData.customerSaldo[Session.username].AddSaldo(nominal);
                textNominal.Text = textNominal.Tag.ToString();
                textBoxNoRek.Text = textBoxNoRek.Tag.ToString();
                textBoxPin.Text = textBoxPin.Tag.ToString();

                MessageBox.Show("Berhasil Top Up Saldo");

            }
            catch
            {
                MessageBox.Show("Masukkan Angka!");
            }
        }

        private void textNominal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                decimal nominalText = decimal.Parse(textNominal.Text);
            }
            catch
            {
                textNominal.Text = "Minimal 10000 - Maximal 10000000";
            }
        }

        private void textNominal_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.TextBox xtextBox = sender as System.Windows.Forms.TextBox;
            if (xtextBox.Text == xtextBox.Tag.ToString())
            {
                xtextBox.Text = "";
            }
        }

        private void textBoxPin_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox xtextBox = sender as System.Windows.Forms.TextBox;
            try
            {
                decimal nominalText = decimal.Parse(xtextBox.Text);
            }
            catch
            {
                xtextBox.Text = xtextBox.Tag.ToString();
            }
        }

        private void btnBackMenuSaldo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPembeli FormPembeli = new FormPembeli();
            FormPembeli.Show();
        }

    }
}
