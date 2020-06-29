using System;

namespace TesteGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá,meu teste Git");
            Console.WriteLine("Digite um numero inteiro");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
