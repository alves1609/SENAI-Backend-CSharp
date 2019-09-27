using System;

namespace aula_5 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] data_ida = new DateTime[5];
            DateTime[] data_volta = new DateTime[5];

            string sair = "";

            while (sair != "0");

            Console.WriteLine ("Bem Vindo ao nosso sistema de passagens ");
            Console.WriteLine (@"Menu : 
            1- Cadastrar
            2- Listar Categoria 
            0- Sair");
           
            sair = Console.ReadLine();
            
            

        }
    }
}