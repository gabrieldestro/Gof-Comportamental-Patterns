using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class ConcreteMemento : ICaretaker, IOriginator
    {
        private int FirstNumber { get; set; }
        private int SecondNumber { get; set; }

        public ConcreteMemento(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public int GetFirstNumber()
        {
            return FirstNumber;
        }

        public int GetSecondNumber()
        {
            return SecondNumber;
        }
    }
}
