using System;
using System.IO;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            double totalPrice = 0;
            for (int i = 0; i < 5; i++)
            {
                totalPrice += double.Parse(input.ReadLine());
            }

            double tip = (100 + double.Parse(input.ReadLine())) / 100;

            const double TAX = 1.05;
            return Math.Round(totalPrice * tip * TAX, 2);
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            double people = double.Parse(input.ReadLine());

            return Math.Round(totalCost / people, 2);
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            double pay = double.Parse(input.ReadLine());

            if (pay >= totalCost)
            {
                return 1;
            }
            else
            {
                return (uint)(totalCost / pay) + 1;
            }
            
        }
    }
}