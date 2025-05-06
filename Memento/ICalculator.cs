using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public interface ICalculator
    {
        ICaretaker BackupLastCalculation();

        void RestoreLastCalculation(ICaretaker memento);
        int GetResult();
        void SetFirstNumber(int number);
        void SetSecondNumber(int number);
    }
}
