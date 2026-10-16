using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GusevaAS.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (x * x + y * y <= 1) && (y <= x);
        }
    }
}
