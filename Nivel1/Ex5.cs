using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex5
    {
        static void Main5(string[] args)
        {
            int tempViagem, velMedia;
            Console.WriteLine("Digite o tempo de viagem!");
            tempViagem = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade media!");
            velMedia = int.Parse(Console.ReadLine());

            int distancia = tempViagem * velMedia;
            int litUsados = distancia / 12;

            Console.WriteLine($"\n A velocidade media é {velMedia}, o tempo gasto foi {tempViagem}, a distancia percorrida foi {distancia}, e a quantidade de litros usados foi {litUsados}");
        }
    }
}
