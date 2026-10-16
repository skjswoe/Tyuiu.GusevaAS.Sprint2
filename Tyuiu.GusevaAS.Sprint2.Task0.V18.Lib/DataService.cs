using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GusevaAS.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;
            res[1] = x != y;
            res[2] = x % y != 0;
            res[3] = x / y > 0;
            res[4] = x - y > 0;
            res[5] = x + y == 0;

            return res;
        }
    }
}
