using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            int length;
            if ((length = usersPerDay.Length) != revenuePerDay.Length)
            {
                return false;
            }

            bool bCheck = false;
            for (int i = 0; i < length; i++)
            {
                double tmp;

                if (usersPerDay[i] <= 10)
                {
                    tmp = Math.Round((double)usersPerDay[i] / 2, 2);
                }
                else if (usersPerDay[i] <= 100)
                {
                    tmp = Math.Round(16 * (double)usersPerDay[i] / 5 - 27, 2);
                }
                else if (usersPerDay[i] <= 1000)
                {
                    tmp = Math.Round(Math.Pow(usersPerDay[i], 2) / 4 - 2 * (double)usersPerDay[i] - 2007, 2);
                }
                else
                {
                    tmp = Math.Round(245743 + (double)usersPerDay[i] / 4, 2);
                }

                if (tmp != revenuePerDay[i])
                {
                    revenuePerDay[i] = tmp;
                    bCheck = true;
                }
            }

            return bCheck;
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            int length;
            if ((length = usersPerDay.Length) != revenuePerDay.Length)
            {
                return -1;
            }

            int cnt = 0;
            for (int i = 0; i < length; i++)
            {
                double tmp;

                if (usersPerDay[i] <= 10)
                {
                    tmp = Math.Round((double)usersPerDay[i] / 2, 2);
                }
                else if (usersPerDay[i] <= 100)
                {
                    tmp = Math.Round(16 * (double)usersPerDay[i] / 5 - 27, 2);
                }
                else if (usersPerDay[i] <= 1000)
                {
                    tmp = Math.Round(Math.Pow(usersPerDay[i], 2) / 4 - 2 * (double)usersPerDay[i] - 2007, 2);
                }
                else
                {
                    tmp = Math.Round(245743 + (double)usersPerDay[i] / 4, 2);
                }

                if (tmp != revenuePerDay[i])
                {
                    cnt++;
                }
            }

            return cnt;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            int length;
            if ((length = revenuePerDay.Length) == 0)
            {
                return -1;
            }
            else if (start >= length || end >= length || start > end)
            {
                return -1;
            }

            double sum = 0;
            for (uint i = start; i <= end; i++)
            {
                sum += revenuePerDay[i];
            }

            return sum;
        }
    }
}