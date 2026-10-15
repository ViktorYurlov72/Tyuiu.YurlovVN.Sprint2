using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YurlovVN.Sprint2.Task3.V4.Lib
{
    public class DataService : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = Math.Round(x + Math.Pow((x + 1) / (x - 1), x), 3);
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Round((x * x + (Math.Cos(x * x))) / (x * x - (Math.Sin(x * x)) + 12), 3);
                }
                else
                {
                    if ((x > -8) && (x < 0))
                    {
                        y = Math.Round(Math.Pow(x - (1 / (x * x)), x), 3);
                    }
                    else
                    {
                        if (x < -8)
                        {
                            y = Math.Round(x + 10 * x - (1 / x), 3);
                        }
                    }
                }
            }
            return y;
        }
    }
}