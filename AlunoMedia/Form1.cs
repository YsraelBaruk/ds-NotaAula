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
                if(x > 11 && x < 0)
                {
                    MessageBox.Show("Não é permitido numeros maiores que 10 ou menores que 0", "Alerta");
                }
            }
        }
        List<Aluno> aluninho = new List<Aluno>();
        private void Button1_Click(object sender, EventArgs e)
        {
            Aluno student = new Aluno();
            student.nota1 = Convert.ToDouble(Nota1.Text);
            student.nota1 = Convert.ToDouble(Nota2.Text);
            student.nota1 = Convert.ToDouble(Nota3.Text);
            student.nota1 = Convert.ToDouble(Nota4.Text);
            student.nome = txtNome.Text;

            dataGridView1.Rows.Add(student.nome, student.nota1, student.nota2, student.nota3, student.nota4, Calcmedia(media));
        }
    }
}
