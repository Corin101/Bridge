using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            SendMessage poruka;

            poruka = new PošaljiSMS();
            poruka._Most = new SendHT();
            poruka.Pošalji();

            poruka._Most = new SendVIP();
            poruka.Pošalji();

            poruka = new PošaljiMail();
            poruka._Most = new SendVIP();
            poruka.Pošalji();

            poruka = new PošaljiMMS();
            poruka._Most = new SendTele2();
            poruka.Pošalji();


            Console.ReadKey();
        }
    }
}
