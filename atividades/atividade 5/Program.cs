using System;

namespace atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float sf, tv, comissão, final, rf;
            string nome;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu salário");
            sf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua comissão");
            comissão = int.Parse(Console.ReadLine());

            Console.WriteLine("Total das Vendas");
            tv = int.Parse(Console.ReadLine());
            final = sf + (tv * comissão/100);
            rf = sf+final;

            Console.WriteLine("sera " + rf);
        }
    }
}
