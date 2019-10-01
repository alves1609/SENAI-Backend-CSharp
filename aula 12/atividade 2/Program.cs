using System;
using atividade_2.Controller;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {


            CelularControllers celular = new CelularControllers();

            celular.Descricao();

           
            
            celular.Ligar();

        

            celular.Ligacao();


            celular.Mensagem();
            celular.Desligar();
        }
    }
}
