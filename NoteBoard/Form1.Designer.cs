namespace NoteBoard
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.mtxtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llblRegister = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(38, 54);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(359, 231);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Girişi";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(141, 318);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(256, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // mtxtPassword
            // 
            this.mtxtPassword.Location = new System.Drawing.Point(141, 369);
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '*';
            this.mtxtPassword.Size = new System.Drawing.Size(256, 26);
            this.mtxtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(38, 420);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(359, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "GİRİŞ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llblRegister
            // 
            this.llblRegister.AutoSize = true;
            this.llblRegister.Location = new System.Drawing.Point(137, 493);
            this.llblRegister.Name = "llblRegister";
            this.llblRegister.Size = new System.Drawing.Size(187, 20);
            this.llblRegister.TabIndex = 5;
            this.llblRegister.TabStop = true;
            this.llblRegister.Text = "Kayıt Olmak İçin Tıklayınız";
            this.llblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegister_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.MaskedTextBox mtxtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llblRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

