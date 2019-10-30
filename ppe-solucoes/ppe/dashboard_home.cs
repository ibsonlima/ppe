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
    public partial class dashboard_home : Form
    {
        public dashboard_home()
        {
            //ponto de inicio
            InitializeComponent();
           div_deshboard_simulado.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aluno_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            div_deshboard_trilhas.Hide();
            div_deshboard_simulado.Show();



        }

        private void trilhas_Click(object sender, EventArgs e)
        {
            div_deshboard_trilhas.Show();
            div_deshboard_simulado.Hide();
            //Component1 primeiro_comp = new Component1();
            //primeiro_comp.teste.AddOwnedForm();

            //primeiro_comp.panel1_Pain();




        }
    }
}
