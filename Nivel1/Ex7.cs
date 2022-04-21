using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex7
    {
        static void Main7(string[] args)
        {
            int f, c;
            Console.WriteLine("Digite uma temperatura em graus fahrenheit!");
            f = int.Parse(Console.ReadLine());

            c = (f - 32) * 5 / 9;

            Console.WriteLine($"\n A temperatura em Celsius é {c}");
        }
    }
}
