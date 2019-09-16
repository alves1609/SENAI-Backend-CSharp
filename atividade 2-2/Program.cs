using System;

namespace atividade_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, media;
            string resultado;
            Console.WriteLine("Digite nota 1");
            n1 = float.Parse (Console.ReadLine());
            Console.WriteLine("Digite nota 2");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 3");
            n3 = float.Parse(Console.ReadLine());
            media = (n1+n2+n3)/3;
            if(media >=6) {
            resultado = "Aprovado";
            }
            else if(media < 6 && media >= 4){
                resultado = "Recuperação";
            }
            else{
                
                resultado = "Reprovado";
            }
            Console.WriteLine($"Media: {media} Aluno {resultado}");
        }
    }
}
