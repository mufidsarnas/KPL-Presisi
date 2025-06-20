using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionLibrary;
using static UITokoVoucher.FormLogin;
using static UITokoVoucher.MenuSaldo;


namespace UITokoVoucher
{
    public partial class FormPembeli : Form
    {
        private List<Voucher> vouchers = new List<Voucher>();
        private Dictionary<string, Saldo> tabelSaldo = new Dictionary<string, Saldo>();
        TransactionService transactionService = new TransactionService();
        private readonly string vouchersFilePath = "vouchers.json";
        public class Voucher
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Platform { get; set; }
        }
        public FormPembeli()
        {
            LoadVouchers();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuSaldo MenuSaldo = new MenuSaldo();
            MenuSaldo.Show();
        }

        private void listViewFormPembeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFormPembeli.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewFormPembeli.SelectedItems[0];

                textBoxNamaVoucher.Text = selectedItem.Text;
            }
        }

        private void FormPembeli_Load(object sender, EventArgs e)
        {
            ShowAllVouchers();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            RiwayatTransaksi RiwayatTransaksi = new RiwayatTransaksi();
            RiwayatTransaksi.Show();

        }

        private void ShowAllVouchers()
        {
            listViewFormPembeli.Items.Clear();

            if (vouchers.Count == 0)
                listViewFormPembeli.Items.Add("Tidak ada voucher.");

            foreach (var voucher in vouchers)
            {
                var item = new ListViewItem(voucher.Name);

                item.SubItems.Add(voucher.Price.ToString());
                item.SubItems.Add(voucher.Platform);

                listViewFormPembeli.Items.Add(item);
            }
        }
        private void LoadVouchers()
        {
            try
            {
                if (File.Exists(vouchersFilePath))
                {
                    string jsonString = File.ReadAllText(vouchersFilePath);
                    if (!string.IsNullOrEmpty(jsonString))
                    {
                        vouchers = JsonSerializer.Deserialize<List<Voucher>>(jsonString);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal memuat daftar voucher: {ex.Message}");
            }
        }

        private void btnBeliVoucher_Click(object sender, EventArgs e)
        {
            BuyVoucher();
        }

        private void BuyVoucher()
        {
            if (listViewFormPembeli.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silakan pilih voucher terlebih dahulu!", "Peringatan",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxJumlahVoucher.Text))
            {
                MessageBox.Show("Masukkan jumlah voucher yang ingin dibeli!", "Peringatan",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ListViewItem selectedItem = listViewFormPembeli.SelectedItems[0];
                string namaVoucher = selectedItem.Text.Trim();

                Voucher voucher = vouchers.Find(v =>
                    v.Name.Trim().Equals(namaVoucher, StringComparison.OrdinalIgnoreCase));

                if (voucher == null)
                {
                    MessageBox.Show($"Voucher '{namaVoucher}' tidak ditemukan!");
                    return;
                }

                int quantity = int.Parse(textBoxJumlahVoucher.Text.Trim());

                if (quantity <= 0)
                {
                    MessageBox.Show("Jumlah pembelian harus lebih dari 0!");
                    return;
                }

                int totalPrice = voucher.Price * quantity;

                if (!classData.customerSaldo.ContainsKey(Session.username))
                {
                    MessageBox.Show("Data saldo pengguna tidak ditemukan!");
                    return;
                }

                classData.Saldo userSaldo = classData.customerSaldo[Session.username];

                if (userSaldo.GetSaldo() > totalPrice)
                {

                    transactionService.Add(Session.username, namaVoucher, quantity, totalPrice);
                    userSaldo.AddSaldo(totalPrice * -1);

                    MessageBox.Show($"Pembelian berhasil!\n\n" +
                                  $"Voucher: {namaVoucher}\n" +
                                  $"Jumlah: {quantity}\n" +
                                  $"Total Harga: {totalPrice:C}",
                                  "Sukses");

                    textBoxJumlahVoucher.Clear();
                }
                else
                {
                    MessageBox.Show("Saldo tidak cukup untuk melakukan pembelian");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Masukkan jumlah voucher dalam angka yang valid!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
        }
    }
}
