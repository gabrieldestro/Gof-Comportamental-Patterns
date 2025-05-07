using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CardNotInsertedState : IAtmState
    {
        public void EjectCard()
        {
            Console.WriteLine("Unable to eject card.");
        }

        public void EnterPassword()
        {
            Console.WriteLine("Unable enter password.");
        }

        public void InsertCard()
        {
            Console.WriteLine("Card successfully inserted.");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Unable to withdraw money, insert the card.");
        }
    }
}
