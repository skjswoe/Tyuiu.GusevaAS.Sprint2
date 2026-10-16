using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GusevaAS.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = a == b;
            res[1] = a != b;
            res[2] = c < d;
            res[3] = c > d;
            res[4] = a >= d;
            res[5] = c >= d;

            return res;
        }
    }
}
