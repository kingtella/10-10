using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média das notas");
            Console.WriteLine("----------------");
            Console.WriteLine();


            int nota, soma = 0;


            int contIdades = 0;

            do
            {
                Console.Write("Digite a Nota (Ou 0 para parar o programa): ");
                nota = int.Parse(Console.ReadLine());
                soma = soma + nota; //ou soma += num;

                contIdades++;

            } while (nota > 0);

            double media = soma / contIdades;

            Console.WriteLine("A Média das Notas digitadas é: {0} ", media);
            Console.ReadKey();
        }
    }
}
