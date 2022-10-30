using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Common;
using MilkyWayponLib;

namespace GuardiansOfTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TestApiConnection().Wait();
                //TestDecorators();
                //ISpaceWeapon

                //Gameboard board = new Gameboard();
                //board.PlayerArea(1);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Failed to initialize the game");
                Console.ReadKey();
            }
        }

        private static async Task TestApiConnection()
        {
            int maxAttempts = 20;
            //Interval in millisecond
            int attempInterval = 2000;

            using( var http= new HttpClient())
            {
                for (int i = 0; i < maxAttempts; i++)
                {
                    try
                    {
                        var response = await http.GetAsync("http://localhost:23481/api/cards");
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            return;
                        }

                    }
                    catch(Exception e)
                    {
                    }
                    finally
                    {
                        Console.WriteLine("Lost connection to the server.");
                        Thread.Sleep(attempInterval);

                    }
                }

                throw new Exception("Failed to connect to the server.");

            }

        }


        private static void TestDecorators()
        {
            Card soldier = new Card("Soldier",25,20);
            soldier = new AttackDecorator(soldier, "Sword", 15);
            soldier = new AttackDecorator(soldier, "Amulet", 5);
            soldier = new DefenseDecorators(soldier, "Helmet", 10);
            soldier = new DefenseDecorators(soldier, "Heavy Armor", 45);
            Console.WriteLine($"Final State: {soldier.Attack} / {soldier.Defense}");


        }
    }
}

