using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
        public abstract class SendMessage
        {
            public Most _Most;
            public abstract void Pošalji();
        }

        public class PošaljiMail : SendMessage
        {
            public override void Pošalji()
            {
                _Most.Pošalji("Mail");
            }
        }

        public class PošaljiSMS : SendMessage
        {
            public override void Pošalji()
            {
                _Most.Pošalji("SMS");
            }
        }

        public class PošaljiMMS : SendMessage
        {
            public override void Pošalji()
            {
                _Most.Pošalji("MMS");
            }
        }
    }
