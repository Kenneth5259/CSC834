using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ATM_Practice.Model
{
    public class Transaction
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        public int accountNum { get; set; }
        public DateTime date { get; set; }
        public int transactionNum { get; set; }
        public string transactionType { get; set; }

        public Nullable<double> amount { get; set; }
        public Nullable<int> toAccount { get; set; }
        public Nullable<int> fromAccount { get; set; }

        
        public Transaction()
        {
            // connection string
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            // connection instance
            this.conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
        }
        public void createTransaction()
        {
            try
            {
                // write line for DB conenct
                Trace.WriteLine("Connecting to MySQL...");

                //open connection
                conn.Open();

                // structure SQL statement, not supplying transactionNum to use MySQL auto increment functionality
                string sql = "INSERT INTO  carrolltransaction(accountNum, date, transactionType, amount, toAccount, fromAccount) VALUES(@accountNum, @date, @transactionType, @amount, @toAccount, @fromAccount)";

                // declare new command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                // insert values in place of holder
                cmd.Parameters.AddWithValue("@accountNum", accountNum);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@transactionType", transactionType);
                cmd.Parameters.AddWithValue("@amount", this.amount);
                cmd.Parameters.AddWithValue("@toAccount", toAccount);
                cmd.Parameters.AddWithValue("@fromAccount", fromAccount);

                // execute the non query
                cmd.ExecuteNonQuery();
                
                // close the connection
                conn.Close();

            }
            // handle connection exceptions
            catch (Exception ex)
            {

                // notify the exception to console
                Trace.WriteLine(ex.ToString());
            }
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
