using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YurlovVN.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((y >= x * x - 2) && (y <= x)) || (((y >= y * x - 2) && (y <= x))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}