using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Common;
using GuardiansOfTheCode.Facades;
using MilkyWayponLib;

namespace GuardiansOfTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimaryPlayer player = PrimaryPlayer.Instance;
            Console.WriteLine($"{player.Name} - Level {player.Level}");

            try
            {
                TestApiConnection().Wait();

                //TestDecorators();

                //Gameboard board = new Gameboard();
                //board.PlayerArea(1).Wait();

                GameboardFacade gameboard = new GameboardFacade();
                gameboard.Play(player, 1).Wait();


                //TestComposite();
                //Console.ReadKey();
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

        private static void TestComposite()
        {
            CardDeck deck = new CardDeck();
            CardDeck attackDeck = new CardDeck();
            CardDeck defenseDeck = new CardDeck();

            attackDeck.Add(new Card("Basic Infantry Unit", 12, 15));
            attackDeck.Add(new Card("Advanced Infantry Unit", 25, 18));
            attackDeck.Add(new Card("Cavarly Unit", 32, 24));

            defenseDeck.Add(new Card("Wooden Shield", 0, 6));
            defenseDeck.Add(new Card("IronShield", 0, 9));
            defenseDeck.Add(new Card("New shining Armor", 0, 40));


            deck.Add(attackDeck);
            deck.Add(new Card("Small Beast", 16, 3));
            deck.Add(new Card("High Elf Rouge", 22, 7));
            deck.Add(defenseDeck);

            deck.Display();
            Console.WriteLine(deck.Display());

        }
    }
}

