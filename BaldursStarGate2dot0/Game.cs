namespace BaldursStarGate2dot0
{
    internal class Game
    {
        public static int Dice = 20;
        //TODO Cleanup (refactoring)
        //TODO Choose weapons
        //Save in files
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
            return pcp;
        }

        private Monster CreateMonster()
        {
            return new Monster();
        }
    }
}