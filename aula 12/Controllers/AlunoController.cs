using System;
using System.IO;
using aula_12.Model;

namespace aula_12.Controllers {
    public class AlunoController {
        AlunoModel Aluno = new AlunoModel ();

        string bolsa;

        public void InformacaoAluno () {

            try {
                System.Console.WriteLine ("Digite seu nome ");
                Aluno.Nome = Console.ReadLine ();

                System.Console.WriteLine ("Digite seu curso ");
                Aluno.Curso = Console.ReadLine ();

                System.Console.WriteLine ("Digite sua idade ");
                Aluno.Idade = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite seu RG ");
                Aluno.RG = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Você é bolsista (s/n)");
                bolsa = Console.ReadLine();

                if (bolsa == "s")
                {
                    
                    Aluno.Bolsista = true;
                    

                }else if (bolsa == "n")
                {
                    
                    Aluno.Bolsista = false;
                    
                }

                

            } catch (Exception ex) {
                System.Console.WriteLine ("Desculpe : (houve um erro na aplicação )");
                SalvarErros (ex);

            }

        }

        public void Exibir () {
            System.Console.WriteLine (Aluno.Nome);
            System.Console.WriteLine (Aluno.Idade);
            System.Console.WriteLine (Aluno.RG);
            System.Console.WriteLine (Aluno.Curso);
            System.Console.WriteLine (Aluno.Bolsista);
        }

        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();

        }
    }
}