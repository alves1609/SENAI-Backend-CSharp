using System;

namespace _3 {
    class Program {
        static void Main (string[] args) {
            string[] nomepro = new string[12];
            string[] cor = new string[12];
            double[] tamanho = new double[12];
            double[] preco = new double[12];

            for (int i = 0; i <= 11; i++) {
                Console.WriteLine ("Pro");
                nomepro[i] = Console.ReadLine ();
                Console.WriteLine ("cor");
                cor[i] = Console.ReadLine ();
                Console.WriteLine ("tamanho");
                tamanho[i] = double.Parse (Console.ReadLine ());
                Console.WriteLine ("Preco");
                preco[i] = double.Parse (Console.ReadLine ());

            }
            for (int i = 0; i <= 11; i++) {
                Console.WriteLine ($"Nome do pro {nomepro}");
                Console.WriteLine ($"Cor do prod {cor} ");
                Console.WriteLine ($"Tamanho do produto {tamanho}");
                Console.WriteLine ($"Preço do produto {preco}");

            }
        }
    }
}