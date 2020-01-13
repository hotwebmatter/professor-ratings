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
            ProfessorRating bProfessor = new ProfessorRating("Dr. Will Shortz", 1408, 8, 9, 10);
            WriteLine(bProfessor.ToString());
        }
    }
}
