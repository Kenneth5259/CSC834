using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ATM_Practice.Model
{
    class Account
    {
        private MySql.Data.MySqlClient.MySqlConnection conn;
        public int accountNum { get; set; }
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
         * Method to return account information from the database 
         * from the Id
         * 
         * 
         */

        public Account getAccountById(int accountNum)
        {
            Account acc = new Account();
            try
            {
                // write line for DB conenct
                Console.WriteLine("Connecting to MySQL...");

                //open connection
                conn.Open();

                // structure SQL statement
                string sql = "SELECT * FROM carrollaccount where accountNum=@id";

                // declare new command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                // insert values in place of holder
                cmd.Parameters.AddWithValue("@id", accountNum);

                // create a new reader instance from executing command
                MySqlDataReader myreader = cmd.ExecuteReader();

                // read next row of reader
                if (myreader.Read())
                {
                    // map value to a customer
                    ids.Add(Int32.Parse(myreader["accountNum"].ToString()));
                }
                return ids;

            }
        }



        /**
        *  Method to return all accounts with the assocatiated  
        *  customer throught the 1-m relationship. Will become list 
        *  populated by SQL statement.
        */
        public List<int> getAllAccounts(int customerId)
        {
            // declare new customer object for safe return type
            List<int> ids = new List<int>();
            try
            {
                // write line for DB conenct
                Console.WriteLine("Connecting to MySQL...");

                //open connection
                conn.Open();

                // structure SQL statement
                string sql = "SELECT * FROM carrollaccount where customerId=@id";

                // declare new command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                // insert values in place of holder
                cmd.Parameters.AddWithValue("@id", customerId);

                // create a new reader instance from executing command
                MySqlDataReader myreader = cmd.ExecuteReader();

                // read next row of reader
                while (myreader.Read())
                {
                    // map value to a customer
                    ids.Add(Int32.Parse(myreader["accountNum"].ToString()));
                }
                return ids;

            }

            // handle connection exceptions
            catch (Exception ex)
            {

                // notify the exception to console
                Console.WriteLine(ex.ToString());
            }
            return new List<int>();
        }

        /**
         *  Method to parse the values from the reader to the acount object
         * 
         */
    }
}
