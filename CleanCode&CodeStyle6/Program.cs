using System;

namespace CleanCode_CodeStyle6
{
    internal class Programm
    {
        public static void CreateNewObject()
        {
            //Создание объекта на карте
        }

        public static void GenerateChance()
        {
            _chance = Random.Range(0, 100);
        }

        public static int GetCalculatedSalary(int hoursWorked)
        {
            return _hourlyRate * hoursWorked;
        }
    }
}
