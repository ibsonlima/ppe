namespace ppe
{
    partial class criar_contat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criar_contat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.portar_erro = new System.Windows.Forms.Button();
            this.fale_admin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ppe.Properties.Resources.logo_PPE;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(109, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 131);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // portar_erro
            // 
            this.portar_erro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.portar_erro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.portar_erro.FlatAppearance.BorderSize = 0;
            this.portar_erro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portar_erro.Font = new System.Drawing.Font("Calibri", 11F);
            this.portar_erro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.portar_erro.Location = new System.Drawing.Point(1050, 73);
            this.portar_erro.Margin = new System.Windows.Forms.Padding(4);
            this.portar_erro.Name = "portar_erro";
            this.portar_erro.Size = new System.Drawing.Size(141, 38);
            this.portar_erro.TabIndex = 6;
            this.portar_erro.Text = "REPORTAR ERRO";
            this.portar_erro.UseVisualStyleBackColor = false;
            // 
            // fale_admin
            // 
            this.fale_admin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fale_admin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fale_admin.FlatAppearance.BorderSize = 2;
            this.fale_admin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fale_admin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fale_admin.Location = new System.Drawing.Point(858, 73);
            this.fale_admin.Margin = new System.Windows.Forms.Padding(4);
            this.fale_admin.Name = "fale_admin";
            this.fale_admin.Size = new System.Drawing.Size(184, 38);
            this.fale_admin.TabIndex = 5;
            this.fale_admin.Text = "Falar com administrador";
            this.fale_admin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(109, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 335);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // criar_contat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.portar_erro);
            this.Controls.Add(this.fale_admin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "criar_contat";
            this.Text = "Criar uma nova conta";
            this.Load += new System.EventHandler(this.criar_contat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button portar_erro;
        private System.Windows.Forms.Button fale_admin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}