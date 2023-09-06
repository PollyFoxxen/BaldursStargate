namespace BaldursStarGate2dot0
{
    internal class Game
    {
        int dice = 20;
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
            Console.WriteLine("Player opens a chest, and out jumps a... " + monster.Type);
            bool continueBattle = true;
            int counter = 1;
            while (continueBattle)
            {
                Console.WriteLine("Round " + counter++);
                Console.ReadKey();
                if (WhoStarts() == 0)
                {
                    continueBattle = Attack(player, monster);
                    if (!continueBattle) break;
                    continueBattle = Attack(monster, player);
                }
                else
                {
                    continueBattle = Attack(monster, player);
                    if (!continueBattle) break;
                    continueBattle = Attack(player, monster);
                }
            }
        }

        private bool Attack(Creature attacker, Creature defender)
        {
            int att = AttackRoll();
            Console.WriteLine(attacker.Type + " swings, and rolls a " + att);
            att = ArmorReduction(att, defender);
            Console.WriteLine(defender.Type + "'s armor reduces attack to " + att);
            defender.ReduceHealth(att);
            Console.WriteLine($"{defender.Type} have {defender.Health} health left.");

            //We check if someone died, and if, we return false, so we can stop the battle
            if (defender.Health <= 0) 
            { 
                Console.WriteLine(defender.Type + " have died");
                return false;
            }
            
            return true;
        }

        private int ArmorReduction(int att, Creature creature)
        {
            return Math.Max(0, att - creature.Armor);
        }

        //TODO Add modifier dependent on weapon or defender 
        private int AttackRoll()
        {
            int att = rnd.Next(dice);
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
            pcp.Type = "Player";
            return pcp;
        }

        private Monster CreateMonster()
        {
            return new Monster();
        }

    }
}
