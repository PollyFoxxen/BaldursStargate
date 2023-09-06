namespace BaldursStarGate2dot0
{
    internal class Game
    {
        //TODO Cleanup (refactoring)
        //TODO Choose weapons
        private Random rnd = new Random();

        public Game()
        {
            Console.WriteLine("We have started our game constructor by instantiating an object");
            Player pg = CreatePlayer();
            Monster mg = CreateMonster();
            Battle(pg, mg);
        }

        private void Battle(Player player, Monster monster)
        {
            int att = 0;
            Console.WriteLine("Player opens a chest, and out jumps a... " + monster.Type);
            if (WhoStarts() == 0) 
            { 
                att = PlayerAttack();
                att = ArmorReduction(att, monster);
                monster.ReduceHealth(att);
                if (monster.Health <= 0) Console.WriteLine(monster.Type+ " have died");
            }
            else 
            { 
                //MonsterAttack(); 
            }
        }

        private int ArmorReduction(int att, Monster monster)
        {
            return Math.Max(0, att - monster.Armor);
        }

        private int PlayerAttack()
        {
            int att = rnd.Next(10);
            return att;
        }

        private int WhoStarts()
        {
            return rnd.Next(2);
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
