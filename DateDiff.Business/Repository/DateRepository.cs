using QM.Business.Repository.Interface;
using QM.Domain.Model;

namespace QM.Business.Repository
{
    public class DateRepository : IDateRepository
    {
        // days of the month container
        public int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        /// <summary>
        /// Calculates the Leap year which comes after every 4 year
        /// The leap year will be 366 and will add 1 day on month of Feb(29)
        /// </summary>
        /// <param name="date">Date</param>
        /// <returns>int</returns>
        public int CountLeapYears(Date date)
        {
            int years = date.year;

            if (date.month <= 2) years--;

            return   years / 4
                   - years / 100
                   + years / 400;
        }
        public int GetDifference(Date date1, Date date2)
        {
            // calculate the year from 00/00/0000 till date1 and 
            // add the number of days to n1
            int n1 = date1.year * 365 + date1.day;

            for (int i = 0; i < date1.month - 1; i++)
            {
                n1 += monthDays[i];
            }

            // Count leap year for date1
            n1 += CountLeapYears(date1);

            // calculate the year from 00/00/0000 till date2 and 
            // add the number of days to n2
            int n2 = date2.year * 365 + date2.day;
            for (int i = 0; i < date2.month - 1; i++)
            {
                n2 += monthDays[i];
            }

            // Count leap year for date2
            n2 += CountLeapYears(date2);

            return (n2 - n1);
        }
    }
}