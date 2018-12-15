using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoRicardo = new ContaCorrente();
            contaDoRicardo.titular = "Ricardo";
            contaDoRicardo.agencia = 3032;
            contaDoRicardo.numero = 346458;

            ContaCorrente contaDoRicardoSilva = new ContaCorrente();
            contaDoRicardoSilva.titular = "Ricardo";
            contaDoRicardoSilva.agencia = 3032;
            contaDoRicardoSilva.numero = 346458;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDoRicardo == contaDoRicardoSilva) );

            int idade1 = 29;
            int idade2 = 29;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade1 == idade2) );

            contaDoRicardo = contaDoRicardoSilva;
            Console.WriteLine(contaDoRicardo == contaDoRicardoSilva);

            contaDoRicardo.saldo = 300;
            Console.WriteLine(contaDoRicardo.saldo);
            Console.WriteLine(contaDoRicardoSilva.saldo);

            Console.ReadLine();
        }
    }
}
