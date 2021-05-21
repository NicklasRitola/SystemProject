using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
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

        public string SQLExecuteQuery(string query) //Test function
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

        public virtual bool RegisterDiverInDatabase(RegisterDiverRequest data)
        {
            try
            {
                string query = "insert into Diver values ('" + data.SSN + "','" + data.FirstName + "','" + data.Surname + "','" + data.Gender + "'," + data.Age + "," + data.Team + "); ";
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

                string query = "insert into Dive values (" + data.Dive_ID + "," + temp + "," + data.Difficulty + ",'" + data.DiveGroup + "'," + data.Tower + "," + data.In_Competition + ",'" + data.Diver + "', '" + data.Date + "', false); ";
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

                float output = 0;
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        output = float.Parse("" + dataReader.GetValue(0));
                    }
                }
                dataReader.Close();
                return output;

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
                List<int> points = new List<int>();

                if (dataReader.HasRows)
                {
                    
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            points.Add(Int32.Parse(("" + dataReader.GetValue(i))));
                        }
                    }
                }
                dataReader.Close();
                return points;

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

        public ScheduleResponse FetchScheduleFromDatabase(int Competition_ID)
        {
            try
            {
                List<CompetitionDive> list = new List<CompetitionDive>();

                //Get all divs that has the matching competition id
                string query = "select Dive_ID, Difficulty, Dive_Group, Tower, Date, Diver, Score from Dive where In_Competition = " + Competition_ID + " and Performed = false ORDER BY UNIX_TIMESTAMP(date) ASC;";
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
                        if (score == "")
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
                ScheduleResponse response = new ScheduleResponse(list);
                return response;
            }
            catch (Exception err)
            {
                Console.Out.WriteLine("\nERROR - " + err.Message);
                return null;
            }
        }

        public ScoreboardResponse FetchScoreboardFromDatabase(int Competition_ID)
        {
            try
            {
                string query = "select Diver from Dive where In_Competition = " + Competition_ID + ";"; //Extract all the divers in the competition
                
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                List<string> divers = new List<string>();

                if (dataReader.Read())
                {
                    while (dataReader.Read())
                    {
                        bool add = true;
                        string temp = ("" + dataReader.GetValue(0));
                        for (int i = 0; i < divers.Count; i++)
                        {
                            if(divers[i] == temp)
                            {
                                add = false;
                            }
                        }
                        if(add == true)
                        {
                            divers.Add(temp);
                        }
                        
                    }
                }
                dataReader.Close();

                List<CompetitionDive> list = new List<CompetitionDive>();
                foreach(var diver in divers)
                {
                    query = "select Diver, sum(Score) from Dive where (In_Competition = " + Competition_ID + " and Diver = '"+ diver + "');";
                    sqlQuery = new MySqlCommand(query, this.databaseConnection);
                    dataReader = sqlQuery.ExecuteReader();
                    CompetitionDive temp = new CompetitionDive();

                    if (dataReader.Read())
                    {
                        temp.DiverSSN = ("" + dataReader.GetValue(0));
                        string floatConverter = ("" + dataReader.GetValue(1));
                        if (floatConverter == "") { temp.Score = 0; }
                        else { temp.Score = float.Parse(floatConverter); }
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
                    }
                    dataReader.Close();
                }
                List<CompetitionDive> sortedList = list.OrderByDescending(obj => obj.Score).ToList(); //Order list by the score

                ScoreboardResponse response = new ScoreboardResponse(sortedList);
                return response;
            }
            catch (Exception err)
            {
                Console.Out.WriteLine("\nERROR - " + err.Message);
                return null;
            }

        }

        public bool NextDiverInCompetition(int Competition_ID)
        {
            try
            {
                ScheduleResponse currentSchedule = FetchScheduleFromDatabase(Competition_ID);
                if(currentSchedule == null) { return false; }
                string query = "update Dive set Performed=true where Dive_ID = " + currentSchedule.Schedule[0].DiveId + ";"; //Updates current diver to performed=true
                Console.WriteLine(query);
                MySqlCommand sqlQuery = new MySqlCommand(query, this.databaseConnection);
                MySqlDataReader dataReader = sqlQuery.ExecuteReader();
                dataReader.Close();
                return true;
            }
            catch(Exception err)
            {
                Console.WriteLine("Error - " + err);
                return false;
            }
        }
    }
}
