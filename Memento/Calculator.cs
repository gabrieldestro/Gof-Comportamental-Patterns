using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Calculator : ICalculator
    {
        private int firstNumber;
        private int secondNumber;

        public ICaretaker BackupLastCalculation()
        {
            return new ConcreteMemento(firstNumber, secondNumber);
        }

        public int GetResult()
        {
            return firstNumber + secondNumber;
        }

        public void RestoreLastCalculation(ICaretaker memento)
        {
            firstNumber = ((IOriginator) memento).GetFirstNumber();
            secondNumber = ((IOriginator) memento).GetSecondNumber();
        }

        public void SetFirstNumber(int number)
        {
            firstNumber = number;
        }

        public void SetSecondNumber(int number)
        {
            secondNumber = number;
        }
    }
}
