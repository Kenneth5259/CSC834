using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ATM_Practice.Model
{
    class Account
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        public int accountNum { get; }
        public DateTime dailyTransactionDate { get; set; }
        public double dailyTransactionTotal { get; set; }

        public double balance { get; set; }
        public double dailyTransactionLimit { get; set; }
        public int customerId { get; set; }
        public double pendingDepositAmount { get; set; }

        public Account()
        {

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            this.conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
        }

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
