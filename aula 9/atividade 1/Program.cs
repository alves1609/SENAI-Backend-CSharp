using System;
using atividade_1.Controllers;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaControllers pessoa1 = new PessoaControllers();

            pessoa1.CadPessoa();
            pessoa1.Exibir();
        }
    }
}
