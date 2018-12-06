using System;
using System.Globalization;

namespace Teste04
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();
            x.nome = Console.ReadLine();
            x.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = "
+ x.notaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (x.Aprovado())

            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram" + x.QuantoFalta().ToString("F2", CultureInfo.InvariantCulture)+ "Pontos");
            }
            Console.ReadLine();
        }
    }
}
