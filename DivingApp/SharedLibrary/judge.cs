﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Judge : Participants
    {

        public float score;

        public void SetScore()
        {
            score = 0;
        }
        
        public float GetScore()
        {
            return score;
        }



    }
}