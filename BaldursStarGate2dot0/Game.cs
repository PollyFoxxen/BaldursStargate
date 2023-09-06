namespace BaldursStarGate2dot0
{
    internal class Game
    {
        public static int Dice = 20;
        //TODO Cleanup (refactoring)
        //TODO Choose weapons
        //TODO Save in files
        //TODO Register player
        //TODO Exceptions

        public static Random Rnd = new Random();

        public Game()
        {
            Console.WriteLine("We have started our game constructor by instantiating an object");
            Player pg = CreatePlayer();
            Monster mg = CreateMonster();
            new Battle(pg, mg);
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