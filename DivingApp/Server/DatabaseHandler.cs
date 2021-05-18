using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Shared;

namespace Server
{
    class DatabaseHandler
    {
        protected MySqlConnection databaseConnection;
        protected string IP = "89.160.69.12";
        public DatabaseHandler() //Constructor
        {
            try
            {
                this.databaseConnection = this.ConnectToDatabase(); // Creates a new connect to the database
            }
            catch(Exception err)
            {
                Console.WriteLine("Error - " + err);
            }
            
        }
        ~DatabaseHandler() //Destructor
        {
            try
            {
                this.CloseConnectionToDatabase(this.databaseConnection); //Close the connection to the database
            }
            catch(Exception err)
            {
                Console.WriteLine("Error - " + err);
            }
        }

        private MySqlConnection ConnectToDatabase()
        {
            string connectionString = @"server=" + IP + ";user id=DefaultUser;password=123;database=simhopp_db;persistsecurityinfo=True";

            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                //Console.WriteLine("Connection to database open!");
                return databaseConnection;
            }
            catch (Exception err)
            {
                Console.WriteLine("\nError - " + err.Message);
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
            catch (Exception err)
            {
                Console.WriteLine("\nError - " + err.Message);
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
            catch (Exception err)
            {
                Console.Out.WriteLine("\nERROR - " + err.Message);
                return "";
            }

        }

        public bool CreateCompetitionInDatabase(CreateCompetitionRequest data)
        {
            try
            {
                string query = "insert into Competition values (" + data.ID + "," + data.Location + ",'" + data.Start_Date + "','" + data.End_Date + "'); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Competition has been created");
                return true;
            }
            catch(Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public bool CreateScheduleInDatabase(CreateScheduleRequest data)
        {
            try
            {
                string query = "insert into Schedule values (" + data.CompetitionID + "," + data.DiveID + "," + data.DiverID + "," + data.count + "); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Competition has been created");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public bool RegisterDiverInDatabase(RegisterDiverRequest data)
        {
            try
            {
                string query = "insert into Diver values ('" + data.SSN + "','" + data.FirstName + "','" + data.Surname + "','" + data.Gender + "'," + data.Age + ",); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Diver has been registerd");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public bool RegisterDiveInDatabase(RegisterDiveRequest data)
        {
            try
            {
                string query = "insert into Dive values (" + data.Dive_ID + "," + data.Score + "'," + data.Difficulty + "," + data.Tower + "," + data.In_Competition + ",'" + data.Diver + "'); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Dive has been registerd");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public bool RegisterTeamInDatabase(RegisterTeamRequest data)
        {
            try
            {
                string query = "insert into Team values (" + data.Team_ID + ",'" + data.Name + "'); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Team has been registerd");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public virtual bool RegisterJudgeInDatabase(RegisterJudgeRequest data)
        {
            try
            {
                string query = "insert into Judge values ('" + data.SSN + "','" + data.FirstName + "','" + data.Surname + "'); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Judge has been registerd");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public virtual bool RegisterAdminInDatabase(RegisterAdminRequest data)
        {
            try
            {
                string query = "insert into Admin values ('" + data.SSN + "','" + data.FirstName + "','" + data.Surname + "'); ";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Admin has been registerd");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public bool SendJudgePointToDatabase(JudgePointRequest data)
        {
            try
            {
                string query = "insert into Give_Points values (" + data.Dive + "," + data.Point + ",'" + data.Judge + "');";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Judge point has been received");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err.Message);
                return false;
            }
        }
        public int GetCompetitionType(int CompetitionID)
        {
            try
            {
                string query = "select type from competition where ID = " + CompetitionID + ";";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();

                if (dataReader.HasRows)
                {
                    int output = 0;
                    while (dataReader.Read())
                    {
                        output = Int32.Parse("" + dataReader.GetValue(0));
                    }
                    dataReader.Close();
                    return output;
                }
                dataReader.Close();
                return 0; 

            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err.Message);
                return 0;
            }
        }
        public bool SendDiveScoreToDatabase(float? DiveScore, int Dive_ID)
        {
            try
            {
                string query = "update dive set score = " + DiveScore + " where Dive_ID = " + Dive_ID + ");"; 
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Dive score has been sent to database");

                return true;
            }
            catch(Exception err)
            {
                Console.WriteLine("Error - " + err.Message);
                return false;
            }
        }
        public List<int> CollectPointsForDiveFromJudges(int Dive_ID)
        {
            try
            {
                string query = "select Point from Give_Points where dive = " + Dive_ID + ";";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<int> points = new List<int>();
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            points.Add(Int32.Parse(("" + dataReader.GetValue(i))));
                        }
                    }
                    dataReader.Close();
                    return points;
                }
                dataReader.Close();
                return null;

            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err.Message);
                return null;
            }
        }
    }
}
