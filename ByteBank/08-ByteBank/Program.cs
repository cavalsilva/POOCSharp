﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            Console.ReadLine();
        }

        public static void CarregarContas()
        {

            using (LeitorDeArquivo leitorDeArquivo = new LeitorDeArquivo("conta.txt"))
            {
                leitorDeArquivo.LerProximaLinha();
            }

            //LeitorDeArquivo leitorDeArquivo = null;
            //try
            //{
            //    leitorDeArquivo = new LeitorDeArquivo("conta.txt");
            //    leitorDeArquivo.LerProximaLinha();
            //    leitorDeArquivo.LerProximaLinha();
            //    leitorDeArquivo.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException");
            //}
            //finally
            //{
            //    if (leitorDeArquivo != null)
            //        leitorDeArquivo.Fechar();
            //}

        }

        public static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
