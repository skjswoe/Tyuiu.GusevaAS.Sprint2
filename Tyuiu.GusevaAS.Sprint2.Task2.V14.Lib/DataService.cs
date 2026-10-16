using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GusevaAS.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (y == 3)
            {
                if (x >= 3 && x <= 4) res = true;
                if (x >= 10 && x <= 13) res = true;
            }

            if (y == 4)
            {
                if (x >= 2 && x <= 5) res = true;
                if (x >= 10 && x <= 13) res = true;
            }

            if (y == 5)
            {
                if (x >= 2 && x <= 9) res = true;
            }

            if (y == 6)
            {
                if (x >= 3 && x <= 5) res = true;
                if (x == 7) res = true;
                if (x == 9) res = true;
            }

            if (y == 7 || y == 8)
            {
                if (x == 4) res = true;
                if (x == 7) res = true;
                if (x == 9) res = true;
            }

            if (y == 9 || y == 10)
            {
                if (x >= 4 && x <= 7) res = true;
                if (x == 9) res = true;
                if (x == 13) res = true;
            }

            if (y == 11)
            {
                if (x >= 2 && x <= 13) res = true;
            }

            if (y == 12)
            {
                if (x >= 4 && x <= 13) res = true;
            }

            if (y == 13)
            {
                if (x >= 4 && x <= 7) res = true;
                if (x == 13) res = true;
            }

            if (y == 14)
            {
                if (x == 13) res = true;
            }

            return res;
        }
    }
}