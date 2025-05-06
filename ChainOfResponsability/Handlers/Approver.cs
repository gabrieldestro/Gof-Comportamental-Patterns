using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handlers
{
    public abstract class Approver
    {
        protected Approver _nextApprover;

        public void NextApprover(Approver approver)
        {
            _nextApprover = approver;
        }

        public abstract void ApproveVacation(string name, int days);
    }
}
