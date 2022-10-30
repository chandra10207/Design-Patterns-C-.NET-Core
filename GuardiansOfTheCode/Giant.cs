using System;
namespace GuardiansOfTheCode
{
    public class Giant
    {
        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }

        public int Level => _level;

        public int OvertimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Giant(int health, int level)
        {
            _health = health;
            _level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Giant Attacking" + player.name);

        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Giant Defendending" + player.name);
        }
    }
}

