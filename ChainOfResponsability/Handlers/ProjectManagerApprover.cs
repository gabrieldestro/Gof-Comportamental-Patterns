using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handlers
{
    public class ProjectManagerApprover : Approver
    {
        public override void ApproveVacation(string name, int days)
        {
            var days_limit = 5;

            if (days <= days_limit)
            {
                Console.WriteLine($"Vacation of {days} day(s) approved for {name} by the project manager.");
            }
            else
            {
                _nextApprover?.ApproveVacation(name, days);
            }
        }
    }
}
