namespace UITokoVoucher
{
    partial class FormPembeli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembeli));
            listViewFormPembeli = new ListView();
            columnHeaderNama = new ColumnHeader();
            columnHeaderHarga = new ColumnHeader();
            columnHeaderPlatform = new ColumnHeader();
            panel1 = new Panel();
            button1 = new Button();
            btnMenuSaldo = new Button();
            btnRiwayatTransaksi = new Button();
            btnBeliVoucher = new Button();
            textBoxJumlahVoucher = new TextBox();
            textBoxNamaVoucher = new TextBox();
            labelNamaVoucher = new Label();
            labelJumlahVoucher = new Label();
            labelPresisi = new Label();
            labelVoucherAdminAllVoucher = new Label();
            labelTokoAdminAllVoucher = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listViewFormPembeli
            // 
            listViewFormPembeli.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            listViewFormPembeli.BorderStyle = BorderStyle.FixedSingle;
            listViewFormPembeli.Columns.AddRange(new ColumnHeader[] { columnHeaderNama, columnHeaderHarga, columnHeaderPlatform });
            listViewFormPembeli.Location = new Point(218, 0);
            listViewFormPembeli.Name = "listViewFormPembeli";
            listViewFormPembeli.Size = new Size(583, 457);
            listViewFormPembeli.TabIndex = 3;
            listViewFormPembeli.UseCompatibleStateImageBehavior = false;
            listViewFormPembeli.View = View.Details;
            listViewFormPembeli.SelectedIndexChanged += listViewFormPembeli_SelectedIndexChanged;
            // 
            // columnHeaderNama
            // 
            columnHeaderNama.Text = "Nama Voucher";
            columnHeaderNama.Width = 300;
            // 
            // columnHeaderHarga
            // 
            columnHeaderHarga.Text = "Harga";
            columnHeaderHarga.Width = 150;
            // 
            // columnHeaderPlatform
            // 
            columnHeaderPlatform.Text = "Platform";
            columnHeaderPlatform.Width = 150;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMenuSaldo);
            panel1.Controls.Add(btnRiwayatTransaksi);
            panel1.Controls.Add(btnBeliVoucher);
            panel1.Controls.Add(textBoxJumlahVoucher);
            panel1.Controls.Add(textBoxNamaVoucher);
            panel1.Controls.Add(labelNamaVoucher);
            panel1.Controls.Add(labelJumlahVoucher);
            panel1.Controls.Add(labelPresisi);
            panel1.Controls.Add(labelVoucherAdminAllVoucher);
            panel1.Controls.Add(labelTokoAdminAllVoucher);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 457);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(7, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMenuSaldo
            // 
            btnMenuSaldo.BackColor = Color.MediumTurquoise;
            btnMenuSaldo.FlatStyle = FlatStyle.Popup;
            btnMenuSaldo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuSaldo.Location = new Point(18, 120);
            btnMenuSaldo.Name = "btnMenuSaldo";
            btnMenuSaldo.Size = new Size(197, 27);
            btnMenuSaldo.TabIndex = 32;
            btnMenuSaldo.Text = "Menu Saldo";
            btnMenuSaldo.UseVisualStyleBackColor = false;
            btnMenuSaldo.Click += button2_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.MediumTurquoise;
            btnRiwayatTransaksi.FlatStyle = FlatStyle.Popup;
            btnRiwayatTransaksi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.Location = new Point(18, 153);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(197, 27);
            btnRiwayatTransaksi.TabIndex = 31;
            btnRiwayatTransaksi.Text = "RiwayatTransaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnBeliVoucher
            // 
            btnBeliVoucher.BackColor = Color.MediumTurquoise;
            btnBeliVoucher.FlatStyle = FlatStyle.Popup;
            btnBeliVoucher.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeliVoucher.Location = new Point(15, 411);
            btnBeliVoucher.Name = "btnBeliVoucher";
            btnBeliVoucher.Size = new Size(197, 27);
            btnBeliVoucher.TabIndex = 30;
            btnBeliVoucher.Text = "Beli Voucher";
            btnBeliVoucher.UseVisualStyleBackColor = false;
            btnBeliVoucher.Click += btnBeliVoucher_Click;
            // 
            // textBoxJumlahVoucher
            // 
            textBoxJumlahVoucher.BorderStyle = BorderStyle.FixedSingle;
            textBoxJumlahVoucher.Location = new Point(26, 370);
            textBoxJumlahVoucher.Name = "textBoxJumlahVoucher";
            textBoxJumlahVoucher.Size = new Size(182, 23);
            textBoxJumlahVoucher.TabIndex = 28;
            // 
            // textBoxNamaVoucher
            // 
            textBoxNamaVoucher.BorderStyle = BorderStyle.FixedSingle;
            textBoxNamaVoucher.Location = new Point(26, 326);
            textBoxNamaVoucher.Name = "textBoxNamaVoucher";
            textBoxNamaVoucher.Size = new Size(182, 23);
            textBoxNamaVoucher.TabIndex = 27;
            // 
            // labelNamaVoucher
            // 
            labelNamaVoucher.AutoSize = true;
            labelNamaVoucher.Location = new Point(26, 308);
            labelNamaVoucher.Name = "labelNamaVoucher";
            labelNamaVoucher.Size = new Size(85, 15);
            labelNamaVoucher.TabIndex = 26;
            labelNamaVoucher.Text = "Nama Voucher";
            // 
            // labelJumlahVoucher
            // 
            labelJumlahVoucher.AutoSize = true;
            labelJumlahVoucher.Location = new Point(26, 352);
            labelJumlahVoucher.Name = "labelJumlahVoucher";
            labelJumlahVoucher.Size = new Size(45, 15);
            labelJumlahVoucher.TabIndex = 25;
            labelJumlahVoucher.Text = "Jumlah";
            // 
            // labelPresisi
            // 
            labelPresisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPresisi.AutoSize = true;
            labelPresisi.BackColor = Color.Transparent;
            labelPresisi.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPresisi.ForeColor = Color.Black;
            labelPresisi.Location = new Point(67, 76);
            labelPresisi.Name = "labelPresisi";
            labelPresisi.Size = new Size(85, 13);
            labelPresisi.TabIndex = 24;
            labelPresisi.Text = "By: Presisi Team";
            // 
            // labelVoucherAdminAllVoucher
            // 
            labelVoucherAdminAllVoucher.AutoSize = true;
            labelVoucherAdminAllVoucher.BackColor = Color.Transparent;
            labelVoucherAdminAllVoucher.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelVoucherAdminAllVoucher.ForeColor = Color.Black;
            labelVoucherAdminAllVoucher.Location = new Point(88, 46);
            labelVoucherAdminAllVoucher.Name = "labelVoucherAdminAllVoucher";
            labelVoucherAdminAllVoucher.Size = new Size(109, 29);
            labelVoucherAdminAllVoucher.TabIndex = 23;
            labelVoucherAdminAllVoucher.Text = "Voucher";
            // 
            // labelTokoAdminAllVoucher
            // 
            labelTokoAdminAllVoucher.AutoSize = true;
            labelTokoAdminAllVoucher.BackColor = Color.Transparent;
            labelTokoAdminAllVoucher.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTokoAdminAllVoucher.ForeColor = Color.Black;
            labelTokoAdminAllVoucher.Location = new Point(15, 37);
            labelTokoAdminAllVoucher.Name = "labelTokoAdminAllVoucher";
            labelTokoAdminAllVoucher.Size = new Size(84, 33);
            labelTokoAdminAllVoucher.TabIndex = 22;
            labelTokoAdminAllVoucher.Text = "Toko";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-42, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FormPembeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(listViewFormPembeli);
            MinimumSize = new Size(816, 489);
            Name = "FormPembeli";
            Text = "Toko Voucher";
            Load += FormPembeli_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewFormPembeli;
        private ColumnHeader columnHeaderNama;
        private ColumnHeader columnHeaderHarga;
        private ColumnHeader columnHeaderPlatform;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelPresisi;
        private Label labelVoucherAdminAllVoucher;
        private Label labelTokoAdminAllVoucher;
        private Label labelJumlahVoucher;
        private Label labelNamaVoucher;
        private TextBox textBoxNamaVoucher;
        private TextBox textBoxJumlahVoucher;
        private Button btnMenuSaldo;
        private Button btnRiwayatTransaksi;
        private Button btnBeliVoucher;
        private Button button1;
    }
}