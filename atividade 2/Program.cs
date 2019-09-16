using System;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.WriteLine("Digite nota 1");
            n1 = double.Parse (Console.ReadLine());
            Console.WriteLine("Digite nota 2");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 3");
            n3 = double.Parse(Console.ReadLine());
            media = (n1+n2+n3)/3;
            if(media >=6) {
                Console.WriteLine($"Media: {media} Aluno Aprovado");
            }
            else {
                Console.WriteLine($"Media: {media} Aluno Reprovado");
            }


        }
    }
}
