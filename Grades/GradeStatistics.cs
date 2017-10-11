using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        //attributes
        public float highestGrade;
        public float lowestGrade;
        public float averageGrade;

        //constructor
        public GradeStatistics()
        {
            highestGrade = 0;
            lowestGrade = 100;
        }
    }
}
