using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Practice.Model
{
    class Transaction
    {
        public int accountNum { get; set; }
        public DateTime date { get; set; }
        public int transactionNum {  get; }

        public string transactionType { get; set; }
        public int toAccount { get; set; }
        public int fromAccount { get; set; }

    }
}
