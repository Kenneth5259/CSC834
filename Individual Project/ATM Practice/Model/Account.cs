using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Practice.Model
{
    class Account
    {
        public int accountNum { get; }
        public DateTime dailyTransactionDate { get; set; }
        public double dailyTransactionTotal { get; set; }

        public double balance { get; set; }
        public double dailyTransactionLimit { get; set; }
        public int customerId { get; set; }
        public double pendingDepositAmount { get; set; }

        /**
         *  Method to return all transactions with the assocatiated  
         *  account throught the 1-m relationship. Will become list 
         *  populated by SQL statement.
         */
        public List<Transaction> getAllTransactions()
        {
            return new List<Transaction>();
        }
    }
}
