using System;
namespace GuardiansOfTheCode
{
    public interface IWeapon
    {

        void Use(IEnemy enemy);
        int Damage { get; }
    }
}

