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

        public CompetitionMaintainer(int ID, DatabaseHandler DB)
        {
            this.database = DB;
            this.CompetitionID = ID;
            this.CompetitionType = database.GetCompetitionType(CompetitionID);

        }
        public void DiveScoreCalculater(int Dive_ID)
        {
            List<int> points = CollectPointsFromJudge(Dive_ID);
            if(points != null)
            {
                float? DiveScore = null;
                switch (CompetitionType)
                {
                    case 1: // Competition Type 1
                        {
                            if(points.Count == 3) //Should be points from 3 judges 
                            {
                                DiveScore = CompetitionType_1_Calculation(points);
                            }
                            break;
                        }
                    case 2: // Competition Type 2
                        {
                            if (points.Count == 7) //Should be points from 7 judges 
                            {
                                DiveScore = CompetitionType_2_Calculation(points);
                            }
                            break;
                        }
                }

                //Send calculated score to the database
                if (DiveScore != null)
                {
                    try
                    {
                        database.SendDiveScoreToDatabase(DiveScore, Dive_ID); // Call database handler 
                    }
                    catch(Exception err)
                    {
                        Console.WriteLine("Error - "+ err);
                    }
                        
                }
            }
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

        private float CompetitionType_1_Calculation(List<int> points)
        {
            return 0;
        }
        private float CompetitionType_2_Calculation(List<int> points)
        {
            return 0;
        }
    }

}
