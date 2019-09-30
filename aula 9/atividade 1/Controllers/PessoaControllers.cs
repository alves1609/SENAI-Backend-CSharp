using System;
using System.IO;
using atividade_1.Models;

namespace atividade_1.Controllers
{
    public class PessoaControllers{
        PessoaModel pessoa = new PessoaModel();

        public void CadPessoa (){

            try
            {
                System.Console.WriteLine("Digite seu nome: ");
            pessoa.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite sua idade: ");
            pessoa.Idade = int.Parse( Console.ReadLine());
            
            System.Console.WriteLine("Digite seu peso: ");
            pessoa.Peso = double.Parse( Console.ReadLine());
            
            System.Console.WriteLine("Digite sua altura: ");
            pessoa.Altura = double.Parse( Console.ReadLine());
            
            }
            catch (Exception ex)
            {
                 System.Console.WriteLine ("Desculpe : (houve um erro na aplicação )");
                SalvarErros (ex);

                
            }
        }
        public void Conta(double altura, double peso){
           double imc = 0;
           imc = pessoa.Peso/ (pessoa.Altura*pessoa.Altura);
           System.Console.WriteLine("seu imc é "+ imc);

           if (imc < 18.5){
               System.Console.WriteLine("Abaixo do peso ");
           } else if(imc >= 18.5 && imc <=25){
               System.Console.WriteLine("Peso normal ");
           } else if(imc >=26 && imc <= 30){
               System.Console.WriteLine("Sobre peso ");
           } else if(imc >=31 && imc <=35){
               System.Console.WriteLine("obesidade grau 1 ");
           }else if(imc>= 36 && imc <= 39){
               System.Console.WriteLine("obesidade grau 2");
           } else if(imc >=40){
               System.Console.WriteLine("obesidade grau 3");
           }
           System.Console.WriteLine(imc);
        }

        public void Exibir()
        {
            System.Console.WriteLine(pessoa.Nome);
            System.Console.WriteLine(pessoa.Idade);
            System.Console.WriteLine(pessoa.Peso);
            System.Console.WriteLine(pessoa.Altura);
            Conta(pessoa.Altura , pessoa.Peso);

        }
        private void SalvarErros (Exception ex) 
        {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();

        }
    }
}