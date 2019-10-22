namespace ppe
{
    partial class home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fale_admin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.portar_erro = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.TextBox();
            this.bemvindo = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.email_login = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.ou = new System.Windows.Forms.Label();
            this.btn_facebook = new System.Windows.Forms.Button();
            this.btn_entrar_gmail = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ppe.Properties.Resources.logo_PPE;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(146, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fale_admin
            // 
            this.fale_admin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fale_admin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fale_admin.FlatAppearance.BorderSize = 2;
            this.fale_admin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fale_admin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fale_admin.Location = new System.Drawing.Point(862, 34);
            this.fale_admin.Margin = new System.Windows.Forms.Padding(4);
            this.fale_admin.Name = "fale_admin";
            this.fale_admin.Size = new System.Drawing.Size(184, 38);
            this.fale_admin.TabIndex = 2;
            this.fale_admin.Text = "Falar com administrador";
            this.fale_admin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::ppe.Properties.Resources.login_img1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(108, 276);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 297);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // portar_erro
            // 
            this.portar_erro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.portar_erro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.portar_erro.FlatAppearance.BorderSize = 0;
            this.portar_erro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portar_erro.Font = new System.Drawing.Font("Calibri", 11F);
            this.portar_erro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.portar_erro.Location = new System.Drawing.Point(1054, 34);
            this.portar_erro.Margin = new System.Windows.Forms.Padding(4);
            this.portar_erro.Name = "portar_erro";
            this.portar_erro.Size = new System.Drawing.Size(141, 38);
            this.portar_erro.TabIndex = 4;
            this.portar_erro.Text = "REPORTAR ERRO";
            this.portar_erro.UseVisualStyleBackColor = false;
            // 
            // entrar
            // 
            this.entrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entrar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Location = new System.Drawing.Point(847, 185);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(106, 26);
            this.entrar.TabIndex = 5;
            this.entrar.Text = "Entrar ";
            this.entrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bemvindo
            // 
            this.bemvindo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bemvindo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bemvindo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bemvindo.Location = new System.Drawing.Point(847, 222);
            this.bemvindo.Name = "bemvindo";
            this.bemvindo.Size = new System.Drawing.Size(332, 20);
            this.bemvindo.TabIndex = 6;
            this.bemvindo.Text = "Seja bem vindo! faça seu login para continuar";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(843, 257);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(49, 19);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "Email:";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_senha.Location = new System.Drawing.Point(843, 326);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(52, 19);
            this.label_senha.TabIndex = 8;
            this.label_senha.Text = "Senha:";
            // 
            // email_login
            // 
            this.email_login.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.email_login.Location = new System.Drawing.Point(847, 279);
            this.email_login.Multiline = true;
            this.email_login.Name = "email_login";
            this.email_login.Size = new System.Drawing.Size(340, 35);
            this.email_login.TabIndex = 9;
            this.email_login.Text = "Escreva seu email!";
            this.email_login.TextChanged += new System.EventHandler(this.email_login_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(847, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(340, 35);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Escreva sua Senha!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(1075, 331);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 14);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu a senha?";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_entrar.Location = new System.Drawing.Point(846, 405);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(340, 35);
            this.btn_entrar.TabIndex = 12;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // ou
            // 
            this.ou.AutoSize = true;
            this.ou.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ou.Location = new System.Drawing.Point(894, 452);
            this.ou.Name = "ou";
            this.ou.Size = new System.Drawing.Size(246, 19);
            this.ou.TabIndex = 13;
            this.ou.Text = "--------------------  OU  --------------------";
            // 
            // btn_facebook
            // 
            this.btn_facebook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_facebook.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_facebook.FlatAppearance.BorderSize = 2;
            this.btn_facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facebook.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facebook.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_facebook.Location = new System.Drawing.Point(847, 485);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.Size = new System.Drawing.Size(340, 35);
            this.btn_facebook.TabIndex = 14;
            this.btn_facebook.Text = "Entrar com Facebook";
            this.btn_facebook.UseVisualStyleBackColor = false;
            // 
            // btn_entrar_gmail
            // 
            this.btn_entrar_gmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_entrar_gmail.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_entrar_gmail.FlatAppearance.BorderSize = 2;
            this.btn_entrar_gmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar_gmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar_gmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_entrar_gmail.Location = new System.Drawing.Point(847, 543);
            this.btn_entrar_gmail.Name = "btn_entrar_gmail";
            this.btn_entrar_gmail.Size = new System.Drawing.Size(340, 35);
            this.btn_entrar_gmail.TabIndex = 15;
            this.btn_entrar_gmail.Text = "Entrar com Gmail";
            this.btn_entrar_gmail.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 9F);
            this.linkLabel2.Location = new System.Drawing.Point(1035, 589);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(103, 14);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Criar conta agora!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(894, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Não possui uma conta?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btn_entrar_gmail);
            this.Controls.Add(this.btn_facebook);
            this.Controls.Add(this.ou);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.email_login);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.bemvindo);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.portar_erro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fale_admin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "home";
            this.Text = "Programa Preparatorio para o Encceja";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fale_admin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button portar_erro;
        private System.Windows.Forms.TextBox entrar;
        private System.Windows.Forms.TextBox bemvindo;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox email_login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label ou;
        private System.Windows.Forms.Button btn_facebook;
        private System.Windows.Forms.Button btn_entrar_gmail;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
    }
}

