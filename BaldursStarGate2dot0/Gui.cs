namespace BaldursStarGate2dot0
{
    internal class Gui
    {
        public static void ShowPlayer(Player player)
        {
            if (player == null) return;
            Print(40, 1, player.Name);
            Print(40, 2, $"Health : {player.Health} / {player.MaxHealth}", ConsoleColor.Red);
        }

        public static void Print(int x, int y, string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
    }
}
