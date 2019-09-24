using System;

namespace aula_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamamos nossa primeira função
            Console.WriteLine(BomDia());

             //Chamamos a função tipo VOID (sem retorno)
            ImprimeDataHora();

            //Chamamos nossa função que calcula a media
            double[] numeros = {2, 5, 2, 8, 9, 5};
            Console.WriteLine(CalculaMedia(numeros));

            double[] soma = {2, 4, 2, 8, 9, 5};
            Console.WriteLine(SomaValores(soma));
        }
        /// <summary>
        /// função que escreve Bom Dia, para o úsuario 
        /// </summary>
        /// <returns> Retorna o Olá Bom Dia!</returns>

        static string BomDia(){
        return "Olá, Bom Dia!";
        }

        /// <summary>
        /// Mostra a saudação no horario atual
        /// </summary>
        /// <param name="saudação"> (sorecarga de texto), um texto qualquer</param>
        /// <returns>Saudação de acordo com o horario</returns>
        static string BomDia(string saudação){

            int hora= DateTime.Now.Hour;

            if(hora <= 12 && hora >=6){
                saudação = "Bom dia! ";
            }
            else if(hora > 12 && hora <= 18){
                saudação= "Boa Tarde! ";
            }
            else{
                saudação= "Boa Noite! ";
            }

            return saudação;
        }

        /// <summary>
        /// Retorna um numero - teste de sobrecarga
        /// </summary>
        /// <param name="numero">um numero inteiro qualquer</param>
        /// <returns>Numero passado como parametro</returns>
        static int BomDia(int numero){
            return numero;
        }

        /// <summary>
        /// Retorna data e hora atual
        /// </summary>
        
        static void ImprimeDataHora(){
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour.ToString());
        }

        /// <summary>
        /// Calcula media de um valor
        /// </summary>
        /// <param name="valores">Vetor cm Valores</param>
        /// <returns>Media dos Valores</returns>

        static double CalculaMedia(double[] valores){

            double resultado = 0;
            
            for(int i = 0; i <valores.Length; i++){
                resultado = resultado + valores[i]; 
            }

            resultado = resultado / valores.Length;

            return resultado;
        }
        static double SomaValores(double[] valores){

            double result = 0;

            for(int i = 0; i < valores.Length; i++){
                result = result + valores[i];

            }

            result = result+valores.Length;

            return result;

        }
    }
}
