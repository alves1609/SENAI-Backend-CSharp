using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double[] posicao = new double [10];
            for(int i= 1; i <=9; i++){
                Console.WriteLine("Digite um número ");
                posicao[i] =  double.Parse(Console.ReadLine());
 
            }
           Console.WriteLine("O ultimo numero multipo de 5 "+ posicao[9]*5);
        }
    }
}
