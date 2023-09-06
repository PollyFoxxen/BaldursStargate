namespace BaldursStarGate2dot0
{
    internal class Battle
    {
        public Battle(Player player, Monster monster)
        {
            Combat(player, monster);
        }

        private void Combat(Player player, Monster monster)
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
            int att = Game.Rnd.Next(Game.Dice);
            return att;
        }

        private int WhoStarts()
        {
            return Game.Rnd.Next(2);
        }
    }
}
