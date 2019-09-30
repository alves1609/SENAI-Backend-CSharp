using System;
using System.IO;
using aula_9.Models;

namespace aula_9.Controllers {
    public class ProdutosControllers {
        ProdutosModel Produto = new ProdutosModel ();

        public void CadastrarProdutos () {
            try {

                System.Console.WriteLine ("Digite um ID do Produto: ");
                Produto.IdProduto = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite o nome do produto: ");
                Produto.NomeProduto = Console.ReadLine ();

                System.Console.WriteLine ("Descreva o Produto: ");
                Produto.Descricao = Console.ReadLine ();

                System.Console.WriteLine ("Digite o preço do Produto: ");
                Produto.Preco = double.Parse (Console.ReadLine ());

            } catch (Exception ex) {

                System.Console.WriteLine ("Desculpe : (houve um erro na aplicação )");
                SalvarErros (ex);

            }

        }

        public void ExibirProduto () {

            System.Console.WriteLine (Produto.IdProduto);
            System.Console.WriteLine (Produto.NomeProduto);
            System.Console.WriteLine (Produto.Descricao);
            System.Console.WriteLine (Produto.Preco);

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