using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoMedia
{
    class Aluno
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;
        public string nome;
        public int ra;
        public string situacao;

        //public Aluno(double nota1, double nota2, double nota3, double nota4, string nome, int code)
        //{
        //    this.nota1 = nota1;
        //    this.nota2 = nota2;
        //    this.nota3 = nota3;
        //    this.nota4 = nota4;
        //    this.nome = nome;
        //    this.code = code;
        //}

        public string Calcmedia()
        {
            double media;
            string msg;
            
            if (this.nota1 < 1 || this.nota1 > 10)
            {
                return msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            }
            else if (this.nota2 < 1 || this.nota2 > 10)
            {
                return msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            }
            else if (this.nota3 < 1 || this.nota3 > 10)
            {
                return msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            }
            else if (this.nota4 < 1 || this.nota4 > 10)
            {
                return msg = "Não é permitido colocar esse tipo de número, apenas de 1 a 10";
            }

            media = ((this.nota1 * 2) + (this.nota2 * 3) + (this.nota3 * 2) + (this.nota4 * 3)) / 4;
            return msg = $"A sua média é {media}";
        }

        //media < 4 REPROVADO
        //media < 6 RECUPERAÇÃO
        //else { aprovado }
    }
}
