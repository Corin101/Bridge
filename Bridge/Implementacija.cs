using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
        public class SendHT : Most
        {
            public void Pošalji(string tipPoruke)
            {
                Console.WriteLine("Šaljem " + tipPoruke + " preko HT operatera\n");
            }
        }

        public class SendVIP : Most
        {
            public void Pošalji(string tipPoruke)
            {
                Console.WriteLine("Šaljem " + tipPoruke + " preko VIP operatera\n");
            }
        }

        public class SendTele2 : Most
        {
            public void Pošalji(string tipPoruke)
            {
                Console.WriteLine("Šaljem " + tipPoruke + " preko Tele2 operatera\n");
            }
        }
    }

