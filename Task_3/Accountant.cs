namespace Task_3
{
    internal class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return (((int)worker > 0) && (hours > (int)worker));
        }
    }
}
