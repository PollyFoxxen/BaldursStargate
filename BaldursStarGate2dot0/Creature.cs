namespace BaldursStarGate2dot0
{
    internal abstract class Creature
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public string Type { get; set; } = "Unknown";

        public void ReduceHealth(int damage)
        {
            Health -= damage;
        }
    }
}
