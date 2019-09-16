using System;

namespace atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sf, conta, soma;
            Console.WriteLine("Digite seu salário");
            sf = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor das contas");
            conta = int.Parse(Console.ReadLine());
            soma = sf - conta;
            Console.WriteLine("você tera " + soma);

    }
}
}
