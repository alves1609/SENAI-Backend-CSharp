using System;

namespace aula_3 {
    class Program {
        static void Main (string[] args) {
            // //LAÇO CONTADO - FOR - INCREMENTO (+)
             for (int cont1 = 1; cont1 <= 100; cont1++) {

                 //Verificamos se o número é diferente de par
                if (cont1 % 2 != 0) {
                     Console.WriteLine ("for 0- 100 " + cont1);
                 }
             }

            //LAÇO CONTADO - FOR - DECREMENTO (-)
             for (int cont1 = 100; cont1 >= 0; cont1--) {
                  if (cont1 % 2 != 0) {
                     Console.WriteLine ("for 100- 0 " + cont1);
             }
            }

            //LAÇO CONDICIONAL - WHILE

            double acumuladora = 0;
            double nota = 0;
            int cont3 = 0;
            string sair = "";

            while(sair != "sim"){
                
                Console.Write("Digite a nota do aluno ");
                nota = double.Parse(Console.ReadLine());

                acumuladora += nota;
                cont3++;

                Console.WriteLine("Deseja sair da aplicação? sim/não ");
                sair = Console.ReadLine() .ToLower();
                }

                Console.WriteLine("Média das notas: " + (acumuladora / cont3 ) );
            }
        }
    }
