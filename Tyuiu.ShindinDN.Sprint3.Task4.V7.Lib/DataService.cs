using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShindinDN.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double value = 1;
            for (double i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                value *= ((i / Math.Cos(i))+1.5);
            }
            return Math.Round(value, 3);
        }
    }
}
