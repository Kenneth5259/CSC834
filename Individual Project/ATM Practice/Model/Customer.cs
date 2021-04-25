using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Practice.Model
{
    class Customer
    {
        public int id { get; }
        public int pin { get; set; }
        public DateTime lastSignOn { get; set; }
        public DateTime lastSignOff { get; set; }
        public int failedPinCount { get; set; }
        public DateTime dateOfLastFailedPin { get; set; }

        /**
        *  Method to return all accounts with the assocatiated  
        *  customer throught the 1-m relationship. Will become list 
        *  populated by SQL statement.
        */
        public List<Account> getAllAccounts()
        {
            return new List<Account>();
        }
    }
}
