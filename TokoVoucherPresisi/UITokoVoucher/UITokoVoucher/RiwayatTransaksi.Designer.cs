namespace UITokoVoucher
{
    partial class RiwayatTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatTransaksi));
            listViewRiwayatTransaksi = new ListView();
            columnHeaderNamaVoucher = new ColumnHeader();
            columnHeaderJumlah = new ColumnHeader();
            columnHeaderTotal = new ColumnHeader();
            columnHeaderTanggal = new ColumnHeader();
            labelRiwayatTransaksi = new Label();
            pictureBox1 = new PictureBox();
            labelVoucherAdminAllVoucher = new Label();
            labelTokoAdminAllVoucher = new Label();
            btnBackRiwayatTransaksi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listViewRiwayatTransaksi
            // 
            listViewRiwayatTransaksi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewRiwayatTransaksi.BorderStyle = BorderStyle.FixedSingle;
            listViewRiwayatTransaksi.Columns.AddRange(new ColumnHeader[] { columnHeaderNamaVoucher, columnHeaderJumlah, columnHeaderTotal, columnHeaderTanggal });
            listViewRiwayatTransaksi.Location = new Point(-1, 48);
            listViewRiwayatTransaksi.Name = "listViewRiwayatTransaksi";
            listViewRiwayatTransaksi.Size = new Size(805, 409);
            listViewRiwayatTransaksi.TabIndex = 0;
            listViewRiwayatTransaksi.UseCompatibleStateImageBehavior = false;
            listViewRiwayatTransaksi.View = View.Details;
            // 
            // columnHeaderNamaVoucher
            // 
            columnHeaderNamaVoucher.Text = "Nama Voucher";
            columnHeaderNamaVoucher.Width = 200;
            // 
            // columnHeaderJumlah
            // 
            columnHeaderJumlah.Text = "Jumlah";
            columnHeaderJumlah.Width = 200;
            // 
            // columnHeaderTotal
            // 
            columnHeaderTotal.Text = "Total";
            columnHeaderTotal.Width = 200;
            // 
            // columnHeaderTanggal
            // 
            columnHeaderTanggal.Text = "Tanggal";
            columnHeaderTanggal.Width = 200;
            // 
            // labelRiwayatTransaksi
            // 
            labelRiwayatTransaksi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelRiwayatTransaksi.AutoSize = true;
            labelRiwayatTransaksi.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRiwayatTransaksi.ForeColor = Color.Teal;
            labelRiwayatTransaksi.Location = new Point(232, 8);
            labelRiwayatTransaksi.Name = "labelRiwayatTransaksi";
            labelRiwayatTransaksi.Size = new Size(272, 33);
            labelRiwayatTransaksi.TabIndex = 1;
            labelRiwayatTransaksi.Text = "Riwayat Transaksi";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(748, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // labelVoucherAdminAllVoucher
            // 
            labelVoucherAdminAllVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelVoucherAdminAllVoucher.AutoSize = true;
            labelVoucherAdminAllVoucher.BackColor = Color.Transparent;
            labelVoucherAdminAllVoucher.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelVoucherAdminAllVoucher.ForeColor = Color.Teal;
            labelVoucherAdminAllVoucher.Location = new Point(694, 23);
            labelVoucherAdminAllVoucher.Name = "labelVoucherAdminAllVoucher";
            labelVoucherAdminAllVoucher.Size = new Size(64, 16);
            labelVoucherAdminAllVoucher.TabIndex = 22;
            labelVoucherAdminAllVoucher.Text = "Voucher";
            // 
            // labelTokoAdminAllVoucher
            // 
            labelTokoAdminAllVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTokoAdminAllVoucher.AutoSize = true;
            labelTokoAdminAllVoucher.BackColor = Color.Transparent;
            labelTokoAdminAllVoucher.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTokoAdminAllVoucher.ForeColor = Color.Teal;
            labelTokoAdminAllVoucher.Location = new Point(713, 6);
            labelTokoAdminAllVoucher.Name = "labelTokoAdminAllVoucher";
            labelTokoAdminAllVoucher.Size = new Size(48, 20);
            labelTokoAdminAllVoucher.TabIndex = 21;
            labelTokoAdminAllVoucher.Text = "Toko";
            // 
            // btnBackRiwayatTransaksi
            // 
            btnBackRiwayatTransaksi.BackColor = Color.Teal;
            btnBackRiwayatTransaksi.FlatStyle = FlatStyle.Popup;
            btnBackRiwayatTransaksi.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackRiwayatTransaksi.ForeColor = SystemColors.ControlLightLight;
            btnBackRiwayatTransaksi.Location = new Point(5, 6);
            btnBackRiwayatTransaksi.Name = "btnBackRiwayatTransaksi";
            btnBackRiwayatTransaksi.Size = new Size(25, 35);
            btnBackRiwayatTransaksi.TabIndex = 23;
            btnBackRiwayatTransaksi.Text = "<";
            btnBackRiwayatTransaksi.TextAlign = ContentAlignment.BottomCenter;
            btnBackRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnBackRiwayatTransaksi.Click += btnBackRiwayatTransaksi_Click;
            // 
            // RiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackRiwayatTransaksi);
            Controls.Add(labelVoucherAdminAllVoucher);
            Controls.Add(labelTokoAdminAllVoucher);
            Controls.Add(pictureBox1);
            Controls.Add(labelRiwayatTransaksi);
            Controls.Add(listViewRiwayatTransaksi);
            MinimumSize = new Size(816, 489);
            Name = "RiwayatTransaksi";
            Text = "Toko Voucher";
            Load += RiwayatTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewRiwayatTransaksi;
        private ColumnHeader columnHeaderTanggal;
        private ColumnHeader columnHeaderJumlah;
        private ColumnHeader columnHeaderTotal;
        private Label labelRiwayatTransaksi;
        private PictureBox pictureBox1;
        private Label labelVoucherAdminAllVoucher;
        private Label labelTokoAdminAllVoucher;
        private Button btnBackRiwayatTransaksi;
        private ColumnHeader columnHeaderNamaVoucher;
    }
}