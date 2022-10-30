using System;
using Common;

namespace GuardiansOfTheCode
{
    // Singleton Pattern
    public sealed class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;

        public IWeapon Weapon { get; set; }

        //public Card[] 

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                name = "Chandra",
                level = 1,
                Armor = 24,
                Health = 100,


            };
        }

        public static PrimaryPlayer Instance
        {
            get
            {
                return _instance;
            }
        }

        public string name { get; set; }
        public int level { get; set; }
        public int Armor { get; set; }
        public int  Health { get; set; }
        public Card[] Cards { get; internal set; }
    }
}

