namespace UITokoVoucher
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            labelPresisi = new Label();
            labelVoucherLogin = new Label();
            labelTokoLogin = new Label();
            pictureBox1 = new PictureBox();
            labelLogin = new Label();
            labelUsernameLogin = new Label();
            labelPasswordLogin = new Label();
            pictureBox2 = new PictureBox();
            textBoxUsernameLogin = new TextBox();
            textBoxPasswordLogin = new TextBox();
            btnSumbitLogin = new Button();
            linkLabelRegistrasi = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(labelPresisi);
            panel1.Controls.Add(labelVoucherLogin);
            panel1.Controls.Add(labelTokoLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 454);
            panel1.TabIndex = 0;
            // 
            // labelPresisi
            // 
            labelPresisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPresisi.AutoSize = true;
            labelPresisi.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPresisi.Location = new Point(89, 429);
            labelPresisi.Name = "labelPresisi";
            labelPresisi.Size = new Size(85, 13);
            labelPresisi.TabIndex = 3;
            labelPresisi.Text = "By: Presisi Team";
            // 
            // labelVoucherLogin
            // 
            labelVoucherLogin.AutoSize = true;
            labelVoucherLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelVoucherLogin.Location = new Point(117, 245);
            labelVoucherLogin.Name = "labelVoucherLogin";
            labelVoucherLogin.Size = new Size(109, 29);
            labelVoucherLogin.TabIndex = 2;
            labelVoucherLogin.Text = "Voucher";
            // 
            // labelTokoLogin
            // 
            labelTokoLogin.AutoSize = true;
            labelTokoLogin.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTokoLogin.Location = new Point(45, 237);
            labelTokoLogin.Name = "labelTokoLogin";
            labelTokoLogin.Size = new Size(84, 33);
            labelTokoLogin.TabIndex = 1;
            labelTokoLogin.Text = "Toko";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(324, 124);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(91, 33);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // labelUsernameLogin
            // 
            labelUsernameLogin.AutoSize = true;
            labelUsernameLogin.Location = new Point(324, 175);
            labelUsernameLogin.Name = "labelUsernameLogin";
            labelUsernameLogin.Size = new Size(60, 15);
            labelUsernameLogin.TabIndex = 2;
            labelUsernameLogin.Text = "Username";
            // 
            // labelPasswordLogin
            // 
            labelPasswordLogin.AutoSize = true;
            labelPasswordLogin.Location = new Point(324, 224);
            labelPasswordLogin.Name = "labelPasswordLogin";
            labelPasswordLogin.Size = new Size(57, 15);
            labelPasswordLogin.TabIndex = 3;
            labelPasswordLogin.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(504, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(449, 461);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // textBoxUsernameLogin
            // 
            textBoxUsernameLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsernameLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsernameLogin.Location = new Point(324, 193);
            textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            textBoxUsernameLogin.Size = new Size(440, 23);
            textBoxUsernameLogin.TabIndex = 5;
            // 
            // textBoxPasswordLogin
            // 
            textBoxPasswordLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPasswordLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswordLogin.Location = new Point(324, 242);
            textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            textBoxPasswordLogin.Size = new Size(440, 23);
            textBoxPasswordLogin.TabIndex = 6;
            // 
            // btnSumbitLogin
            // 
            btnSumbitLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSumbitLogin.BackColor = Color.MediumTurquoise;
            btnSumbitLogin.FlatStyle = FlatStyle.Flat;
            btnSumbitLogin.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumbitLogin.Location = new Point(324, 395);
            btnSumbitLogin.Name = "btnSumbitLogin";
            btnSumbitLogin.Size = new Size(440, 43);
            btnSumbitLogin.TabIndex = 7;
            btnSumbitLogin.Text = "Submit";
            btnSumbitLogin.UseVisualStyleBackColor = false;
            btnSumbitLogin.Click += btnSumbitLogin_Click;
            // 
            // linkLabelRegistrasi
            // 
            linkLabelRegistrasi.AutoSize = true;
            linkLabelRegistrasi.LinkColor = Color.DarkCyan;
            linkLabelRegistrasi.Location = new Point(324, 268);
            linkLabelRegistrasi.Name = "linkLabelRegistrasi";
            linkLabelRegistrasi.Size = new Size(57, 15);
            linkLabelRegistrasi.TabIndex = 8;
            linkLabelRegistrasi.TabStop = true;
            linkLabelRegistrasi.Text = "Registrasi";
            linkLabelRegistrasi.LinkClicked += linkLabelRegistrasi_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabelRegistrasi);
            Controls.Add(btnSumbitLogin);
            Controls.Add(textBoxPasswordLogin);
            Controls.Add(textBoxUsernameLogin);
            Controls.Add(pictureBox2);
            Controls.Add(labelPasswordLogin);
            Controls.Add(labelUsernameLogin);
            Controls.Add(labelLogin);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "FormLogin";
            Text = "Toko Voucher";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelVoucherLogin;
        private Label labelTokoLogin;
        private Label labelPresisi;
        private Label labelLogin;
        private Label labelUsernameLogin;
        private Label labelPasswordLogin;
        private PictureBox pictureBox2;
        private TextBox textBoxUsernameLogin;
        private TextBox textBoxPasswordLogin;
        private Button btnSumbitLogin;
        private LinkLabel linkLabelRegistrasi;
    }
}
