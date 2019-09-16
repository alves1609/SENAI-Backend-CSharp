using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            Console.WriteLine("Digite um número");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            n2 = float.Parse(Console.ReadLine());

            if(n1 > n2){
                Console.WriteLine("Numero maior " + n1, n2);
            }
            else{
                Console.WriteLine("Numero menor " + n1, n2);
            }
            
        }
    }
}
