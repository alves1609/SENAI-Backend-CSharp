using System;

namespace atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            float media;
            Console.WriteLine ("Digite seu numero:");
            N = int.Parse(Console.ReadLine());
            media = (N)*3;
            Console.WriteLine ("a multiplicação é:" + media);

            
        }
    }
}
