using System;

namespace atividade_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //foi declarado falso por padrão
            //mudamos o estado da variávil para verdadeira, caso entre na condição maior de idade

            bool entrada = false;
            int idade;
            string retorno;
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
            if (idade > 17){
                entrada = true;
            }
            if(entrada == true){
                retorno = "Entrada Permitida!!!";
            }
            else{
                retorno = "Entrada não permitida :(";
            }
            Console.WriteLine(retorno);
        }
    }
}
