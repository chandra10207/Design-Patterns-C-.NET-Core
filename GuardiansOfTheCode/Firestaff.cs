using System;
namespace GuardiansOfTheCode
{
    public class Firestaff : IWeapon
    {
        private int _damage;
        private int _fireDamage;

        public int Damage { get => _damage; }

        public Firestaff(int damage, int fireDamage)
        {
            _damage = damage;
            _fireDamage = fireDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.OvertimeDamage -= _fireDamage;
        }
    }
}

