using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float sf, por, vendas, final;
            float rf;
            Console.WriteLine("Digite o salario");
            sf = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu porcentual");
            por = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor das Vendas");
            vendas = int.Parse(Console.ReadLine());
            final = sf + (vendas * por/100);
            rf = sf+final;

            Console.WriteLine("sera " + rf);
        }
    }
}
