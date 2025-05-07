using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class CardInsertedState : IAtmState
    {
        public void EjectCard()
        {
            Console.WriteLine("Card ejected.");
        }

        public void EnterPassword()
        {
            Console.WriteLine("Password successfully entered.");
        }

        public void InsertCard()
        {
            Console.WriteLine("Unable to insert card, card already inserted.");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money withdrawn successfully.");
        }
    }
}
