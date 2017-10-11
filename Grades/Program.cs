using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Gradebook book = new Gradebook();
            book.AddGrade(89.5f);
            book.AddGrade(91f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            
            Console.WriteLine(stats.highestGrade);
            Console.WriteLine(stats.averageGrade);
            Console.WriteLine(stats.lowestGrade);
            
        }
    }
}
