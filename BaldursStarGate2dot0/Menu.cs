namespace BaldursStarGate2dot0
{
    internal class Menu
    {
        public Menu()
        {
            while (true) StartMenu();
        }

        private void StartMenu()
        {
            Console.WriteLine("*** Menu ***");
            Console.WriteLine("[1] New Game");
            Console.WriteLine("[2] Load Game");
            Console.WriteLine("[3] Exit Game");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    new Game();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
