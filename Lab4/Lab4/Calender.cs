namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year > 9999 || month < 1 || month > 12)
            {
                return -1;
            }
            else if (month == 2)
            {
                if (IsLeapYear(year) == true)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else
            {
                return 30;
            }
        }
    }
}