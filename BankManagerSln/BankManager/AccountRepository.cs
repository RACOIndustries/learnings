﻿using System.Collections.Generic;
using System.Linq;

namespace BankManager
{
    public class AccountRepository
    {
        private readonly List<Transaction> _transactions = new List<Transaction>();

        public virtual void ProcessTransactions(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public virtual int GetBalance()
        {
            return _transactions.Sum(x => x.CalculateTotalTransaction());
        }

        public virtual List<Transaction> GetTransactions()
        {
            return _transactions.Select(x => x).ToList();
        }
    }
}