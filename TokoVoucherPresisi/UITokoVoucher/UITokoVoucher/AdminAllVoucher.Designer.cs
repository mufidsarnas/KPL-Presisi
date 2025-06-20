namespace UITokoVoucher
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            textBoxUpdateNama = new TextBox();
            textBoxUpdateHarga = new TextBox();
            textBoxUpdatePlatform = new TextBox();
            btnUpdateVoucher = new Button();
            panel3 = new Panel();
            textBoxTambahNama = new TextBox();
            textBoxTambahHarga = new TextBox();
            textBoxTambahPlatform = new TextBox();
            btnTambahVoucher = new Button();
            labelPresisi = new Label();
            labelVoucherAdminAllVoucher = new Label();
            labelTokoAdminAllVoucher = new Label();
            panel2 = new Panel();
            listViewFormAdmin = new ListView();
            columnHeaderNama = new ColumnHeader();
            columnHeaderHarga = new ColumnHeader();
            columnHeaderPlatform = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(labelPresisi);
            panel1.Controls.Add(labelVoucherAdminAllVoucher);
            panel1.Controls.Add(labelTokoAdminAllVoucher);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 457);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(3, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(textBoxUpdateNama);
            panel4.Controls.Add(textBoxUpdateHarga);
            panel4.Controls.Add(textBoxUpdatePlatform);
            panel4.Controls.Add(btnUpdateVoucher);
            panel4.Location = new Point(7, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 176);
            panel4.TabIndex = 15;
            // 
            // textBoxUpdateNama
            // 
            textBoxUpdateNama.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpdateNama.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUpdateNama.Location = new Point(6, 12);
            textBoxUpdateNama.Name = "textBoxUpdateNama";
            textBoxUpdateNama.Size = new Size(197, 22);
            textBoxUpdateNama.TabIndex = 14;
            textBoxUpdateNama.Tag = "Nama";
            textBoxUpdateNama.Text = "Nama";
            textBoxUpdateNama.Click += textBoxUpdatePlatform_Click;
            textBoxUpdateNama.Validating += textBoxUpdatePlatform_Validating;
            // 
            // textBoxUpdateHarga
            // 
            textBoxUpdateHarga.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpdateHarga.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUpdateHarga.Location = new Point(6, 40);
            textBoxUpdateHarga.Name = "textBoxUpdateHarga";
            textBoxUpdateHarga.Size = new Size(197, 22);
            textBoxUpdateHarga.TabIndex = 13;
            textBoxUpdateHarga.Tag = "Harga";
            textBoxUpdateHarga.Text = "Harga";
            textBoxUpdateHarga.Click += textBoxUpdatePlatform_Click;
            textBoxUpdateHarga.Validating += textBoxUpdatePlatform_Validating;
            // 
            // textBoxUpdatePlatform
            // 
            textBoxUpdatePlatform.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpdatePlatform.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUpdatePlatform.Location = new Point(6, 68);
            textBoxUpdatePlatform.Name = "textBoxUpdatePlatform";
            textBoxUpdatePlatform.Size = new Size(197, 22);
            textBoxUpdatePlatform.TabIndex = 12;
            textBoxUpdatePlatform.Tag = "Platform";
            textBoxUpdatePlatform.Text = "Platform";
            textBoxUpdatePlatform.Click += textBoxUpdatePlatform_Click;
            textBoxUpdatePlatform.Validating += textBoxUpdatePlatform_Validating;
            // 
            // btnUpdateVoucher
            // 
            btnUpdateVoucher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdateVoucher.BackColor = SystemColors.ControlLightLight;
            btnUpdateVoucher.FlatStyle = FlatStyle.Popup;
            btnUpdateVoucher.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnUpdateVoucher.Location = new Point(6, 107);
            btnUpdateVoucher.Name = "btnUpdateVoucher";
            btnUpdateVoucher.Size = new Size(197, 27);
            btnUpdateVoucher.TabIndex = 11;
            btnUpdateVoucher.Text = "Update Voucher";
            btnUpdateVoucher.UseVisualStyleBackColor = false;
            btnUpdateVoucher.Click += btnUpdateVoucher_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxTambahNama);
            panel3.Controls.Add(textBoxTambahHarga);
            panel3.Controls.Add(textBoxTambahPlatform);
            panel3.Controls.Add(btnTambahVoucher);
            panel3.Location = new Point(7, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 170);
            panel3.TabIndex = 14;
            // 
            // textBoxTambahNama
            // 
            textBoxTambahNama.BorderStyle = BorderStyle.FixedSingle;
            textBoxTambahNama.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTambahNama.Location = new Point(6, 15);
            textBoxTambahNama.Name = "textBoxTambahNama";
            textBoxTambahNama.Size = new Size(197, 22);
            textBoxTambahNama.TabIndex = 17;
            textBoxTambahNama.Tag = "Nama";
            textBoxTambahNama.Text = "Nama";
            textBoxTambahNama.Click += textBoxUpdatePlatform_Click;
            textBoxTambahNama.Validating += textBoxUpdatePlatform_Validating;
            // 
            // textBoxTambahHarga
            // 
            textBoxTambahHarga.BorderStyle = BorderStyle.FixedSingle;
            textBoxTambahHarga.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTambahHarga.Location = new Point(6, 43);
            textBoxTambahHarga.Name = "textBoxTambahHarga";
            textBoxTambahHarga.Size = new Size(197, 22);
            textBoxTambahHarga.TabIndex = 16;
            textBoxTambahHarga.Tag = "Harga";
            textBoxTambahHarga.Text = "Harga";
            textBoxTambahHarga.Click += textBoxUpdatePlatform_Click;
            textBoxTambahHarga.Validating += textBoxUpdatePlatform_Validating;
            // 
            // textBoxTambahPlatform
            // 
            textBoxTambahPlatform.BorderStyle = BorderStyle.FixedSingle;
            textBoxTambahPlatform.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTambahPlatform.Location = new Point(6, 71);
            textBoxTambahPlatform.Name = "textBoxTambahPlatform";
            textBoxTambahPlatform.Size = new Size(197, 22);
            textBoxTambahPlatform.TabIndex = 15;
            textBoxTambahPlatform.Tag = "Platform";
            textBoxTambahPlatform.Text = "Platform";
            textBoxTambahPlatform.Click += textBoxUpdatePlatform_Click;
            textBoxTambahPlatform.Validating += textBoxUpdatePlatform_Validating;
            // 
            // btnTambahVoucher
            // 
            btnTambahVoucher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTambahVoucher.BackColor = SystemColors.ControlLightLight;
            btnTambahVoucher.FlatStyle = FlatStyle.Popup;
            btnTambahVoucher.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnTambahVoucher.Location = new Point(6, 108);
            btnTambahVoucher.Name = "btnTambahVoucher";
            btnTambahVoucher.Size = new Size(197, 27);
            btnTambahVoucher.TabIndex = 13;
            btnTambahVoucher.Text = "Tambah Voucher";
            btnTambahVoucher.UseVisualStyleBackColor = false;
            btnTambahVoucher.Click += btnTambahVoucher_Click;
            // 
            // labelPresisi
            // 
            labelPresisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPresisi.AutoSize = true;
            labelPresisi.BackColor = Color.Transparent;
            labelPresisi.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPresisi.ForeColor = Color.Black;
            labelPresisi.Location = new Point(69, 71);
            labelPresisi.Name = "labelPresisi";
            labelPresisi.Size = new Size(85, 13);
            labelPresisi.TabIndex = 12;
            labelPresisi.Text = "By: Presisi Team";
            // 
            // labelVoucherAdminAllVoucher
            // 
            labelVoucherAdminAllVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelVoucherAdminAllVoucher.AutoSize = true;
            labelVoucherAdminAllVoucher.BackColor = Color.Transparent;
            labelVoucherAdminAllVoucher.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelVoucherAdminAllVoucher.ForeColor = Color.Black;
            labelVoucherAdminAllVoucher.Location = new Point(90, 41);
            labelVoucherAdminAllVoucher.Name = "labelVoucherAdminAllVoucher";
            labelVoucherAdminAllVoucher.Size = new Size(109, 29);
            labelVoucherAdminAllVoucher.TabIndex = 9;
            labelVoucherAdminAllVoucher.Text = "Voucher";
            // 
            // labelTokoAdminAllVoucher
            // 
            labelTokoAdminAllVoucher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTokoAdminAllVoucher.AutoSize = true;
            labelTokoAdminAllVoucher.BackColor = Color.Transparent;
            labelTokoAdminAllVoucher.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTokoAdminAllVoucher.ForeColor = Color.Black;
            labelTokoAdminAllVoucher.Location = new Point(17, 32);
            labelTokoAdminAllVoucher.Name = "labelTokoAdminAllVoucher";
            labelTokoAdminAllVoucher.Size = new Size(84, 33);
            labelTokoAdminAllVoucher.TabIndex = 8;
            labelTokoAdminAllVoucher.Text = "Toko";
            // 
            // panel2
            // 
            panel2.Controls.Add(listViewFormAdmin);
            panel2.Location = new Point(220, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 457);
            panel2.TabIndex = 1;
            // 
            // listViewFormAdmin
            // 
            listViewFormAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            listViewFormAdmin.BorderStyle = BorderStyle.FixedSingle;
            listViewFormAdmin.Columns.AddRange(new ColumnHeader[] { columnHeaderNama, columnHeaderHarga, columnHeaderPlatform });
            listViewFormAdmin.Location = new Point(0, 0);
            listViewFormAdmin.Name = "listViewFormAdmin";
            listViewFormAdmin.Size = new Size(583, 457);
            listViewFormAdmin.TabIndex = 2;
            listViewFormAdmin.UseCompatibleStateImageBehavior = false;
            listViewFormAdmin.View = View.Details;
            listViewFormAdmin.SelectedIndexChanged += listViewFormAdmin_SelectedIndexChanged;
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
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "FormAdmin";
            Text = "Toko Voucher";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListView listViewFormAdmin;
        private ColumnHeader columnHeaderNama;
        private ColumnHeader columnHeaderHarga;
        private ColumnHeader columnHeaderPlatform;
        private Label labelVoucherAdminAllVoucher;
        private Label labelTokoAdminAllVoucher;
        private Label labelPresisi;
        private Button btnTambahVoucher;
        private Panel panel3;
        private TextBox textBoxTambahNama;
        private TextBox textBoxTambahHarga;
        private TextBox textBoxTambahPlatform;
        private Panel panel4;
        private PictureBox pictureBox2;
        private TextBox textBoxUpdateNama;
        private TextBox textBoxUpdateHarga;
        private TextBox textBoxUpdatePlatform;
        private Button btnUpdateVoucher;
        private PictureBox pictureBox1;
        private Button button1;
    }
}