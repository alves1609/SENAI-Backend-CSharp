using System;

namespace aula_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] media = new double[10];

            for( int i = 0; i <= 10; i++){

                Console.WriteLine("Digite uma média ");
                media[i] = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine(media[3]);
            Console.WriteLine();

            for(int i = 0; i <=media.Length -1 ; i++){

                Console.WriteLine("Média "+ media[i]);
            }
            
        }
    }
}
