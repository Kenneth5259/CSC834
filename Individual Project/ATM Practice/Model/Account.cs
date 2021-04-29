using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MySql.Data.MySqlClient;

namespace ATM_Practice.Model
{
    public class Account
    {
        //private database connection
        private MySql.Data.MySqlClient.MySqlConnection conn;

        //private account number attribute
        public int accountNum { get; set; }

        // public daily transaction date attribute
        public DateTime dailyTransactionDate { get; set; }

        // public daily transaction total attribute
        public double dailyTransactionTotal { get; set; }

        //public balance attribute
        public double balance { get; set; }

        // public double daily transaction limit
        public double dailyTransactionLimit { get; set; }

        // private int customer id
        public int customerId { get; set; }

        // public double pending deposit amount
        public double pendingDepositAmount { get; set; }

        // Account constructor with database connection
        public Account()
        {
            // connection string
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            // connection instance
            this.conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
        }

        /**
         * Method to return account information from the database 
         * from the Id
         * 
         * 
         */

        public Account retrieveAccountInformation(int accountNum)
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
                    acc = this.mapReaderToObject(myreader);
                }

                // close the connection
                conn.Close();

                // return the account
                return acc;

            }
            // handle connection exceptions
            catch (Exception ex)
            {

                // notify the exception to console
                Console.WriteLine(ex.ToString());
            }

            return acc;
        }



        /**
        *  Method to return all accounts with the assocatiated  
        *  customer throught the 1-m relationship. Will become list 
        *  populated by SQL statement.
        */
        public List<int> retrieveAccounts(int customerId)
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

                // close the connection
                conn.Close();

                // return the IDs
                return ids;

            }

            // handle connection exceptions
            catch (Exception ex)
            {

                // notify the exception to console
                Trace.WriteLine(ex.ToString());
            }
            return new List<int>();
        }

        /**
         *  Method to parse the values from the reader to the acount object
         * 
         */

        public Account mapReaderToObject(MySqlDataReader myreader)
        {
            
            // declare account for return
            Account a = new Account();

            // notify that the attribute mapping is beginning
            Trace.WriteLine("Mapping Attributes");

            // assign each attribute
            a.accountNum = Int32.Parse(myreader["accountNum"].ToString());
            a.customerId = Int32.Parse(myreader["customerId"].ToString());
            a.balance = Double.Parse(myreader["balance"].ToString());
            a.pendingDepositAmount = Double.Parse(myreader["pendingDepositAmount"].ToString());
            a.dailyTransactionLimit = Double.Parse(myreader["dailyTransactionLimit"].ToString());
            a.dailyTransactionDate = DateTime.Parse(myreader["dailyTransactionDate"].ToString());
            a.dailyTransactionTotal = Double.Parse(myreader["dailyTransactionTotal"].ToString());

            // return the value
            return a;
        }

        /**
         *  method for comparing the date and updating daily transaction
         *  values if the date does not match
         */
        public void updateDailyTransactionDate()
        {
            // current date comparison
            if(this.dailyTransactionDate.Date != DateTime.Today.Date)
            {

                // set to current date
                this.dailyTransactionDate = DateTime.Today;

                // reset daily transaction limit
                this.dailyTransactionTotal = 0;
            }
        }

        public void updatePendingDeposit()
        {
            try
            {
                // write line for DB conenct
                Console.WriteLine("Connecting to MySQL...");

                //open connection
                conn.Open();

                // structure SQL statement
                string sql = "UPDATE carrollaccount SET pendingDepositAmount=@amount WHERE accountNum=@accountNum";

                // declare new command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                // add values to the command
                cmd.Parameters.AddWithValue("@amount", this.pendingDepositAmount);
                cmd.Parameters.AddWithValue("@accountNum", this.accountNum);

                // execute the non query
                cmd.ExecuteNonQuery();

                // close the connection
                conn.Close();

            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }
    }
}
