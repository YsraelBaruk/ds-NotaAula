using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoMedia
{
    public partial class Alteracao : Form
    {
        Form1 form1;
        Aluno aluno;
        public Alteracao(Aluno aluno, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.aluno = aluno;

        }
        
        private void Alterar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            //int numero = Convert.ToInt32(txtNumero.Text);
            //double valor = Convert.ToDouble(textBox1.Text);
            string nome = txtN1F2.Text;
            int numero = Convert.ToInt32(txtRaF2.Text);
            double nota1 = Convert.ToDouble(txtN1F2.Text);
            double nota2 = Convert.ToDouble(txtN2F2.Text);
            double nota3 = Convert.ToDouble(txtN3F2.Text);
            double nota4 = Convert.ToDouble(txtN4F2.Text);
            Aluno c = aluno.buscarPorNumero(numero);
            if (txtNF2.Text == txtNomeF2.Text)
            {
                MessageBox.Show("Operação realizada com sucesso!!!");
                form1.carregarLista();
            }
            else
            {
                MessageBox.Show("Ops deu alguma coisa errada", "Erro");
            }

        }

        private void Alteracao_Load(object sender, EventArgs e)
        {
            txtNF2.Text = aluno.ra;
            txtN1F2.Text = txtNota1F2.Text;
            txtN2F2.Text = txtNota2F2.Text;
            txtN3F2.Text = txtNota3F2.Text;
            txtN4F2.Text = txtNota4F2.Text;
        }
    }
}
