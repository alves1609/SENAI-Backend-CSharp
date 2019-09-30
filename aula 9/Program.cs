using System;
using aula_9.Controllers;

namespace aula_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosControllers produto1 = new ProdutosControllers();

            produto1.CadastrarProdutos();
            produto1.ExibirProduto();
        }
    }
}
