using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex2
    {
        static void Main2(string[] args)
        {
            int dolar, cotDolar, reais;
            Console.WriteLine("Digite a cotação do dolar!");
            cotDolar = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um valor em dolar");
            dolar = int.Parse(Console.ReadLine());
            reais = dolar * cotDolar;
            Console.WriteLine($"\n A quantidadeem reais é: {reais}!");
        }
    }
}

