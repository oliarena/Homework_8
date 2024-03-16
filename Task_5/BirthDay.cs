using System.Globalization;

namespace Task_5
{
    internal static class BirthDay
    {
        public static DateTime GetBirthDate()
        {
            DateTime birthDate;
            string? str;

            Console.Write("Please, enter the your birthday date DD/MM: ");
            str = Console.ReadLine();
            while (string.IsNullOrEmpty(str) || !ParseDateUA(str + "/2000", out birthDate))
            {
                Console.WriteLine("Entered value is incorrect. Please, try again...");
                str = Console.ReadLine();
            }

            return birthDate;
        }

        public static bool ParseDateUA(string str, out DateTime date)
        {
            return DateTime.TryParse(str, new CultureInfo("uk-UA"), DateTimeStyles.None, out date);
        }

        public static int CountDays(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            DateTime thisBirthDate = new DateTime(today.Year, birthDate.Month, birthDate.Day);

            if (thisBirthDate > today)
            {
                return (thisBirthDate - today).Days;
            }
            else
            {
                return (thisBirthDate.AddYears(1) - today).Days;
            }
        }
    }
}
