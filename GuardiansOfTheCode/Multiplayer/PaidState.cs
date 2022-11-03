using System;
namespace GuardiansOfTheCode.Multiplayer
{
    public class PaidState : IState

    {

        private SubscriptionManager _manager;


        public PaidState( SubscriptionManager manager)
        {
            _manager = manager;
        }

        public void Expire()
        {
            throw new InvalidOperationException("Can not expire");
        }

        public void Pay()
        {
            throw new InvalidOperationException("Already paid.");
        }
    }
}

