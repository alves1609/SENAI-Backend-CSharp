using System;

namespace atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
           double salario = 0;
           int func = 0;
           Console.WriteLine("Quantidade de funcionario");
           func = int.Parse(Console.ReadLine());
          
           for(int cont = 1; cont <= func; cont++){
                Console.WriteLine("Salario");
                salario += int.Parse(Console.ReadLine());
              
           }
            double media = salario / func;
              Console.WriteLine("Media do Salario da empresa é " + media);
        }
    }
}
