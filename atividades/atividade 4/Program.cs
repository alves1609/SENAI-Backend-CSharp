using System;

namespace atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float real, dolar, conversão;
            Console.WriteLine("Digite o real");
            real = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dolar");
            dolar = int.Parse(Console.ReadLine());
            conversão = real*dolar;
            Console.WriteLine("o valor da conversão é: " + conversão );


        }
    }
}
