using System;
using atividade3.Model;

namespace atividade3.Controllers
{
    public class ProdutosControllers
    {
        ProdutosModel produtos = new ProdutosModel();

        public void CadProduto(){
            System.Console.WriteLine("Nome do produto ");
            produtos.Produto = Console.ReadLine();
            
        }

        public void ReservaProduto(){
            System.Console.WriteLine("Gostaria de reserva? ");
            produtos.Reserva = Console.ReadLine();
            if(produtos.Reserva == "sim"){
                System.Console.WriteLine("seu produto foi reservado");
            } else{
                System.Console.WriteLine("seu produto não foi reservado ");
            }
        }

    }
}