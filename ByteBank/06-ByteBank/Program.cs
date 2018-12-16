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
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Ricardo";
            cliente.CPF = "012.345.678-90";
            cliente.Profissao = "Programador";

            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            
            Console.ReadLine();
        }
    }
}
