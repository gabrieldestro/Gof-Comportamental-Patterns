using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Atm : IAtmState
    {
        public IAtmState AtmState { get; set; }

        public Atm()
        {
            AtmState = new CardNotInsertedState();
        }

        public void InsertCard()
        {
            AtmState.InsertCard();
            if (AtmState is CardNotInsertedState)
            {
                AtmState = new CardInsertedState();
                Console.WriteLine("State Changed to 'Card inserted'.");
            }
        }

        public void EjectCard()
        {
            AtmState.EjectCard();
            if (AtmState is CardInsertedState)
            {
                AtmState = new CardNotInsertedState();
                Console.WriteLine("State Changed to 'Card not inserted'.");
            }
        }

        public void EnterPassword()
        {
            AtmState.EnterPassword();
        }

        public void WithdrawMoney()
        {
            AtmState.WithdrawMoney();
        }
    }
}
