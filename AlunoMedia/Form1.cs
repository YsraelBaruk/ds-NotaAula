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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 1; x < 11; x++)
            {
                Nota1.Items.Add(x.ToString());
                Nota2.Items.Add(x.ToString());
                Nota3.Items.Add(x.ToString());
                Nota4.Items.Add(x.ToString());
                //if(x > 11 && x < 0)
                //{
                //    MessageBox.Show("Não é permitido numeros maiores que 10 ou menores que 0", "Alerta");
                //}
            }
        }
        List<Aluno> aluninho = new List<Aluno>();
        //aluninho.Add(New Aluno() {} );

        public void carregarLista()
        {
            dataGridView1.Rows.Clear();
            foreach(Aluno s in aluninho)
            {                
                dataGridView1.Rows.Add(
                    s.nome, 
                    s.ra, 
                    s.nota1, 
                    s.nota2, 
                    s.nota3, 
                    s.nota4, 
                    s.Calcmedia(), 
                    s.Situacao());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Aluno student = new Aluno();


            student.nome = txtNome.Text;
            student.ra = Convert.ToInt32(txtCode.Text); //RA
            student.nota1 = Convert.ToDouble(Nota1.Text);
            student.nota2 = Convert.ToDouble(Nota2.Text);
            student.nota3 = Convert.ToDouble(Nota3.Text);
            student.nota4 = Convert.ToDouble(Nota4.Text);

            bool existe = false;
            foreach (Aluno p in aluninho)
            {
                if (p.ra == student.ra)
                    existe = true;
            }

            if (!existe)
            {
                aluninho.Add(student);
                carregarLista();
                MessageBox.Show("Produto adicionado com sucesso", "Ok");                
            }
            else
            { 
                MessageBox.Show("Produto já existe, insira outro código", "Alerta");
            }            

            if (student.addConta(student))
            {
                txtCode.Clear();
                txtNome.Clear();
                Nota1.Items.Clear();
                Nota2.Items.Clear();
                Nota3.Items.Clear();
                Nota4.Items.Clear();
                txtNome.Focus();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewRow aln = dataGridView1.Rows[e.RowIndex];
            string nome = aln.Cells[0].Value.ToString();
            int ra = Convert.ToInt32(aln.Cells[1].Value.ToString());
            double nota1 = Convert.ToDouble(aln.Cells[2].Value.ToString());
            double nota2 = Convert.ToDouble(aln.Cells[3].Value.ToString());
            double nota3 = Convert.ToDouble(aln.Cells[4].Value.ToString());
            double nota4 = Convert.ToDouble(aln.Cells[5].Value.ToString());

            Alteracao alteracao = new Alteracao(nome, ra, nota1, nota2, nota3, nota4);
            alteracao.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int numero = Convert.ToInt32(txtNumero.Text);
            //double valor = Convert.ToDouble(txtValor.Text);
            //Transferir t = new Transferir(numero, valor, this);
            //t.Show();
            //filme.Add(new Filme() { Nome = "Homem Aranha", Ano = 2002, Avaliacao = 7, Sinopse = "Quando o morde uma aranha, o inteligente, e tímido Peter Parker ganha habilidades que deberá usar para lutar contra o mal.", Genero = "Ação" });
            //filme.Add(new Filme() { Nome = "Batman", Ano = 2022, Avaliacao = 7, Sinopse = "Batman se aventura no submundo de Gotham City quando um assassino sádico deixa para trás um rastro de pistas enigmáticas.", Genero = "Ação" });
            //filme.Add(new Filme() { Nome = "Tropa de Elite", Ano = 2007, Avaliacao = 8, Sinopse = "Em 1997, o capitão Nascimento tem que encontrar seu substituto enquanto luta contra os narcotraficantes e criminais.", Genero = "Ação" });
            //filme.Add(new Filme() { Nome = "Sing", Ano = 2016, Avaliacao = 7, Sinopse = "Numa cidade de animais humanóides, o dono dum teatro organiza uma competiçao de canto para salvar seu teatro.", Genero = "Animação" });
            //filme.Add(new Filme() { Nome = "Matrix", Ano = 1999, Avaliacao = 8, Sinopse = "Um hacker aprende com os misteriosos rebeldes sobre a verdadeira natureza de sua realidade e seu papel na guerra contra seus controladores.", Genero = "Ação" });

            //foreach (var f in filme)
            //{
            //    dataGridView1.Rows.Add(f.nome, f.ano, f.avaliacao, f.sinopse, f.genero);
            //}
            //txtNota1F2.Text
            //txtNota2F2.Text
            //txtNota3F2.Text
            //txtNota4F2.Text

            //txtNF2
            //txtN1F2
            //txtN2F2
            //txtN3F2
            //txtN4F2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //aluninho.
        }
    }
}