using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class CompetitionMaintainer
    {
        private DatabaseHandler database;
        private int CompetitionID;
        private int CompetitionType;

        public CompetitionMaintainer(int ID, DatabaseHandler DB) //Constructor
        {
            this.database = DB;
            this.CompetitionID = ID;
            this.CompetitionType = database.GetCompetitionType(CompetitionID);

        }
        public bool DiveScoreCalculater(int Dive_ID, float difficulty)
        {
            List<int> points = CollectPointsFromJudge(Dive_ID);
            float? DiveScore = null;
            if(points != null)
            {
                DiveScore = null;
                switch (CompetitionType)
                {
                    case 1: // Competition Type 1
                        {
                            if(points.Count == 3) //Should be points from 3 judges 
                            {
                                DiveScore = CompetitionType_1_Calculation(points, difficulty);
                            }
                            break;
                        }
                    case 2: // Competition Type 2
                        {
                            if (points.Count == 7) //Should be points from 7 judges 
                            {
                                DiveScore = CompetitionType_2_Calculation(points, difficulty);
                            }
                            break;
                        }
                }

                //Send calculated score to the database
                if (DiveScore != null)
                {
                    try
                    {
                        return database.SendDiveScoreToDatabase(DiveScore, Dive_ID); // Call database handler
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine("Error - "+ err);
                        return false;
                    }
                        
                }
            }
            return false;
        }
        private List<int> CollectPointsFromJudge(int Dive_ID) 
        {
            try
            {
                return database.CollectPointsForDiveFromJudges(Dive_ID); 
                 
            }
            catch(Exception err)
            {
                Console.WriteLine("Error -" + err);
                return null;
            }
        }
        private float CompetitionType_1_Calculation(List<int> points, float difficulty)
        {
            points.Sort();
            points.RemoveAt(2);
            points.RemoveAt(0);
            //Middle point * 3 * difficulty
            return points[0] * 3;
        }
        private float CompetitionType_2_Calculation(List<int> points, float difficulty)
        {
            //Middle 3 * difficulty
            points.Sort();
            points.RemoveAt(6);
            points.RemoveAt(5);
            points.RemoveAt(0);
            points.RemoveAt(0);
            return (points[0] + points[1] + points[2]) * difficulty;
        }
    }
}
