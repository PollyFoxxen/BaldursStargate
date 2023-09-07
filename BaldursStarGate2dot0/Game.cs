namespace BaldursStarGate2dot0
{
    internal class Game
    {
        //TODO GUI Life / level / mana
        //TODO Counter Battles won
        //TODO XP & Level
        //TODO Cleanup (refactoring)
        //TODO Choose weapons
        //TODO Save in files
        //TODO Register player
        //TODO Exceptions

        public static int Dice = 20;
        public static Random Rnd = new Random();

        public Game()
        {
            Console.WriteLine("We have started our game constructor by instantiating an object");
            Player pg = CreatePlayer();
            GameMenu(pg);
        }

        void GameMenu(Player player)
        {
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("*** Menu ***");
                Console.WriteLine("[1] Open Stargate");
                Console.WriteLine("[2] Go shopping");
                Console.WriteLine("[3] Rest & Relax");
                Console.WriteLine("[4] Return to main menu");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Monster monster = CreateMonster();
                        new Battle(player, monster);
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        //TODO Create a shop
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        //TODO Property GET SET
                        player.Health += 10;
                        break;
                    case ConsoleKey.D4:
                        isExit = true;
                        break;
                    default:
                        break;
                }
            }
        }


        private Player CreatePlayer()
        {
            Player pcp = new Player();
            pcp.MaxHealth = 100;
            pcp.Health = pcp.MaxHealth;
            pcp.Armor = 2;
            pcp.Type = "Player";
            Console.Write("What is your name: ");
            pcp.Name = Console.ReadLine();
            return pcp;
        }

        private Monster CreateMonster()
        {
            return new Monster();
        }
    }
}