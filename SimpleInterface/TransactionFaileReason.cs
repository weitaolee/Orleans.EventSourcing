﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;
using Orleans.Runtime;

namespace Orleans.EventSourcing.SimpleInterface
{
    public enum TransactionFaileReason
    {
        FromAccountNotExist,
        ToAccountNotExist,
        BalanceNotEnough
    }
}
