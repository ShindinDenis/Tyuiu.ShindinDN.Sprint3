using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShindinDN.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double value = 0;
            for (double i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                i = i * ((i / Math.Cos(i))+1.5);
                value = i;
            }
            return Math.Round(value, 3);
        }
    }
}
