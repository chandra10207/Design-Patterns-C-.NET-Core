﻿using System;
namespace GuardiansOfTheCode
{
    public class IceStaff : IWeapon
    {
        private int _damage;
        private int _paralyzedFor;

        public int Damage { get => _damage; }

        public IceStaff(int damage, int paralyzedFor)
        {
            _damage = damage;
            _paralyzedFor = paralyzedFor;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.ParalyzedFor = _paralyzedFor;
        }
        
    }
}

