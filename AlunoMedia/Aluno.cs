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
        public double media;

        public double Calcmedia()
        {
            double media;
            media = (this.nota1 + this.nota2 + this.nota3 + this.nota4) / 4;
            if (this.nota1 < 0 && this.nota1 > 11)
            {
                return 0;
            }
            else if (this.nota2 < 0 && this.nota2 > 11)
            {
                return 0;
            }
            else if (this.nota3 < 0 && this.nota3 > 11)
            {
                return 0;
            }
            else if (this.nota4 < 0 && this.nota4 > 11)
            {
                return 0;
            }
            return media;
        }
    }
}
