namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int color;
            string? text;

            while (true)
            {
                Console.Write("Please, enter the color number from 0 to 15: ");
                while (!int.TryParse(Console.ReadLine(), out color))
                {
                    Console.WriteLine("Entered value is incorrect. Please, try again...");
                }

                Console.Write("Please, enter the text: ");
                text = Console.ReadLine();

                if (!string.IsNullOrEmpty(text))
                {
                    MyColors.Print(text, color);
                }
     
                Console.WriteLine(new string('-', 25));
            }
        }
    }
}