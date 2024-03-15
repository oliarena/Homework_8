using System.Drawing;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours;
            Accountant accountant = new Accountant();

            while (true)
            {
                Console.Write("Please, enter working hours ");
                while (!int.TryParse(Console.ReadLine(), out hours))
                {
                    Console.WriteLine("Entered value is incorrect. Please, try again...");
                }

                Console.WriteLine("Junior's " + GetStatusString(accountant.AskForBonus(Post.Junior, hours)));
                Console.WriteLine("Middle's " + GetStatusString(accountant.AskForBonus(Post.Middle, hours)));
                Console.WriteLine($"Senior's " + GetStatusString(accountant.AskForBonus(Post.Seniour, hours)));
                Console.WriteLine($"Manager's " + GetStatusString(accountant.AskForBonus(Post.Manager, hours)));

                Console.WriteLine(new string('-', 25));
            }
        }

        static string GetStatusString(bool isAvailable)
        {
            return isAvailable ? "bonus is avalable" : "bonus is not available";
        }


    }
}