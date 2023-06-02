using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_bimestre
{
    public partial class Form1 : Form
    {
        List<Usuario> ListaU = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
            lb_confir.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            tx_cpf.Text = "";
            tx_sexo.Text = "";
            tx_senha.Text = "";
            tx_confSenha.Text = "";

        }

        private void tx_cpf_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tx_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tx_senha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tx_confSenha_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string senha = tx_senha.Text;
            string confSenha = tx_confSenha.Text;
            if(senha == confSenha)
            {
                Usuario usuario = new Usuario();
                usuario.Setnome(tx_nome.Text);
                usuario.Setcpf(tx_cpf.Text);
                usuario.Setsexo(tx_sexo.Text);
                usuario.Setsenha(senha);
                ListaU.Add(usuario);
                lb_confir.Text = "";
            }
            else
            {
                lb_confir.Text = "Senha Diferente!";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lb_confir_Click(object sender, EventArgs e)
        {

        }
    }
}
