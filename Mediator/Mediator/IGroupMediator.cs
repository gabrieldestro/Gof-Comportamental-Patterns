using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Colleage;

namespace Mediator.Mediator
{
    public interface IGroupMediator
    {
        void SendMessage(AbstractUser user, string message);
        void RegisterUser(AbstractUser user);
    }
}
