﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IAtmState
    {
        void InsertCard();
        void EjectCard();
        void EnterPassword();
        void WithdrawMoney();
    }
}
