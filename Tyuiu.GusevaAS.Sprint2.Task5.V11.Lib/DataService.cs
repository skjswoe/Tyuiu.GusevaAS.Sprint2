using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GusevaAS.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }

            int nextN = n + 1;
            int nextM = m;
            int nextG = g;

            if (nextN > daysInMonth)
            {
                nextN = 1;
                nextM++;
                if (nextM > 12)
                {
                    nextM = 1;
                    nextG++;
                }
            }

            return $"{nextN:D2}.{nextM:D2}.{nextG:D4}";
        }
    }
}
