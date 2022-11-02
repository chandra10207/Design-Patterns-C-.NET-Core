using System;

namespace Common
{
    public class Card :ICardComponent
    {
        protected string _name;
        protected int _attack;
        protected int _defense;

        public Card (string name, int attack, int defense)
        {
            _name = name;
            _attack = attack;
            _defense = defense;

        }

        public virtual string Name
        {
            get{
                return _name;
            }
        }

        public virtual int Attack
        {
            get
            {
                return _attack;
            }
        }
        public virtual int Defense { get { return _defense; } }

        public void Add(ICardComponent card)
        {
            throw new NotImplementedException();
        }

        public string Display()
        {
            return $"{_name}: {_attack} : {_defense}";
        }

        public ICardComponent Get(int index)
        {
            throw new NotImplementedException();
        }

        public bool Remove(ICardComponent card)
        {
            throw new NotImplementedException();
        }



        //public string Name { get; set; }
        //public int Attack { get; set; }
        //public int Defense { get; set; }

    }
}

