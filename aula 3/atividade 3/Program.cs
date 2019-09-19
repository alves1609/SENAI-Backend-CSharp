using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
             int numero=0;
             Console.WriteLine("Digite um número");
                numero=int.Parse(Console.ReadLine());
            for(int cont=1; cont <= 10; cont++){
                Console.WriteLine($"{cont}*{numero} = {cont*numero}");
            }
        }
    }
}
