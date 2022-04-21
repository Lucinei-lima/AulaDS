using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex3
    {
        static void Main3(string[] args)
        {
            int idVendedor, codPeça, quantVenda;
            Double valUnit, comis;
            Console.WriteLine("Digite o id do vendedor!");
            idVendedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código da peça!");
            codPeça = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças!");
            quantVenda = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça!");
            valUnit = int.Parse(Console.ReadLine());
            comis = ((quantVenda * valUnit) / 100) * 5;
            Console.WriteLine($"\n A comição do vendedor {idVendedor} é: {comis}!");
        }
    }
}
