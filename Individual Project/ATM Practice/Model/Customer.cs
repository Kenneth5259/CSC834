using System;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ATM_Practice.Model
{
    public class Customer
    {
        // private connection attribute
        private MySql.Data.MySqlClient.MySqlConnection conn;

        // private ID attribute
        public int id { get; set; }

        // private PIN attribute
        public int pin { get; set; }

        // public Last Sign On attribute
        public DateTime lastSignOn { get; set; }

        // public Last Sign Off attribute
        public DateTime lastSignOff { get; set; }

        // public Failed Pin Count attribute
        public int failedPinCount { get; set; }

        // public Date of Last Failed Pin Count
        public DateTime dateOfLastFailedPin { get; set; }

        // list of accounts associated with the Customer
        public List<int> customerAccounts { get; set; }


        public Customer()
        {
            // declare connection string
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            
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
                Trace.WriteLine("Connecting to MySQL...");

                //open connection
                conn.Open();

                // structure SQL statement
                string sql = "SELECT * FROM carrollcustomer WHERE id=@id;";

                // declare new command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                
                // insert values in place of holder
                cmd.Parameters.AddWithValue("@id", id);

                // create a new reader instance from executing command
                MySqlDataReader myreader = cmd.ExecuteReader();

                Trace.WriteLine("CMD Executed");

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

            // Close the connection once used
            conn.Close();

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

        public void updateCustomerInformation()
        {
            try
            {
                // write line for DB conenct
                Console.WriteLine("Connecting to MySQL...");

                //open connection
                conn.Open();

                // structure SQL statement
                string sql = "UPDATE carrollcustomer SET lastSignOn=@lastSignOn, lastSignOff=@lastSignOff, failedPinCount=@failedPinCount, dateOfLastFailedPin=@dateOfLastFailedPin WHERE id=@id";
                
                // declare new command
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                // add values to the command
                Trace.WriteLine("Adding Values");
                cmd.Parameters.AddWithValue("@lastSignOn", this.lastSignOn); 
                cmd.Parameters.AddWithValue("@lastSignOff", this.lastSignOff);
                cmd.Parameters.AddWithValue("@failedPinCount", this.failedPinCount);
                cmd.Parameters.AddWithValue("@dateOfLastFailedPin", this.dateOfLastFailedPin);
                cmd.Parameters.AddWithValue("@id", this.id);

                // execute the non query
                cmd.ExecuteNonQuery();

                // close the connection
                conn.Close();

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }

        public bool validatePin(string pin)
        {
            // check that the pin count has been reset if another day
            if(this.dateOfLastFailedPin.Date != DateTime.Now.Date)
            {

                // reset the pin count if its a new day
                this.failedPinCount = 0;
            }

            // run the check
            bool pinAccurate = (this.pin == Int32.Parse(pin));

            // if the pin was incorrect
            if(!pinAccurate)
            {
                // increment failed pin count
                this.failedPinCount += 1;

                // make sure the date is recorded
                this.dateOfLastFailedPin = DateTime.Now;

            } else
            {

                // reset the pin count
                this.failedPinCount = 0;

                // update date of last signon
                this.lastSignOn = DateTime.Now;
            }

            // return the status
            return pinAccurate;
        }
    }
}
