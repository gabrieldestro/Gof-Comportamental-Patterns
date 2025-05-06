using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Handlers
{
    public class RhApprover : Approver
    {
        public override void ApproveVacation(string name, int days)
        {
            var days_limit = 30;

            if (days <= days_limit)
            {
                Console.WriteLine($"Vacation of {days} day(s) approved for {name} by the RH.");
            }
            else
            {
                Console.WriteLine($"Could not approve {days} days vacation for {name} because the {days_limit} days limit was exceeded.");
            }
        }
    }
}
