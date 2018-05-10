using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    public class GradingStudents
    {
        public static int[] gradingStudents(int[] grades)
        {
            int[] newGrades = new int[grades.Length];
            for(int i=0; i<grades.Length; i++)
            {
                newGrades[i] = roundGrade(grades[i]);
            }
            return newGrades;
        }

        public static int roundGrade(int grade)
        {
            if ( grade < 38 )
            {
                return grade;
            }
            if (grade <= 40)
            {
                return 40;
            }

            int remainder = grade % 5;
            int floorGrade = (grade - remainder) / 5;
            int nextHigher = (floorGrade * 5) + 5;
            if ( (nextHigher - grade) < 3)
            {
                return nextHigher;
            }

            return grade;
        }
    }
}
