using System;

namespace CadFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("+++Cadastro de Funcionários+++");
            Console.WriteLine("==============================");

            Console.WriteLine("Digite o Nome do Funcionário: ");
            string dsNome = Console.ReadLine();

            Console.WriteLine("Indique o Sexo: ");
            char dsSexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Informe as Data de Nascimento: ");
            DateTime dtNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Insira o valor do Salário: ");
            Decimal nrSalario = Convert.ToDecimal(Console.ReadLine());

            string mensagem = "RESUMO";
            mensagem += "\nNome: " + dsNome;
            mensagem += "\nSexo: " + dsSexo;
            mensagem += "\nNascimento: " + dtNascimento;
            mensagem += "\nSalário: " + nrSalario;

            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
