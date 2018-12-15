using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoRicardo = new ContaCorrente();
            contaDoRicardo.titular = "Ricardo";

            Console.WriteLine("O saldo do Ricardo é: " + contaDoRicardo.saldo);
            bool resultadoSaque = contaDoRicardo.Sacar(50.00);

            Console.WriteLine("O saldo do Ricardo é: " + contaDoRicardo.saldo);
            Console.WriteLine("O resultado do saque é: " + resultadoSaque);

            Console.WriteLine("Realizando depósito na conta do Ricardo...");
            contaDoRicardo.Depositar(500);
            Console.WriteLine("O saldo do Ricardo é: " + contaDoRicardo.saldo);

            ContaCorrente contaDaJakeline = new ContaCorrente();
            contaDaJakeline.titular = "Jakeline";

            Console.WriteLine("O saldo da Jakeline é: " + contaDaJakeline.saldo);
            bool resultadoDaTransferencia = contaDoRicardo.Transferir(300, contaDaJakeline);
            Console.WriteLine("O resultado da transferência é " + resultadoDaTransferencia);

            Console.WriteLine("O saldo da Jakeline é: " + contaDaJakeline.saldo);
            Console.WriteLine("O saldo do Ricardo é: " + contaDoRicardo.saldo);

            resultadoDaTransferencia = contaDaJakeline.Transferir(150, contaDoRicardo);
            Console.WriteLine("O resultado da transferência é " + resultadoDaTransferencia);
            Console.WriteLine("O saldo da Jakeline é: " + contaDaJakeline.saldo);
            Console.WriteLine("O saldo do Ricardo é: " + contaDoRicardo.saldo);

            Console.ReadLine();
        }
    }
}
