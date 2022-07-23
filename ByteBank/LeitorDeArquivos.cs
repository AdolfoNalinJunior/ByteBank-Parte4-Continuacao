using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; set; }

        public LeitorDeArquivos(string arquivo)
        {
            this.Arquivo = arquivo;

            //throw new FileNotFoundException();
            
            Console.WriteLine("Abrindo arquivo " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            throw new IOException();

            return "Linha do Arquivo.";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo"); 
        }
    }
}
