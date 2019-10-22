using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            string username = email_login.Text;
            string password = textBox1.Text;

            if (username == "picorest@gmail.com" && password == "123123")
            {
                this.Hide();
                var form1 = new dashboard_home();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else if (!username.Contains("@"))
            {
                MessageBox.Show("Digite um e-mail válido", "Aviso");
                email_login.Focus();
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("senha deve ser maior ou igual a 6 caracteres ", "Aviso");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta", "Aviso");
                email_login.Focus();
            }


        }

        private void email_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
