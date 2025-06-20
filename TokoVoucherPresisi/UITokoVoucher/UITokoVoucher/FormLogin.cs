using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using Microsoft.VisualBasic;

namespace UITokoVoucher
{
    public partial class FormLogin : Form
    {
        public class Saldo
        {
            private decimal saldo;

            public Saldo()
            {
                saldo = 0;
            }

            public Saldo(decimal saldoAwal)
            {
                saldo = saldoAwal;
            }

            public decimal GetSaldo()
            {
                return saldo;
            }

            public void AddSaldo(decimal jumlah)
            {
                if (jumlah > 0)
                {
                    saldo += jumlah;
                }
            }

            public bool KurangiSaldo(decimal jumlah)
            {
                if (jumlah > 0 && saldo >= jumlah)
                {
                    saldo -= jumlah;
                    return true;
                }
                return false;
            }
        }
        public abstract class UserFormFactory
        {
            public abstract Form CreateForm();
        }

        public class CustomerFormFactory : UserFormFactory
        {
            public override Form CreateForm()
            {
                return new FormPembeli();
            }
        }

        public class AdminFormFactory : UserFormFactory
        {
            public override Form CreateForm()
            {
                return new FormAdmin();
            }
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSumbitLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogin.Text;
            string password = textBoxPasswordLogin.Text;

            if (classData.users.ContainsKey(username) && classData.users[username].Password == password)
            {
                Session.username = username;
                Session.role = classData.users[username].Role.ToString();

                UserFormFactory formFactory;

                if (Session.role == classData.Role.Customer.ToString())
                {
                    if (!classData.customerSaldo.ContainsKey(username))
                    {
                        classData.customerSaldo[username] = new classData.Saldo();
                    }
                    formFactory = new CustomerFormFactory();
                }
                else if (Session.role == classData.Role.Admin.ToString())
                {
                    formFactory = new AdminFormFactory();
                }
                else
                {
                    MessageBox.Show("Role user tidak dikenali.");
                    return;
                }

                this.Hide();

                try
                {
                    Form userForm = formFactory.CreateForm();
                    userForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat membuka form: " + ex.Message);
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Login gagal: username atau password salah.");
            }
        }

        private void linkLabelRegistrasi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registrasi regis = new Registrasi();
            regis.Show();
            return;
        }
    }
}
