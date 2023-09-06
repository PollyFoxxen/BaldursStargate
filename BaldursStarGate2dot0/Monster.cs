namespace BaldursStarGate2dot0
{
    internal class Monster : Creature
    {
        public string Type { get; set; }
        public Monster()
        {
            CreateMonster();
            Health = MaxHealth;
        }

        private void CreateMonster()
        {
            switch (new Random().Next(100))
            {
                case < 20:
                    Type = "Orc";
                    MaxHealth = 150;
                    Armor = 5;
                    break;
                case < 40:
                    Type = "Dice Goblin";
                    MaxHealth = 50;
                    Armor = 2;
                    break;
                case < 45:
                    Type = "Dragon";
                    MaxHealth = 500;
                    Armor = 20;
                    break;
                case < 100:
                    Type = "Slime";
                    MaxHealth = 10;
                    Armor = 0;
                    break;
                default:
                    break;
            }
        }
    }
}
