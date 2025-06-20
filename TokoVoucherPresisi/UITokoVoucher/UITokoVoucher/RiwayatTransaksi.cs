using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionLibrary;

namespace UITokoVoucher
{
    public partial class RiwayatTransaksi : Form
    {
        private TransactionService transactionService = new TransactionService();
        public RiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void LoadTransactionHistory()
        {
            listViewRiwayatTransaksi.Items.Clear();

            var history = transactionService.GetAll().Where(x => x.Username == Session.username).OrderByDescending(t => t.TransactionDate);

            if (!history.Any())
            {
                listViewRiwayatTransaksi.Items.Add("Tidak ada riwayat transaksi.");
                return;
            }

            foreach (var transaction in history)
            {
                var item = new ListViewItem(transaction.VoucherName);

                item.SubItems.Add(transaction.Quantity.ToString());
                item.SubItems.Add(transaction.TotalPrice.ToString());
                item.SubItems.Add(transaction.TransactionDate.ToString("yyyy-MM-dd HH:mm"));

                listViewRiwayatTransaksi.Items.Add(item);
            }
        }

        private void RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void btnBackRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPembeli FormPembeli = new FormPembeli();
            FormPembeli.Show();
        }
    }
}
