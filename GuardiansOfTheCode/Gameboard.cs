using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common;
using Newtonsoft.Json;
using System.Net.Http;
using System.Linq;
using GuardiansOfTheCode.Adapters;
using MilkyWayponLib;

namespace GuardiansOfTheCode
{
    public class Gameboard
    {
        private PrimaryPlayer _player;

        public Gameboard()
        {
            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);

        }

        public async Task PlayerArea(int level)
        {
            if(level == 1)
            {
                _player.Cards = (await FetchCards()).ToArray();
                Console.WriteLine("Ready to play Level 1 ?");
                Console.ReadKey();
                PlayerFirstLevel();
            }
            else if (level == -1)
            {
                Console.WriteLine("Play special level -1 ?");
                Console.ReadKey();
                PlaySpecialLevel();

            }

        }

        public void PlaySpecialLevel()
        {
            _player.Weapon = new WeaponAdapter(Blaster(20, 15, 15));
        }

        private ISpaceWeapon Blaster(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public void PlayerFirstLevel()
        {
            const int currentLevel = 1;
            EnemyFactory factory = new EnemyFactory(currentLevel);

            List<IEnemy> enemies = new List<IEnemy>();

            for(int i=0; i<10; i++)
            {
                enemies.Add(factory.SpawnZombie(currentLevel));
            }

            for (int i = 0; i < 3; i++)
            {
                enemies.Add(factory.SpawnWerewolf(currentLevel));
            }

            foreach (var enemy in enemies)
            {
                while(enemy.Health > 0 || _player.Health > 0)
                {
                    _player.Weapon.Use(enemy);
                    enemy.Attack(_player);

                }


              
            }

        }



        private async Task<IEnumerable<Card>> FetchCards()
        {
            using(var http = new HttpClient())
            {
                var cardsJson = await http.GetStringAsync("http://localhost:23481/api/cards");
                return JsonConvert.DeserializeObject<IEnumerable<Card>>(cardsJson);

            }
        }


        
    }
}

