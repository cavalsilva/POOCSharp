using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente ricardo = new Cliente();
            //ricardo.nome = "Ricardo";
            //ricardo.profissao = "Desenvolvedor C#";
            //ricardo.cpf = "012.345.678-90";

            ContaCorrente conta = new ContaCorrente();
            conta.titular.nome = "Ricardo";
            conta.titular.profissao = "Desenvolvedor C#";
            conta.titular.cpf = "012.345.678-90";
            conta.agencia = 3032;
            conta.numero = 346458;
            conta.saldo = 1000;

            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();

             
        }
    }
}
