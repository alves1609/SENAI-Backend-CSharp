using System;

namespace função
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, porcentagem;
            System.Console.WriteLine("Digite um valor ");
            valor = double.Parse (Console.ReadLine());

            System.Console.WriteLine("Digite a porcentagem ");
            porcentagem = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine(VDesconto(valor , porcentagem));
        
            
        }
        static double VDesconto (double valor, double porcentagem){
            double Desconto = (valor * porcentagem) / 100;
            valor = valor - Desconto;
            return valor;
        }
    }
}
