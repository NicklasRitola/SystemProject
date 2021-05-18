using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Shared;

namespace Server
{
    class PasswordDatabaseHandler : DatabaseHandler
    {
        public PasswordDatabaseHandler() //Constructor
        {
            try
            {
                this.databaseConnection = this.ConnectToPasswordDatabase(); // Creates a new connect to the database
            }
            catch (Exception e)
            {
                Console.WriteLine("Error - " + e);
            }
        }
        public MySqlConnection ConnectToPasswordDatabase()
        {
            string connectionString = @"server=" + IP + ";user id=PasswordUser;password=123456;database=simhopp_db_password;persistsecurityinfo=True";

            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                //Console.WriteLine("Connection to password database open!");
                return databaseConnection;
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError - " + e.Message);
                return null;
            }
        }
        public override bool RegisterJudgeInDatabase(RegisterJudgeRequest data)
        {
            try
            {
                string query = "insert into Judge values ('" + data.SSN + "','" + data.Password + "'); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database Password - Judge has been registerd");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error - " + e);
                return false;
            }
        }
        public override bool RegisterAdminInDatabase(RegisterAdminRequest request)
        {
            return true;
        }
    }
}
