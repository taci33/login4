using System;
using System.Collections.Generic;

namespace login4.Models.EF;

public partial class Transaction
{
    public int Idtransaction { get; set; }

    public string TransactionValue { get; set; }
}
