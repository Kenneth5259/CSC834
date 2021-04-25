using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ATM_Practice.Model
{
    class Transaction
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        public int accountNum { get; set; }
        public DateTime date { get; set; }
        public int transactionNum {  get; }
        public string transactionType { get; set; }
        public int toAccount { get; set; }
        public int fromAccount { get; set; }

        public Transaction(MySql.Data.MySqlClient.MySqlConnection conn)
        {
            this.conn = conn;
        }
        public Transaction()
        {
            conn = null;
        }
    }
}
