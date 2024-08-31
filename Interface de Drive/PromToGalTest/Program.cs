using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromToGalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string arqOriginal = @"C:\Users\cfolly\DropboxPessoal\Dropbox\TK 2000\Interface de Drive\DISKII-2.BIN";

            var conteudo = System.IO.File.ReadAllBytes(arqOriginal);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A,B,C,D,E,F,G,H,,F0,F1,F2,F3,F4,F5,F6,F7");

            int i = 0;
            foreach (var b in conteudo)
            {
                string indice = Convert.ToString(i, 2).PadLeft(8, '0');
                string valor = Convert.ToString(b, 2).PadLeft(8, '0');

                i++;

                sb.AppendLine(string.Format("{0},,{1}", string.Join(",", indice.ToArray()), string.Join(",", valor.ToArray())));
            }


            System.IO.File.WriteAllText(@"C:\Users\cfolly\DropboxPessoal\Dropbox\TK 2000\Interface de Drive\DISKII-2.csv", sb.ToString());

        }
    }
}
