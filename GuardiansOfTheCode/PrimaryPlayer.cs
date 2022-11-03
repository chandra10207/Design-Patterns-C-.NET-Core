using System;
using Common;
using GuardiansOfTheCode.Events;

namespace GuardiansOfTheCode
{
    // Singleton Pattern
    public sealed class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;

        private PrimaryPlayer() { }


        public IWeapon Weapon { get; set; }

        private int _health;

        public Card[] Cards { get; set; }
        //public Card[] Cards { get; internal set; }

        private event EventHandler<HealthChangedEventArgs> HealthChanged;

        public void RegisterObserver(EventHandler<HealthChangedEventArgs> observer)
        {
            HealthChanged += observer;
        }

        public void UnregisterObserver(EventHandler<HealthChangedEventArgs> observer)
        {
            HealthChanged -= observer;
        }


        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Chandra",
                Level = 1,
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

        public string Name { get; set; }
        public int Level { get; set; }
        public int Armor { get; set; }
        public int  Health
        {
            get
            {
                return _health;
            }
            private set
            {
                _health = Health ;
                if (HealthChanged != null)
                {
                    HealthChanged(this, new HealthChangedEventArgs(Health));
                }
                // Smaller form of the above code
                //HealthChanged?.Invoke(this, new HealthChangedEventArgs(Health));
            }
        }


        public void Hit(int damage)
        {
           Health -= damage;

        }






        
    }
}

