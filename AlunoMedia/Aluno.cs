using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace AlunoMedia
{
    public class Aluno
    {
        public List<Aluno> aluninho = new List<Aluno>();

        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;
        public string nome;
        public int ra;
        public double media;
        public string msgErro;

        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Nota4 { get => nota4; set => nota4 = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Ra { get => ra; set => ra = value; }
        public double Media { get => media; set => media = value; }
        public string MsgErro { get => msgErro; set => msgErro = value; }

        public Aluno(double nota1, double nota2, double nota3, double nota4, string nome, int ra)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.nome = nome;
            this.ra = ra;
        }

        public Aluno() { }

        public double Calcmedia()
        {
            //string msg;

            //if (this.nota1 < 1 || this.nota1 > 10)
            //{
            //    msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            //}
            //else if (this.nota2 < 1 || this.nota2 > 10)
            //{
            //    msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            //}
            //else if (this.nota3 < 1 || this.nota3 > 10)
            //{
            //    msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            //}
            //else if (this.nota4 < 1 || this.nota4 > 10)
            //{
            //    msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            //}

            return this.media = ((this.nota1 * 2) + (this.nota2 * 3) + (this.nota3 * 2) + (this.nota4 * 3)) / 4;
            
        }

        //media < 4 REPROVADO
        //media < 6 RECUPERAÇÃO
        //else { aprovado }
        public string Situacao()
        {
            string msg;
            if (this.media < 4)
            {
                return msg = "Reprovado";
            }
            else if (this.media < 6)
            {
                return msg = "Recuperação";
            }
            return msg = "Aprovado";
        }

        public bool Excluir(bool exclude)
        {            
            if (exclude)
            {
                return true;
            }
            return false;
        }

        public void Enviar(
            string nome,
            //int ra,
            double nota1,
            double nota2,
            double nota3,
            double nota4
            //,double media
            )
        {
            nome = this.nome;
            //ra = this.ra;
            nota1 = this.nota1;
            nota2 = this.nota2;
            nota3 = this.nota3;
            nota4 = this.nota4;
            //media = this.media;
        }

        public Aluno buscarPorNumero(int numero)
        {
            foreach (Aluno c in this.aluninho)
            {
                if (c.ra == numero)
                {
                    return c;
                }
            }
            return null;
        }

        public bool addConta(Aluno aluno)
        {
            if (this.buscarPorNumero(aluno.ra) == null)
            {
                this.aluninho.Add(aluno);
                return true;
            }
            this.msgErro = "Conta já existe";
            return false;
        }
    }
}
