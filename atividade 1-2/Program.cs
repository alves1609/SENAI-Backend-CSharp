using System;

namespace atividade_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float sf, dt, m;
            
            Console.WriteLine("Digite seu salário");
            sf = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite suas despesas");
            dt = float.Parse(Console.ReadLine());

            Console.WriteLine("Seu salário é");

            m= sf-dt;

            if(m >0){
                Console.WriteLine("Positivo "+ m);
            }
            else {
                Console.WriteLine("Negativo " + m);
            }

        }
    }
}
