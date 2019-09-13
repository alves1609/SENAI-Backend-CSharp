using System;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
           float pc, pa, pf;
           Console.WriteLine("Preço da mercadoria");
           pc = int.Parse(Console.ReadLine());
           Console.WriteLine("Porcentual de acrescimo");
           pa = int.Parse(Console.ReadLine());
           pf = pc+ ((pa/100)*pc);
           Console.WriteLine($"preço final é: {pf}");

            


        }
    }
}
