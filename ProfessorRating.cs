﻿using System;
using System.Collections.Generic;
using System.Text;

namespace professor_ratings
{
    class ProfessorRating
    {
        // data members
        private string professorName;
        private double professorID,
                       easinessRating,
                       helpfulnessRating,
                       clarityRating;
        // read-only property for ID, per specification
        public double ProfessorID { get; }
        // setters and getters for other properties
        public double ProfessorName { set; get; }
        public double EasinessRating { set; get; }
        public double HelpfulnessRating { set; get; }
        public double ClarityRating { set; get; }
        // default constructor
        public ProfessorRating()
        {
            professorID = 1234;
            professorName = "Dr. Know";
            easinessRating = 7;
            helpfulnessRating = 9;
            clarityRating = 10;
        }
        // constructor with arguments
        public ProfessorRating(string name, double id, double easiness, double helpfulness, double clarity)
        {
            professorID = id;
            professorName = name;
            easinessRating = easiness;
            helpfulnessRating = helpfulness;
            clarityRating = clarity;
        }
        // compute and return overall rating average
        public double RatingAverage()
        {
            return (easinessRating + helpfulnessRating + clarityRating) / 3;
        }
        // override base.ToString() method
        public override string ToString()
        {
            string result = String.Format("****** Professor Ratings Table ******\n");
            result += String.Format("* {0, 16} {1 ,16} *\n", "Professor Name:", professorName);
            result += String.Format("* {0, 16} {1 ,16} *\n", "Professor ID:", professorID);
            result += String.Format("* {0, 16} {1 ,16:N0} *\n", "Rating Average:", RatingAverage());
            result += String.Format("* {0, 16} {1 ,16:N0} *\n", "Easiness:", easinessRating);
            result += String.Format("* {0, 16} {1 ,16:N0} *\n", "Helpfulness:", helpfulnessRating);
            result += String.Format("* {0, 16} {1 ,16:N0} *\n", "Clarity:", clarityRating);
            result += String.Format("*************************************");
            return result;
        }
    }
}
