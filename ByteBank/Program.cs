using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CarregarContas()
        {

            using (LeitorDeArquivos leitor = new LeitorDeArquivos("text.txt"))
            {
                leitor.LerProximaLinha();          
            }

            // ---------------------------------
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        Console.WriteLine("Executando o Finally");
            //        leitor.Fechar();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Verifique o nome do arquivo!! ");
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(123, 1234);
                ContaCorrente conta2 = new ContaCorrente(334, 5522);

                //conta1.Transferir(1000, conta2);
                conta1.Sacar(1000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informações da INNER EXECEPTION (Exceção interna):");
                //Console.WriteLine(e.InnerException);
                //Console.WriteLine(e.StackTrace); 
            }
        }

        private static void Metodo()
        {
            TestaDivisao(2);
        }
     
        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            //Console.WriteLine("Resultado de divisão de 10 por " + divisor + " é " + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
           return numero / divisor;
        }
    }
}