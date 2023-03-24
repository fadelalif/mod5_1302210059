using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod5_1302210059
{
    internal class Penjumlahan
    {
        public class JumlahTigaAngka<T>
        {
            private T a, b, c, hasil;

            public JumlahTigaAngka(T a, T b, T c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public void PrintData()
            {
                long hasil = (dynamic)a+(dynamic)b+(dynamic)c;
                Console.WriteLine("Hasil perjumlahan adalah: " + hasil);
            }
        }
    }
}
