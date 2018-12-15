using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Ricardo";

            Console.WriteLine(conta.titular);
            Console.WriteLine("Número: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);

            conta.saldo = 200;

            Console.WriteLine("Saldo Atualizado: " + conta.saldo);

            Console.ReadLine();
        }
    }
}
