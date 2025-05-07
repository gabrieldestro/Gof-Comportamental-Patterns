using State;

Atm atm = new Atm();

Console.WriteLine($"ATM current state {atm.AtmState.GetType().ToString()}");

atm.EnterPassword();
atm.WithdrawMoney();
atm.EjectCard();
atm.InsertCard();

Console.WriteLine($"ATM current state {atm.AtmState.GetType().ToString()}");

atm.EnterPassword();
atm.WithdrawMoney();
atm.EjectCard();