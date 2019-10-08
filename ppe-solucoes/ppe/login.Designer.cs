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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.fale_admin.Location = new System.Drawing.Point(962, 63);
            this.fale_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.portar_erro.Location = new System.Drawing.Point(1154, 63);
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
            this.entrar.Location = new System.Drawing.Point(962, 168);
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
            this.bemvindo.Location = new System.Drawing.Point(962, 220);
            this.bemvindo.Name = "bemvindo";
            this.bemvindo.Size = new System.Drawing.Size(332, 20);
            this.bemvindo.TabIndex = 6;
            this.bemvindo.Text = "Seja bem vindo! faça seu login para continuar";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.bemvindo);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.portar_erro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fale_admin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "home";
            this.Text = "Programa Preparatorio para o Encceja";
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
    }
}

