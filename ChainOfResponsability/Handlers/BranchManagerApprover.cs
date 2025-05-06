using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handlers
{
    public class BranchManagerApprover : Approver
    {
        public override void ApproveVacation(string name, int days)
        {
            var days_limit = 15;

            if (days <= days_limit)
            {
                Console.WriteLine($"Vacation of {days} day(s) approved for {name} by the branch manager.");
            }
            else
            {
                _nextApprover?.ApproveVacation(name, days);
            }
        }
    }
}
