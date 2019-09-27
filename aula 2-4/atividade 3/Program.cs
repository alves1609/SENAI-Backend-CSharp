using System;

namespace atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso;
            int planeta;
            string resultado;
            Console.WriteLine("Digite seu peso");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero do planeta");
            planeta = int.Parse(Console.ReadLine());
           
            switch (planeta)
            {
                case 1 :
                   planeta = peso* 0.37;
                    resultado = "Mercúrio " + planeta;
                break;
                 
                 case 2:
                    calcule = (planeta = peso* gravidade);
                    resultado = "Vênus " + calcule;
                break;

                    case 3:
                   calcule = (planeta = peso* gravidade);
                    resultado = "Marte " + calcule;
                break;

                 case 4:
                  calcule =  (planeta = peso* gravidade);
                    resultado = "Júpiter " + calcule;
                break;

                 case 5:
                   calcule = (planeta = peso* gravidade);
                    resultado = "Saturno " + calcule;
                break;

                 case 6:
                   calcule = (planeta = peso* gravidade);
                    resultado = "Urano " + calcule;
                break;

                default:
                resultado = "Entrada Inválida";
                break;
            }
                Console.WriteLine(resultado);
        }
    }
}
