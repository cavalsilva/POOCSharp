using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente(3032, 346458);
            Console.WriteLine("Conta: " + conta1.Agencia);
            Console.WriteLine("Agência: " + conta1.Numero);

            Console.WriteLine();

            ContaCorrente conta2 = new ContaCorrente(3032, 2568547);
            Console.WriteLine("Conta: " + conta2.Agencia);
            Console.WriteLine("Agência: " + conta2.Numero);

            Console.WriteLine();

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
