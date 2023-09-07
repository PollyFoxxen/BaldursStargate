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
            Console.Clear();
            Console.WriteLine($"{player} opens a stargate, and out jumps a {monster}.");
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
            int roll = AttackRoll();
            Console.WriteLine($"{attacker} swings, and rolls a " + roll);
            roll = ArmorReduction(roll, defender);
            Console.WriteLine(defender + "'s armor reduces attack to " + roll);
            defender.ReduceHealth(roll);
            Console.WriteLine($"{defender} have {defender.Health} health left.");

            //We check if someone died, and if, we return false, so we can stop the battle
            if (defender.Health <= 0)
            {
                Console.WriteLine(defender + " have died");
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
