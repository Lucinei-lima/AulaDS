using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex4
    {
        static void Main4(string[] args)
        {
            int numA, numB, numC, numD;
            Console.WriteLine("Digite um valor!");
            numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor!");
            numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor!");
            numC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o último valor!");
            numD = int.Parse(Console.ReadLine());


            int soma1 = numA + numB;
            int soma2 = numA + numC;
            int soma3 = numA + numD;
            int soma4 = numB + numC;
            int soma5 = numB + numD;
            int soma6 = numC + numD;
            int mult1 = numA * numB;
            int mult2 = numA * numC;
            int mult3 = numA * numD;
            int mult4 = numB * numC;
            int mult5 = numB * numD;
            int mult6 = numC * numD;

            Console.WriteLine($"\n{soma1}, {soma2}, {mult1}, {mult2}");
        }
    }
}
