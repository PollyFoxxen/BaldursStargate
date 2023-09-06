namespace BaldursStarGate2dot0
{
    internal class Game
    {
        //TODO Cleanup (refactoring)
        //TODO Choose weapons
        public Game()
        {
            Console.WriteLine("We have started our game constructor by instantiating an object");
            Player pg = CreatePlayer();
            Monster mg = CreateMonster();
            Battle(pg, mg);
        }

        private void Battle(Player pg, Monster mg)
        {
            Console.WriteLine("Player opens a chest, and out jumps a... " + mg.Type);
        }

        private Player CreatePlayer()
        {
            Player pcp = new Player();
            pcp.MaxHealth = 100;
            pcp.Health = pcp.MaxHealth;
            pcp.Armor = 2;
            return pcp;
        }

        private Monster CreateMonster()
        {
            return new Monster();
        }

    }
}
