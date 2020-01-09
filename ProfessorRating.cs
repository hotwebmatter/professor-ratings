using System;
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
        // constructor
        public ProfessorRating()
        {
            professorID = 1234;
            professorName = "Dr. Know";
            easinessRating = 7;
            helpfulnessRating = 9;
            clarityRating = 10;
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
            result += String.Format("* {0, 16} {1 ,16} *\n", "Label:", "Value");
            return result;
        }
    }
}
