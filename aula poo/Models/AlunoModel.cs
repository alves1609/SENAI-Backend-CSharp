namespace aula_poo.Models
{
    public class AlunoModel
    {
        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome{get;set;}
        /// <summary>
        /// Nome do Curso
        /// </summary>
        /// <value>string</value>
        public string Curso{get;set;}
       /// <summary>
       /// seu ra
       /// </summary>
       /// <value>string</value>
        public string RA{get;set;}
        /// <summary>
        /// sua idade
        /// </summary>
        /// <value>int</value>
        public int Idade{get;set;}
        /// <summary>
        /// o aluno quer estudar
        /// </summary>
        public void Estudar(){
            System.Console.WriteLine("Estou Estudando!");
        }
        /// <summary>
        /// pede intervalo
        /// </summary>
        public void PedirIntervalo(){
            System.Console.WriteLine("Libera o intervalo aee!!!!");
            System.Console.WriteLine("EU QUERO CAFÉÉÉ!!!!");
        }
        /// <summary>
        /// Pede ajuda
        /// </summary>
        public void Pedirajuda(){
            System.Console.WriteLine("OOOOOO Paulo, chega ae!!!");
            System.Console.WriteLine("OOOO Ariel!!!");
        }
    }
}