using System;
using System.IO;
using atividade_2.Model;

namespace atividade_2.Controller
{
    public class CelularControllers
    {
        CelularModel celular = new CelularModel();
    string ligar;
        public void Descricao (){
            try
            {
                System.Console.WriteLine("Cor do celular ");
            celular.Cor = Console.ReadLine();

            System.Console.WriteLine("Modelo do celular ");
            celular.Modelo = Console.ReadLine();
            
            System.Console.WriteLine("Tamanho do celular ");
            celular.Tamanho = Console.ReadLine();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine ("Desculpe : (houve um erro na aplicação )");
                SalvarErros (ex);
            }
            
        }

            public void Ligar (){
                celular.Ligar = true;
                System.Console.WriteLine("Celular Ligado ");
               
                    
            } 
                
                
            


            public void Desligar (){
                celular.Ligar = false;
                System.Console.WriteLine("Celular Deligado ");
            }


            public void Ligacao (){
                if(celular.Ligar == true){
                    System.Console.WriteLine("Pode fazer ligação ");
                } else {
                    System.Console.WriteLine("Não pode fazer ligação");
                }
            }

            public void Mensagem (){
                if(celular.Ligar == true){
                    System.Console.WriteLine("pode mandar mensagem ");
                } else {
                    System.Console.WriteLine("Não pode mandar mensagem ");
                }
            }

            public void Exibir (){
                System.Console.WriteLine(celular.Ligar);
                System.Console.WriteLine(celular.Cor);
                System.Console.WriteLine(celular.Modelo);
                System.Console.WriteLine(celular.Tamanho);
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