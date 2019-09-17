using System;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pedido;
            string resultado;
            Console.WriteLine("Digite seu pedido ");
            pedido =  Console.ReadLine();

            switch (pedido)
            {
                case "1":
                resultado = "Hamburgue";
                // faça algo
                break;

                case "2":
                resultado = "Cheese Salada";
                // faça algo
                break;

                case "3":
                resultado = "Cheese burgue";
                break;

                case "4":
                resultado = "Cheese bacon";
                break;

                default:
                resultado = "Entrada Inválida";
                break;
            }
            Console.WriteLine(resultado);           
        }
    }
}
