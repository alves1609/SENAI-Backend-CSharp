using System;

namespace atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());
            for(int cont = 1; cont <= n; cont++){
               if ( cont % 5 == 0){
                  Console.WriteLine("Múltiplos de 5 são "+ cont);
               }
                
            }
            
        }
    }
}
