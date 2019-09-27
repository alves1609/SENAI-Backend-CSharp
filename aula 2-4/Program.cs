using System;

namespace aula_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            string final;
            string resultado;
            Console.WriteLine("Digite a placa do seu carro");
            placa = Console.ReadLine();
            //quantidade de caracter de um elemento
            int caracteres = placa.Length;

            //pegar ultimo numero
            // se usa o metodo substring
            final = placa.Substring(caracteres - 1);

            if(final == "1" || final == "2"){
                resultado = "IF/ELSE - Seu rodizio é na segunda-feira";
            }else if(final == "3" || final == "4"){
                resultado = "IF/ELSE - Seu rodizio é na terça-feira";
            }else if(final == "5" || final == "6"){
                resultado = "IF/ELSE - Seu rodizio é na quarta-feira";
        } else if(final == "7" || final =="8"){
            resultado = "IF/ELSE - Seu rodizio é na quinta-feira";
        }else if(final == "9" || final == "0"){
             resultado = "IF/ELSE - Seu rodizio é na sexta-feira";
        }else{
             resultado = "IF/ELSE - Placa Inválida";
        }
        Console.WriteLine(resultado);

        switch(final){
            case "1":
            resultado = "Switch - segunda-feira";
            break;

            case "2":
             resultado = "Switch - segunda-feira";
            break;

            case "3":
             resultado = "Switch - terça-feira";
            break;

            case "4":
             resultado = "Switch - terça-feira";
            break;
            
            case "5":
             resultado = "Switch - quarta-feira";
            break;

            case "6":
             resultado = "Switch - quarta-feira";
            break;

            case "7":
             resultado = "Switch - quinta-feira";
            break;

            case "8":
             resultado = "Switch - quinta-feira";
            break;

            case "9":
             resultado = "Switch - sexta-feira";
            break;

            case "0":
             resultado = "Switch - sexta-feira";
            break;

            default:
            resultado = "Switch - Entrada inválida";
            break;
        }
        Console.WriteLine(resultado);
        }
        }
        }
    

