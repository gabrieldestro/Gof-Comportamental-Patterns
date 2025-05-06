using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Mediator;

namespace Mediator.Colleage
{
    public abstract class AbstractUser
    {
        protected IGroupMediator _mediator;
        protected string _name;

        protected AbstractUser(IGroupMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
