using System;

namespace aula_3 {
    class Program {
        static void Main (string[] args) {
            // //LAÇO CONTADO - FOR - INCREMENTO (+)
            // for (int cont = 1; cont <= 100; cont++) {

            //     //Verificamos se o número é diferente de par
            //     if (cont % 2 != 0) {
            //         Console.WriteLine ("for 0- 100 " + cont);
            //     }
            // }

            // //LAÇO CONTADO - FOR - DECREMENTO (-)
            // for (int cont = 100; cont >= 0; cont--) {
            //      if (cont % 2 != 0) {
            //         Console.WriteLine ("for 100- 0 " + cont);
            // }
            // }

            //LAÇO CONDICIONAL - WHILE

            double acumuladora = 0;
            double nota = 0;
            int cont = 0;
            string sair = "";

            while(sair != "sim"){
                
                Console.Write("Digite a nota do aluno ");
                nota = double.Parse(Console.ReadLine());

                acumuladora += nota;
                cont++;

                Console.WriteLine("Deseja sair da aplicação? sim/não ");
                sair = Console.ReadLine() .ToLower();
                }

                Console.WriteLine("Média das notas: " + (acumuladora / cont ) );
            }
        }
    }
