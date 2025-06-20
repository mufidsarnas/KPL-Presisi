namespace UITokoVoucher
{
    partial class MenuSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSaldo));
            panel1 = new Panel();
            label1 = new Label();
            labelPresisi = new Label();
            labelVoucherLogin = new Label();
            labelTokoLogin = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBoxNoRek = new TextBox();
            textBoxPin = new TextBox();
            textNominal = new TextBox();
            labelTopUp = new Label();
            labelNoRek = new Label();
            labelPin = new Label();
            btnSumbitTopUp = new Button();
            btnLihatSaldo = new Button();
            labelMenuSaldo = new Label();
            pictureBox3 = new PictureBox();
            btnBackMenuSaldo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelPresisi);
            panel1.Controls.Add(labelVoucherLogin);
            panel1.Controls.Add(labelTokoLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(518, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 457);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 429);
            label1.Name = "label1";
            label1.Size = new Size(107, 13);
            label1.TabIndex = 4;
            label1.Text = "By: Presisi Team & Pin";
            // 
            // labelPresisi
            // 
            labelPresisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPresisi.AutoSize = true;
            labelPresisi.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPresisi.Location = new Point(89, 786);
            labelPresisi.Name = "labelPresisi";
            labelPresisi.Size = new Size(85, 13);
            labelPresisi.TabIndex = 3;
            labelPresisi.Text = "By: Presisi Team";
            // 
            // labelVoucherLogin
            // 
            labelVoucherLogin.AutoSize = true;
            labelVoucherLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelVoucherLogin.Location = new Point(123, 238);
            labelVoucherLogin.Name = "labelVoucherLogin";
            labelVoucherLogin.Size = new Size(109, 29);
            labelVoucherLogin.TabIndex = 2;
            labelVoucherLogin.Text = "Voucher";
            // 
            // labelTokoLogin
            // 
            labelTokoLogin.AutoSize = true;
            labelTokoLogin.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTokoLogin.Location = new Point(51, 230);
            labelTokoLogin.Name = "labelTokoLogin";
            labelTokoLogin.Size = new Size(84, 33);
            labelTokoLogin.TabIndex = 1;
            labelTokoLogin.Text = "Toko";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-134, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(383, 391);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // textBoxNoRek
            // 
            textBoxNoRek.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNoRek.BorderStyle = BorderStyle.FixedSingle;
            textBoxNoRek.Location = new Point(11, 196);
            textBoxNoRek.Name = "textBoxNoRek";
            textBoxNoRek.Size = new Size(490, 23);
            textBoxNoRek.TabIndex = 5;
            textBoxNoRek.Tag = "Minimal 8 Digit";
            textBoxNoRek.Text = "Minimal 8 Digit";
            textBoxNoRek.TextAlign = HorizontalAlignment.Right;
            textBoxNoRek.Click += textNominal_Click;
            textBoxNoRek.Validating += textBoxPin_Validating;
            // 
            // textBoxPin
            // 
            textBoxPin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPin.BorderStyle = BorderStyle.FixedSingle;
            textBoxPin.Location = new Point(11, 245);
            textBoxPin.Name = "textBoxPin";
            textBoxPin.Size = new Size(490, 23);
            textBoxPin.TabIndex = 6;
            textBoxPin.Tag = "Minimal 6 Digit";
            textBoxPin.Text = "Minimal 6 Digit";
            textBoxPin.TextAlign = HorizontalAlignment.Right;
            textBoxPin.Click += textNominal_Click;
            textBoxPin.Validating += textBoxPin_Validating;
            // 
            // textNominal
            // 
            textNominal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textNominal.BorderStyle = BorderStyle.FixedSingle;
            textNominal.Location = new Point(11, 144);
            textNominal.Name = "textNominal";
            textNominal.Size = new Size(490, 23);
            textNominal.TabIndex = 7;
            textNominal.Tag = "Minimal 10000 - Maximal 10000000";
            textNominal.Text = "Minimal 10000 - Maximal 10000000";
            textNominal.TextAlign = HorizontalAlignment.Right;
            textNominal.Click += textNominal_Click;
            textNominal.Validating += textBoxPin_Validating;
            // 
            // labelTopUp
            // 
            labelTopUp.AutoSize = true;
            labelTopUp.Location = new Point(407, 126);
            labelTopUp.Name = "labelTopUp";
            labelTopUp.Size = new Size(94, 15);
            labelTopUp.TabIndex = 8;
            labelTopUp.Text = "Nominal Top Up";
            labelTopUp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelNoRek
            // 
            labelNoRek.AutoSize = true;
            labelNoRek.Location = new Point(423, 178);
            labelNoRek.Name = "labelNoRek";
            labelNoRek.Size = new Size(78, 15);
            labelNoRek.TabIndex = 9;
            labelNoRek.Text = "No. Rekening";
            labelNoRek.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPin
            // 
            labelPin.AutoSize = true;
            labelPin.Location = new Point(418, 227);
            labelPin.Name = "labelPin";
            labelPin.Size = new Size(83, 15);
            labelPin.TabIndex = 10;
            labelPin.Text = "Masukkan PIN";
            labelPin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSumbitTopUp
            // 
            btnSumbitTopUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSumbitTopUp.BackColor = Color.MediumTurquoise;
            btnSumbitTopUp.FlatStyle = FlatStyle.Flat;
            btnSumbitTopUp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumbitTopUp.Location = new Point(12, 395);
            btnSumbitTopUp.Name = "btnSumbitTopUp";
            btnSumbitTopUp.Size = new Size(489, 43);
            btnSumbitTopUp.TabIndex = 11;
            btnSumbitTopUp.Text = " Submit Top Up";
            btnSumbitTopUp.UseVisualStyleBackColor = false;
            btnSumbitTopUp.Click += btnSumbitTopUp_Click;
            // 
            // btnLihatSaldo
            // 
            btnLihatSaldo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLihatSaldo.BackColor = Color.MediumTurquoise;
            btnLihatSaldo.FlatStyle = FlatStyle.Flat;
            btnLihatSaldo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLihatSaldo.Location = new Point(12, 357);
            btnLihatSaldo.Name = "btnLihatSaldo";
            btnLihatSaldo.Size = new Size(125, 32);
            btnLihatSaldo.TabIndex = 12;
            btnLihatSaldo.Text = "Info Saldo";
            btnLihatSaldo.UseVisualStyleBackColor = false;
            btnLihatSaldo.Click += btnLihatSaldo_Click;
            // 
            // labelMenuSaldo
            // 
            labelMenuSaldo.AutoSize = true;
            labelMenuSaldo.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMenuSaldo.Location = new Point(302, 67);
            labelMenuSaldo.Name = "labelMenuSaldo";
            labelMenuSaldo.Size = new Size(179, 33);
            labelMenuSaldo.TabIndex = 13;
            labelMenuSaldo.Text = "Menu Saldo";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-51, -51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 142);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // btnBackMenuSaldo
            // 
            btnBackMenuSaldo.BackColor = SystemColors.ControlLightLight;
            btnBackMenuSaldo.FlatStyle = FlatStyle.Popup;
            btnBackMenuSaldo.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackMenuSaldo.ForeColor = Color.Teal;
            btnBackMenuSaldo.Location = new Point(11, 12);
            btnBackMenuSaldo.Name = "btnBackMenuSaldo";
            btnBackMenuSaldo.Size = new Size(25, 35);
            btnBackMenuSaldo.TabIndex = 24;
            btnBackMenuSaldo.Text = "<";
            btnBackMenuSaldo.TextAlign = ContentAlignment.BottomCenter;
            btnBackMenuSaldo.UseVisualStyleBackColor = false;
            btnBackMenuSaldo.Click += btnBackMenuSaldo_Click;
            // 
            // MenuSaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackMenuSaldo);
            Controls.Add(pictureBox3);
            Controls.Add(labelMenuSaldo);
            Controls.Add(btnLihatSaldo);
            Controls.Add(btnSumbitTopUp);
            Controls.Add(labelPin);
            Controls.Add(labelNoRek);
            Controls.Add(labelTopUp);
            Controls.Add(textNominal);
            Controls.Add(textBoxPin);
            Controls.Add(textBoxNoRek);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "MenuSaldo";
            Text = "Toko Voucher";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelPresisi;
        private Label labelVoucherLogin;
        private Label labelTokoLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBoxNoRek;
        private TextBox textBoxPin;
        private TextBox textNominal;
        private Label labelTopUp;
        private Label labelNoRek;
        private Label labelPin;
        private Button btnSumbitTopUp;
        private Button btnLihatSaldo;
        private Label labelMenuSaldo;
        private PictureBox pictureBox3;
        private Button btnBackMenuSaldo;
    }
}