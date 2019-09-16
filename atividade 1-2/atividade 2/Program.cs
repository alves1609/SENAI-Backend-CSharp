using System;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
           float pt, resultado;
           Console.WriteLine("Digite Preço total");
           pt = float.Parse(Console.ReadLine());
           resultado = (pt)-25; 


           if (resultado > 100){
               Console.WriteLine("Desconto" + pt);
           }
           else{
               Console.WriteLine("Não tera desconto " + pt);
           }
        }
    }
}
