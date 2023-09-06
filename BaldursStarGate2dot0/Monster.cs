namespace BaldursStarGate2dot0
{
    internal class Monster : Creature
    {
        public string Type { get; set; }
        public Monster()
        {
            CreateMonster();
        }

        private void CreateMonster()
        {
            switch (new Random().Next(100))
            {
                case < 20:
                    Type = "Orc";
                    MaxHealth = 0;
                    break;
                case < 40:
                    Type = "Dice Goblin";
                    break;
                case < 45:
                    Type = "Dragon";
                    break;
                case < 100:
                    Type = "Slime";
                    break;
                default:
                    break;
            }
        }
    }
}
