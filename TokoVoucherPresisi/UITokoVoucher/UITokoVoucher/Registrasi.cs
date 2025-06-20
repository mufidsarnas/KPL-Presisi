using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static UITokoVoucher.FormPembeli;

namespace UITokoVoucher
{
    public partial class Registrasi : Form
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        public Registrasi()
        {
            InitializeComponent();
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

        private void btnSumbitRegis_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogin.Text;
            string password = textBoxPasswordLogin.Text;
            if (classData.users.ContainsKey(username))
            {
                MessageBox.Show("Username telah digunakan", "Error");
            }
            else
            {
                classData.users.Add(username, new classData.User { Username = username, Password = password, Role = classData.Role.Customer });
                MessageBox.Show("Registrasi berhasil!", "Sukses");
                textBoxUsernameLogin.Clear();
                textBoxPasswordLogin.Clear();
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
                return;
            }
        }
    }
}
