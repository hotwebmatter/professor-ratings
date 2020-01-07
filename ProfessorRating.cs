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
    }
}
