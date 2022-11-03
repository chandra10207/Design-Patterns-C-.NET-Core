using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;

namespace GuardiansOfTheCode
{
    public class EnemyFactory
    {
        private int _areaLevel;
        private Stack<Zombie> _zombiePool = new Stack<Zombie>();
        private Stack<Werewolf> _werewolvesPool = new Stack<Werewolf>();
        private Stack<Giant> _giantsPool = new Stack<Giant>();

        private void PreloadZombies()
        {
            int count;
            int health;
            int armor;
            int level;

            if (_areaLevel < 3)
            {
                count = 15;
                (health, level, armor) = GetZombieStatus(_areaLevel);
            }
            else if (_areaLevel >= 3 && _areaLevel < 10)
            {

                count = 15;
                (health, level, armor) = GetZombieStatus(_areaLevel);

            }
            else
            {

                count = 15;
                (health, level, armor) = GetZombieStatus(_areaLevel);
            }

            for (int i=0; i<count; i++)
            {
                _zombiePool.Push(new Zombie(health, level, armor));
            }


        }

        private (int health, int level , int armor) GetZombieStatus(int areaLevel)
        {
            int health, armor, level,count;
            if (areaLevel < 3)
            {
                count = 15;
                health = 66;
                level = 2;
                armor = 15;

            }
            else if (areaLevel >= 3 && areaLevel < 10)
            {

                count = 15;
                health = 66;
                level = 2;
                armor = 15;

            }
            else
            {

                count = 15;
                health = 66;
                level = 2;
                armor = 15;
            }
            return (health, level, armor);


        } 

        public void ReclaimZombie(Zombie zombie)
        {
            (int health, int level, int armor) = GetZombieStatus(_areaLevel);
            zombie.Health = health;
            //zombie.Level = level;
            zombie.Armor = armor;
            _zombiePool.Push(zombie);

        }



        public int AreaLevel { get => _areaLevel; }

        public EnemyFactory(int areaLevel)
        {
            _areaLevel = areaLevel;
            PreloadZombies();

        }



        public Werewolf SpawnWerewolf(int areaLevel)
        {
            if(areaLevel < 5)
            {
                return new Werewolf(100, 12);
            }
            else
            {
                return new Werewolf(100, 20);
            }

        }

        public Giant SpawnGiant (int areaLevel)
        {

            if (areaLevel < 8)
            {
                return new Giant(100, 14);
            }
            else
            {
                return new Giant(100, 32);
            }
        }



        public Zombie SpawnZombie(int areaLevel)
        {
            if(_zombiePool.Count > 0)
            {
                return _zombiePool.Pop();

            }
            else
            {
                throw new Exception("Zombies pool depleted");

            }
           
        }




    }
}

