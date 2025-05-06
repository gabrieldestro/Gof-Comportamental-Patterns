using Memento;

ICalculator calculator = new Calculator();

Console.WriteLine("First calculation.");

calculator.SetFirstNumber(7);
calculator.SetSecondNumber(4);

Console.WriteLine($"First state: {calculator.GetResult()}");

Console.WriteLine("Backup result.");
ICaretaker memento = calculator.BackupLastCalculation();

Console.WriteLine("Second calculation.");

calculator.SetFirstNumber(3);
calculator.SetSecondNumber(12);

Console.WriteLine($"Second state: {calculator.GetResult()}");

calculator.RestoreLastCalculation(memento);

Console.WriteLine($"Backup state: {calculator.GetResult()}");
