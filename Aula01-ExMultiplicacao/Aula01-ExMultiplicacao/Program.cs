using System;

namespace Aula01_ExMultiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int nrUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int nrDois = int.Parse(Console.ReadLine());
            
            int nrResp = nrUm * nrDois;

            Console.WriteLine(string.Format("Esta multiplicação resultou em {0}.", nrResp));
            Console.ReadKey();
        }
    }
}
