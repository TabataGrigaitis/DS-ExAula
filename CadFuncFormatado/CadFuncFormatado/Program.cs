using System;

namespace CadFuncFormatado
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
            char dsSexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe as Data de Nascimento: ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do Salário: ");
            Decimal nrSalario = decimal.Parse(Console.ReadLine());

            string mensagem = "RESUMO";
            mensagem += string.Format("\nNome: {0}", dsNome);
            mensagem += string.Format("\nSexo: {0}", dsSexo);
            mensagem += string.Format("\nNascimento: {0:dd/MM/yyyy}", dtNascimento );
            mensagem += string.Format("\nSalário: {0:c2}", nrSalario);

            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
