namespace QM.Model
{
    public static class DateCalculator
    {
        public static int[] monthDays = { 31, 28, 31,
                                          30, 31, 30,
                                          31, 31, 30,
                                          31, 30, 31 };
        public static int CountLeapYears(Date date)
        {
            int years = date.year;

            if (date.month <= 2) years--;

            return   years / 4
                   - years / 100
                   + years / 400;
        }

        public static int GetDifference(Date date1, Date date2)
        {
            int n1 = date1.year * 365 + date1.day;

            for (int i = 0; i < date1.month - 1; i++)
            {
                n1 += monthDays[i];
            }

            n1 += CountLeapYears(date1);

            int n2 = date2.year * 365 + date2.day;
            for (int i = 0; i < date2.month - 1; i++)
            {
                n2 += monthDays[i];
            }
            n2 += CountLeapYears(date2);

            return (n2 - n1);
        }
    }
}