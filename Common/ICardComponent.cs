using System;
namespace Common
{
    public interface ICardComponent
    {

        void Add(ICardComponent card);
        ICardComponent Get(int index);
        bool Remove(ICardComponent card);
        string Display();



    }
}

