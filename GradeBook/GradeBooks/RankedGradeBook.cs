using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            char letterGrade = 'F';

            if(Students.Count < 5)
            {
                throw new InvalidOperationException($"Number of Students should be 5 OR more. Current Students Count is {Students.Count}");
            }

            if(averageGrade >= 80)
            {
                letterGrade = 'A';
            }
            else if (averageGrade >= 60)
            {
                letterGrade = 'B';
            }
            else if (averageGrade >= 40)
            {
                letterGrade = 'C';
            }
            else if (averageGrade >= 20)
            {
                letterGrade = 'D';
            }

            return letterGrade;
        }


        public override void CalculateStatistics()
        {
            base.CalculateStatistics();
        }

    }

}
