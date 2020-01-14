using System;
using static System.Console;

namespace professor_ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            ProfessorRating aProfessor = new ProfessorRating();
            WriteLine(aProfessor.ToString());
            ProfessorRating bProfessor = new ProfessorRating("Dr. No", 1408, 9, 5, 3);
            WriteLine(bProfessor.ToString());
        }
    }
}
