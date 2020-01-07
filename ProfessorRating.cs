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
        public string Name { set; get; }
        public double EasinessRating { set; get; }
        public double HelpfulnessRating { set; get; }
        public double ClarityRating { set; get; }
        // compute and return overall rating average
        public double RatingAverage()
        {
            return (easinessRating + helpfulnessRating + clarityRating) / 3;
        }
    }
}
