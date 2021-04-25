using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ATM_Practice.Model
{
    class Customer
    {
        // private connection attribute
        private MySql.Data.MySqlClient.MySqlConnection conn;

        // private ID attribute
        private int id { get; set; }

        // private PIN attribute
        private int pin { get; set; }

        // public Last Sign On attribute
        public DateTime lastSignOn { get; set; }

        // public Last Sign Off attribute
        public DateTime lastSignOff { get; set; }

        // public Failed Pin Count attribute
        public int failedPinCount { get; set; }

        // public Date of Last Failed Pin Count
        public DateTime dateOfLastFailedPin { get; set; }


        public Customer()
        {
            // declare connection string
            string connStr = "server=157.89.28.130;user=ChangK;database=test;port=3306;password=Wallace#409;";
            
            // create a new connection instance for the object
            this.conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
        }

        /**
         *  Function to return a customer by ID
         *  This applications assumes the ID is 1 
         *  for purposes of demonstration. But if
         *  an actual card system was in place it
         *  would query the id associated with the
         *  card/pin combo
         * 
         */
        public Customer getCustomerById(int id)
        {

            // declare new customer object for safe return type
            Customer c = new Customer();
            try
            {
                // write line for DB conenct
                Console.WriteLine("Connecting to MySQL...");

                //open connection
                conn.Open();

                // structure SQL statement
                string sql = "SELECT * FROM carrollcustomer where id=@id";

                // declare new command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                
                // insert values in place of holder
                cmd.Parameters.AddWithValue("@id", id);

                // create a new reader instance from executing command
                MySqlDataReader myreader = cmd.ExecuteReader();

                // read next row of reader
                if(myreader.Read())
                {
                    // map value to a customer
                    c = mapReaderToObject(myreader);
                }

            }

            // handle connection exceptions
            catch (Exception ex)
            {

                // notify the exception to console
                Console.WriteLine(ex.ToString());
            }

            // return found customer if successful or an empty customer if not 
            return c;
        }
        /**
         *  Method to map MySQL data reader values to the class
         *  and then return the value. Looked at other approaches
         *  with Reflection and figured it was outside the scope
         *  of the project.
         * 
         */
        public Customer mapReaderToObject(MySqlDataReader myreader)
        {
            // declare return object
            Customer c = new Customer();

            // parse each attribute by its name and by the value type from the DB
            c.id = Int32.Parse(myreader["id"].ToString());
            c.pin = Int32.Parse(myreader["pin"].ToString());
            c.lastSignOn = DateTime.Parse(myreader["lastSignOn"].ToString());
            c.lastSignOff = DateTime.Parse(myreader["lastSignOff"].ToString());
            c.dateOfLastFailedPin = DateTime.Parse(myreader["dateOfLastFailedPin"].ToString());
            c.failedPinCount = Int32.Parse(myreader["failedPinCount"].ToString());

            // return the object with the assigned parsed attributes
            return c;
        }

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
