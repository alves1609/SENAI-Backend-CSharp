using System;

namespace aula_6_2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite seu CNPJ ");
            string CNPJ = Console.ReadLine ();
            Console.WriteLine (ValidaCNPJ (CNPJ));
        }
        static bool ValidaCNPJ (string CNPJUsuario) {

            bool resultado = false;

            int[] v1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string CNPJCalculo = "";
            int resto = 0;
            int calculo = 0;
            string digito_v1 = "";
            string digito_v2 = "";

            CNPJCalculo = CNPJUsuario.Substring (0, 8);

            for (int i = 0; i <= 11; i++) {

                calculo += int.Parse (CNPJUsuario[i].ToString ()) * v1[i];

            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 2) {
                digito_v1 = "0";
            } else {
                digito_v1 = calculo.ToString ();
            }
            if (digito_v1 == CNPJUsuario[9].ToString ()) {
                resultado = true;

            }

            int[] v2 = { 6, 5, 4 ,3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            resto = 0;

            CNPJCalculo = CNPJCalculo + calculo.ToString ();
            calculo = 0;

            for (int i = 0; i <= 10; i++) {

                calculo += int.Parse (CNPJUsuario[i].ToString ()) * v2[i];

            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 2) {
                digito_v2 = "0";
            } else {
                digito_v2 = calculo.ToString ();
            }
            if (digito_v2 == CNPJUsuario[9].ToString ()) {
                resultado = true;
            }
            else{
                resultado = false;
            }

            return resultado;

        }
    }
}