using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número! \n");
            int num1 = int.Parse(Console.ReadLine();
            Console.WriteLine("Digite o segundo número! \n");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("{num2} é igual a {num2}! \n");
            }
            else
            {
                Console.WriteLine("{num2} é diferente de {num2}! \n");

            }

            if (num1 > num2)
            {
                Console.WriteLine("{num2} é maior que {num2}! \n");
            }
            else
            {
                Console.WriteLine("{num2} é menor que {num2}! \n");
            }


        }
    }
}
