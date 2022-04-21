using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex8
    {
        static void Main()
        {
            double raio, altura, volume;

            Console.WriteLine("Para saber o volume de uma lata de oleo digite o raio da lata ! \n");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a altura da lata \n");
            altura = double.Parse(Console.ReadLine());

            volume = 3.14159 * raio * raio * altura;

            Console.WriteLine($"O volume da lata é: {volume}!");
        }
    }
}
