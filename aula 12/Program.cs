using System;
using aula_12.Controllers;

namespace aula_12
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController aluno = new AlunoController();

            aluno.InformacaoAluno();
            aluno.Exibir();
        }
    }
}
