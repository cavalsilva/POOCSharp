using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoRicardo = new ContaCorrente();

            contaDoRicardo.titular = "Ricardo";
            contaDoRicardo.agencia = 3032;
            contaDoRicardo.numero = 346458;
            contaDoRicardo.saldo = 100.00;

            Console.WriteLine(contaDoRicardo.titular);
            Console.WriteLine("Agência: "+ contaDoRicardo.agencia);
            Console.WriteLine("Número: " + contaDoRicardo.numero);
            Console.WriteLine("Saldo: " + contaDoRicardo.saldo);
            Console.ReadLine();
        }
    }
}
