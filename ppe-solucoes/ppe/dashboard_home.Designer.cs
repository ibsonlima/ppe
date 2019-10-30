namespace ppe
{
    partial class dashboard_home
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.aluno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caraiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.div_deshboard_trilhas = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.div_deshboard_simulado = new System.Windows.Forms.Panel();
            this.simulado = new System.Windows.Forms.Label();
            this.trilhas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.div_deshboard_trilhas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ppe.Properties.Resources.logo_pequena;
            this.pictureBox1.InitialImage = global::ppe.Properties.Resources.logo_PPE;
            this.pictureBox1.Location = new System.Drawing.Point(13, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.trilhas);
            this.panel1.Controls.Add(this.simulado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.aluno);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 729);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dashboard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // aluno
            // 
            this.aluno.AutoSize = true;
            this.aluno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.aluno.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.aluno.Location = new System.Drawing.Point(14, 197);
            this.aluno.Name = "aluno";
            this.aluno.Size = new System.Drawing.Size(50, 19);
            this.aluno.TabIndex = 3;
            this.aluno.Text = "Aluno";
            this.aluno.Click += new System.EventHandler(this.aluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ibson lima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.teste01ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 70);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caraiToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.testeToolStripMenuItem.Text = " teste";
            // 
            // caraiToolStripMenuItem
            // 
            this.caraiToolStripMenuItem.Name = "caraiToolStripMenuItem";
            this.caraiToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.caraiToolStripMenuItem.Text = "carai";
            // 
            // teste01ToolStripMenuItem
            // 
            this.teste01ToolStripMenuItem.Name = "teste01ToolStripMenuItem";
            this.teste01ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.teste01ToolStripMenuItem.Text = "teste01";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.toolStripMenuItem2.Text = "02";
            // 
            // div_deshboard_trilhas
            // 
            this.div_deshboard_trilhas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.div_deshboard_trilhas.Controls.Add(this.textBox1);
            this.div_deshboard_trilhas.Location = new System.Drawing.Point(296, 12);
            this.div_deshboard_trilhas.Name = "div_deshboard_trilhas";
            this.div_deshboard_trilhas.Size = new System.Drawing.Size(1000, 520);
            this.div_deshboard_trilhas.TabIndex = 2;
            this.div_deshboard_trilhas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "show";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // div_deshboard_simulado
            // 
            this.div_deshboard_simulado.BackColor = System.Drawing.SystemColors.InfoText;
            this.div_deshboard_simulado.Location = new System.Drawing.Point(286, 165);
            this.div_deshboard_simulado.Name = "div_deshboard_simulado";
            this.div_deshboard_simulado.Size = new System.Drawing.Size(1000, 520);
            this.div_deshboard_simulado.TabIndex = 1;
            this.div_deshboard_simulado.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // simulado
            // 
            this.simulado.AutoSize = true;
            this.simulado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.simulado.Location = new System.Drawing.Point(14, 291);
            this.simulado.Name = "simulado";
            this.simulado.Size = new System.Drawing.Size(79, 19);
            this.simulado.TabIndex = 5;
            this.simulado.Text = "Simulados";
            this.simulado.Click += new System.EventHandler(this.label3_Click);
            // 
            // trilhas
            // 
            this.trilhas.AutoSize = true;
            this.trilhas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.trilhas.Location = new System.Drawing.Point(14, 263);
            this.trilhas.Name = "trilhas";
            this.trilhas.Size = new System.Drawing.Size(53, 19);
            this.trilhas.TabIndex = 6;
            this.trilhas.Text = "Thihas";
            this.trilhas.Click += new System.EventHandler(this.trilhas_Click);
            // 
            // dashboard_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1350, 697);
            this.Controls.Add(this.div_deshboard_simulado);
            this.Controls.Add(this.div_deshboard_trilhas);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard_home";
            this.Text = "Dashboard bem vendo ao Programa Preparatorio para o Encceja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.div_deshboard_trilhas.ResumeLayout(false);
            this.div_deshboard_trilhas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caraiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel div_deshboard_trilhas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel div_deshboard_simulado;
        private System.Windows.Forms.Label trilhas;
        private System.Windows.Forms.Label simulado;
    }
}