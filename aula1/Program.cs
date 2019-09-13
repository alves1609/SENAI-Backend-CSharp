using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //somente declaramos, sem atribuir valor
            int num1 = 2; 
            
            //declaramos atribuindo um valor
            int num2 = 5;
            
            //declaramos diversas variaveis do mesmo tipo
            int num3, num4, num5;

            //variavel do tipo real
            float  media;

            //variavel tipo logico (booleana)
            bool resultado = false;

        // variavel do tipo texto (caracteres)
         string nomeAluno;

        //Quebra Linha
        Console.WriteLine();

        //Escreve em uma linha quebrando-a
         Console.WriteLine ("Bem vindos a nossa primeira aplicação!");

         //Continua Escrevendo na mesma Linha
         Console.Write ("Digite ");
         Console.Write ("seu nome:");

        //Capturo o dado digitado pelo usuário e salvo na variavel
         nomeAluno = Console.ReadLine ();

        //concatenação
        Console.WriteLine(nomeAluno + ", Agora digite sua aprimeira nota:");
        num3 = int.Parse(Console.ReadLine());
            
        //Interpolação
        Console.WriteLine($"Sua primeira nota {num3} ");

        Console.WriteLine("Digite sua segunda nota: ");
        num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua terceira nota:");
        num5 = int.Parse(Console.ReadLine());

        media = (num3 + num4 + num5) /3;

        Console.WriteLine ("Sua média é:" + media);

        }
    }
}
