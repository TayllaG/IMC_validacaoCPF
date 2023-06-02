using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa P = new Pessoa(tx_nome.Text, tx_cpf.Text, tx_sexo.Text, Convert.ToDouble(tx_peso.Text), Convert.ToDouble(tx_altura.Text), Convert.ToInt32(tx_idade.Text));
            P.Setnome(tx_nome.Text);
            P.Setcpf(tx_cpf.Text);
            P.Setsexo(tx_sexo.Text);
            P.Setpeso(Convert.ToDouble(tx_peso.Text));
            P.Setaltura(Convert.ToDouble(tx_altura.Text));
            P.Setidade(Convert.ToInt32(tx_idade.Text));
            (double imc, string classi, string grau) = P.Imc();
            tx_resultado.Text = $"O IMC é {imc}, sua classificação é {classi}, no grau {grau}";
            
            string cpf= tx_cpf.Text;
            bool resultadoCPF = Validacoes.ValidaCPF(cpf);
            MessageBox.Show(resultadoCPF.ToString());


        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
