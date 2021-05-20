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
            catch (Exception err)
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
            catch (Exception err)
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
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public bool CreateScheduleInDatabase(CreateScheduleRequest data)
        {
            try
            {
                //string query = "insert into Schedule values (" + data.CompetitionID + "," + data.DiveID + "," + data.DiverID + "," + data.count + "); ";
                string query = "insert into Schedule values (" + data.CompetitionID + ");";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                Console.WriteLine("Database - Schedule has been created");
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
        public virtual bool RegisterDiverInDatabase(RegisterDiverRequest data)
        {
            try
            {
                string query = "insert into Diver values ('" + data.SSN + "','" + data.FirstName + "','" + data.Surname + "','" + data.Gender + "'," + data.Age + "); ";
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
                string temp = "";
                if (data.Score == null) { temp = "null"; }
                else { temp = data.Score.ToString(); }

                string query = "insert into Dive values (" + data.Dive_ID + "," + temp + "," + data.Difficulty + ",'" + data.DiveGroup + "'," + data.Tower + "," + data.In_Competition + ",'" + data.Diver + "', " + data.Date + "); ";
                Console.WriteLine(query);
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
                string query = "insert into Give_Points values (" + data.DiveID + "," + data.Point + ",'" + data.Judge + "');";
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
        public float GetDiveDifficulty(int DiveID)
        {
            try
            {
                string query = "select Difficulty from dive where dive_id = " + DiveID + ";";
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
            catch (Exception err)
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
        public virtual bool LoginChecker(LoginRequest data)
        {
            return false;
        }
        public List<CompetitionDive> GetCompetitionDives(int Competition_ID)
        {
            try
            {
                List<CompetitionDive> list = new List<CompetitionDive>();

                //Get all divs that has the matching competition id
                string query = "select Dive_ID, Difficulty, Dive_Group, Tower, Date, Diver, Score from Dive where In_Competition = " + Competition_ID + " order by Date DESC;";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        CompetitionDive temp = new CompetitionDive();

                        temp.DiveId = Int32.Parse("" + dataReader.GetValue(0));
                        temp.Difficulty = float.Parse("" + dataReader.GetValue(1));
                        temp.Group = ("" + dataReader.GetValue(2));
                        temp.Tower = Int32.Parse("" + dataReader.GetValue(3));
                        temp.Time = ("" + dataReader.GetValue(4));
                        temp.DiverSSN = ("" + dataReader.GetValue(5));
                        string score = ("" + dataReader.GetValue(6));
                        if(score == "")
                        {
                            temp.Score = null;
                        }
                        else
                        {
                            temp.Score = float.Parse(score);
                        }
                        list.Add(temp);
                    }
                    dataReader.Close();
                }

                //Get name of diver that perform dive 
                for (int i = 0; i < list.Count; i++)
                {
                    query = "select Firstname, Surname from Diver where SSN = '" + list[i].DiverSSN + "';";
                    sqlQuery = new MySqlCommand(query, this.databaseConnection);
                    dataReader = sqlQuery.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            string name = "";
                            name += dataReader.GetValue(0) + " " + dataReader.GetValue(1);
                            list[i].DiverName = name;
                        }
                        dataReader.Close();
                    }
                }
                return list;
            }
            catch (Exception err)
            {
                Console.Out.WriteLine("\nERROR - " + err.Message);
                return null;
            }
        }
        public CurrentDiverResponse GetDiveInformation(int Dive_ID)
        {
            try
            {
                CurrentDiverResponse diver = new CurrentDiverResponse();
                diver.CurrentID = Dive_ID;

                string query = "select Difficulty, Dive_Group, Tower from Dive where Dive_ID = " + Dive_ID + ";";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<int> points = new List<int>();
                    while (dataReader.Read())
                    {
                        diver.Difficulty = float.Parse("" + dataReader.GetValue(0));
                        diver.DiveGroup = ("" + dataReader.GetValue(1));
                        diver.Tower = Int32.Parse("" + dataReader.GetValue(2));
                    }
                    dataReader.Close();
                }
                 return diver;
            }
            catch(Exception err)
            {
                Console.WriteLine("Error -" + err);
                return null;
            }
        }

        public bool DeleteCompetitionInDatabase(int Competition_ID)
        {
            try
            {
                string query = "delete from competition where id = " + Competition_ID + ";";
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();

                dataReader.Close();
                Console.WriteLine("Database -  Competition {0} has been deleted", Competition_ID);
                return true;
            }
            catch (Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
    }
}
