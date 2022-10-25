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
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Forms.r form = new Forms.Listar();

        }
    }
}
