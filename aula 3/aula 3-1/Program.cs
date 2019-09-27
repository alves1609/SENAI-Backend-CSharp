using System;

namespace aula_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int acumuladora = 0;
            int cont = 1;
            

            do{
                
                Console.WriteLine("Digite um número");
                numero = int.Parse( Console.ReadLine());

                if(numero  % 3 ==  0){
                            
                   acumuladora += numero;
                }

                cont++;
            }while( cont <= 4);
            

            Console.WriteLine("resultado " + acumuladora);
        
    }
}
}
