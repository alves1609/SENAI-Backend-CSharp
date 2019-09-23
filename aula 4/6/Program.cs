using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10];
            int[] n2 = new int[10];
            int[] n3 = new int[10];

            for(int i =0; i<=9; i++){
                Console.WriteLine("Digite um número ");
                n1[i] =int.Parse (Console.ReadLine());
            }
            
            for(int i =0; i<=9; i++){
                Console.WriteLine("Digite outro numero ");
                n2[i]=int.Parse(Console.ReadLine());
            }
           for(int i=0; i<=9; i++){
               n3[i]+=n1[i];
               n3[i]+=n2[i];
               Console.WriteLine(n3[i]);
           }
            
           
        }
    }
}
