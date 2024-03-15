using System.Globalization;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime birthday = BirthDay.GetBirthDate();
                Console.WriteLine($"{BirthDay.CountDays(birthday)} days to the next birthday");
            }
        }
    }
}