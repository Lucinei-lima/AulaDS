using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel1
{
    class Ex9
    {
        static void Main9(string[] args)
        {
            int anos, meses, dias, diasTotais;
            Console.WriteLine("Digite a sua idade em anos meses e dias nesta ordem! \n Anos: ");
            anos = Console.ReadLine();
            Console.WriteLine("\n meses: ");
            meses = Console.ReadLine();
            Console.WriteLine("\n Dias: ");
            dias = Console.ReadLine();
            diasTotais = (anos * 365) + (meses * 30) + dias;
            Console.WriteLine($"\n Faz {diasTotais} que você nasceu!");
        }
    }
}
