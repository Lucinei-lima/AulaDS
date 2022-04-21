using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex6
    {
        static void Main6(string[] args)
        {


            int f, c;
            Console.WriteLine("Digite uma temperatura em graus Celsius");
            c = int.Parse(Console.ReadLine());

            f = (9 * c + 160) / 5;

            Console.WriteLine($"\n A temperatura em Fahrenheit é {f}");
        }
    }
}
