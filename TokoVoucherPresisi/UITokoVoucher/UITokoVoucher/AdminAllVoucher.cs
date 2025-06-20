using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITokoVoucher
{
    public partial class FormAdmin : Form
    {
        public List<Voucher> vouchers = new List<Voucher>();
        private readonly string vouchersFilePath = "vouchers.json";

        public FormAdmin()
        {
            InitializeComponent();
            LoadVouchers();
            DisplayVouchers();
        }

        public void LoadVouchers()
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
                MessageBox.Show($"Gagal memuat daftar voucher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveVouchers()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(vouchers, options);
                File.WriteAllText(vouchersFilePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan daftar voucher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayVouchers()
        {
            listViewFormAdmin.Items.Clear();
            foreach (var voucher in vouchers)
            {
                var item = new ListViewItem(voucher.Name);
                item.SubItems.Add(voucher.Price.ToString());
                item.SubItems.Add(voucher.Platform);
                listViewFormAdmin.Items.Add(item);
            }
        }

        public void btnTambahVoucher_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxTambahNama.Text;
                if (!int.TryParse(textBoxTambahHarga.Text, out int price) || price <= 0)
                {
                    MessageBox.Show("Harga harus berupa angka positif!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string platform = textBoxTambahPlatform.Text;

                vouchers.Add(new Voucher { Name = name, Price = price, Platform = platform });
                SaveVouchers();
                DisplayVouchers();
                                
                MessageBox.Show("Voucher berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnUpdateVoucher_Click(object sender, EventArgs e)
        {
            if (listViewFormAdmin.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih voucher yang akan diupdate terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string oldName = listViewFormAdmin.SelectedItems[0].Text;
                var voucher = vouchers.Find(v => v.Name.Equals(oldName));

                if (voucher != null)
                {
                    string newName = textBoxUpdateNama.Text;
                    if (!int.TryParse(textBoxUpdateHarga.Text, out int newPrice) || newPrice <= 0)
                    {
                        MessageBox.Show("Harga harus berupa angka positif!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string newPlatform = textBoxUpdatePlatform.Text;

                    voucher.Name = newName;
                    voucher.Price = newPrice;
                    voucher.Platform = newPlatform;

                    SaveVouchers();
                    DisplayVouchers();

                    textBoxUpdateNama.Text = "Nama";
                    textBoxUpdateHarga.Text = "Harga";
                    textBoxUpdatePlatform.Text = "Platform";

                    MessageBox.Show("Voucher berhasil diupdate!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Voucher tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void listViewFormAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFormAdmin.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewFormAdmin.SelectedItems[0];
                textBoxUpdateNama.Text = selectedItem.Text;
                textBoxUpdateHarga.Text = selectedItem.SubItems[1].Text;
                textBoxUpdatePlatform.Text = selectedItem.SubItems[2].Text;
            }
        }

        public void textBoxUpdatePlatform_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox xtextBox = sender as System.Windows.Forms.TextBox;
            if (string.IsNullOrWhiteSpace(xtextBox.Text))
            {
                xtextBox.Text = xtextBox.Tag.ToString();

            }
        }

        public void textBoxUpdatePlatform_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox xtextBox = sender as System.Windows.Forms.TextBox;
            if (xtextBox.Text == xtextBox.Tag.ToString())
            {
                xtextBox.Text = "";
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
        }
    }
    public class Voucher
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Platform { get; set; }
    }
}