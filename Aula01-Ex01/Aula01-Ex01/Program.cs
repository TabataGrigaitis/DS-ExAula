using System;

namespace Aula01_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data de seu nascimento no formato dd/MM/yyyy");

            //armazenado o que o usuário digitar numa variavel.
            DateTime dtNascimento = Convert.ToDateTime(Console.ReadLine());

            //guardando em uma variavel numerica a quantidade de dias vividos.
            int nrDias = DateTime.Now.Subtract(dtNascimento).Days;

            //retornando ao usuario informações sobre seu nascimento.
            //Console.WriteLine("Você já viveu " + nrDias + " Dias.");
            //informações v2
            Console.WriteLine(string.Format("Você já viveu {0} dias. ", nrDias));

            Console.ReadKey();
        }
    }
}
