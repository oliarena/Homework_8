namespace Task_2
{
    internal static class MyColors
    {
        enum Colors 
        {
            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }

        public static void Print(string text, int color)
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            switch (color)
            {
                case (int)Colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case (int)Colors.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case (int)Colors.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case (int)Colors.DarkCyan:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case (int)Colors.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case (int)Colors.DarkMagenta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case (int)Colors.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case (int)Colors.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case (int)Colors.DarkGray:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine(text);
            Console.ForegroundColor = foregroundColor;
        }

        public static void SimplePrint(string text, int color)
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor) color;
            Console.WriteLine(text);

            Console.ForegroundColor = foregroundColor;
            
        }
    }
}
