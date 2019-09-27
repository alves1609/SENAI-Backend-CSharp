using System;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            diadasemana();
        }
        static void diadasemana(){
            System.Console.WriteLine(DateTime.Now.ToString());
            System.Console.WriteLine(DateTime.Now.DayOfWeek);
        
        }
    }
}
