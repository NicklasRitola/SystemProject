using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Server
{
    class DatabaseHandler
    {
        public MySqlConnection databaseConnection;
        public DatabaseHandler() //Constructor
        {
            this.databaseConnection = this.ConnectToDatabase(); // Creates a new connect to the database
            //Console.WriteLine("Constructor");
        }
        ~DatabaseHandler() //Destructor
        {
            this.CloseConnectionToDatabase(this.databaseConnection); //Close the connection to the database
            //Console.WriteLine("Destructor");
        }

        private MySqlConnection ConnectToDatabase()
        {
            string connectionString = @"server=89.160.69.12;user id=DefaultUser;password=123;database=simhopp_db;persistsecurityinfo=True";

            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                Console.WriteLine("Connection to database open!");
                return databaseConnection;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERROR - " + e.Message);
                return null;
            }
        }
        private void CloseConnectionToDatabase(MySqlConnection databaseConnection)
        {
            try
            {
                databaseConnection.Close();
                Console.WriteLine("Connection to database has been closed!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERROR - " + e.Message);
            }
        }

        public string SQLExecuteQuery(string query)
        {
            try
            {
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();

                if (dataReader.HasRows)
                {
                    string output = "";
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            if (i > 0) { output = output + "   " + dataReader.GetValue(i); }
                            else { output = output + dataReader.GetValue(i); }
                        }
                        output = output + "\n";
                    }
                    dataReader.Close();
                    return output;
                }
                else if (query.StartsWith("select"))
                {
                    Console.WriteLine("No match for that search");
                    dataReader.Close();
                    return "";
                }
                else
                {
                    Console.WriteLine("SQL query has been executed");
                    dataReader.Close();
                    return "";
                }

            }
            catch (Exception e)
            {
                Console.Out.WriteLine("\nERROR - " + e.Message);
                return "";
            }

        }

        public void SendJudgePointToDatabase(int Dive, int Point, string Judge)
        {
            try
            {
                string query = "insert into Give_Points values (" + Dive + "," + Point + ",'" + Judge + "');";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();

                Console.WriteLine("Judge point has been sent to the database");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR - " + e.Message);

            }
        }
    }
}
