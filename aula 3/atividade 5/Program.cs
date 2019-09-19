using System;

namespace atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int tatoln = 0;
            int quantn  = 0;
           
            for(int cont= 1; cont <= 20; cont++ ){
                 Console.WriteLine("Digite um número ");
                n = int.Parse(Console.ReadLine());
                if(n > 0){
                    Console.WriteLine(n);
                } else {
                    tatoln+=n;
                    quantn+=1;
                }
            }

            double media= tatoln/quantn;
            Console.WriteLine("O cálculo de números negativos é " + media*-1);
        }
    }
}
