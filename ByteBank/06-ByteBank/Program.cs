using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.nome = "Ricardo";
            cliente.cpf = "012.345.678-90";
            cliente.profissao = "Programador";

            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);
            
            Console.ReadLine();
        }
    }
}
