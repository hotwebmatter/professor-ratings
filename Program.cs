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
        }
    }
}
