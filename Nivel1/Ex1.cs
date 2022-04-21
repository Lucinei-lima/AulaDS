using System;

namespace Nivel1
{
    class Ex1
    {
        static void Main1(string[] args)
        {
            int minimo, maximo, medio;
            Console.WriteLine("Digite o estoque mínimo! \n");
            minimo = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o estoque maxímo! \n");
            maximo = int.Parse(Console.ReadLine());
                        
            medio = (minimo + maximo)/2;
            Console.WriteLine($"\n O estoque medio é {medio}!");
        }
    }
}
