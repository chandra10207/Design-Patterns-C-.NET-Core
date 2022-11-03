using System;
namespace GuardiansOfTheCode.Multiplayer
{
    public class TrialExpiredState : IState
    {

        private SubscriptionManager _manager = new SubscriptionManager();

        public TrialExpiredState(SubscriptionManager manager)
        {
            _manager = manager;
        }

        public void Expire()
        {
            throw new InvalidOperationException("can not expire");
        }

        public void Pay()
        {
            Console.WriteLine("Paid Membership");
            _manager.CurrentSate = new PaidState(_manager);
        }
    }
}

