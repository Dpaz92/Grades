using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    public class Gradebook
    {
        //attributes
        private List<float> notas;

        //constructor
        public Gradebook()
        {
            notas = new List<float>();

        }

        //methods
        public void AddGrade(float nota)
        {
            notas.Add(nota);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            

            foreach(float nota in notas)
            {
                sum += nota;

                stats.highestGrade = Math.Max(nota, stats.highestGrade);
                stats.lowestGrade = Math.Min(nota, stats.lowestGrade);
            }
            stats.averageGrade = sum / notas.Count;
            return stats;
        }
    }
}
