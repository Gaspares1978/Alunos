using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste04
{
    class Aluno
    {
        public string notas;
        public double nota1, nota2, nota3;
        public string nome;

        public double notaFinal()
        {
            return nota1 + nota2 + nota3;
        }
        public bool Aprovado()
        {
            if (notaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            public double QuantoFalta()
            {
                if (Aprovado())
                {
                    return 0.0;
                }
                else
                {
                    return 60.0 - notaFinal();
                }
            }
        }

    }


