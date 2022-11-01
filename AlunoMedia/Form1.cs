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
            }
        }
        List<Aluno> aluninho = new List<Aluno>();

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

        public Aluno buscarAlunoPorRa(int ra)
        {
            foreach (Aluno a in aluninho)
            {
                if (a.Ra == ra)
                {
                    return a;
                }
            }
            return null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Aluno student = new Aluno();
                student.nota1 = Convert.ToDouble(Nota1.Text);
                student.nota2 = Convert.ToDouble(Nota2.Text);
                student.nota3 = Convert.ToDouble(Nota3.Text);
                student.nota4 = Convert.ToDouble(Nota4.Text);
                student.nome = txtNome.Text;
                student.ra = Convert.ToInt32(txtCode.Text); //RA

            

            if (buscarAlunoPorRa(student.ra) == null)
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
                txtNome.Focus();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewRow aln = dataGridView1.Rows[e.RowIndex];
            int ra = Convert.ToInt32(aln.Cells[1].Value.ToString());

            Alteracao alteracao = new Alteracao(Aluno aluno, Form1 form1);
            alteracao.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void Exclude_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}