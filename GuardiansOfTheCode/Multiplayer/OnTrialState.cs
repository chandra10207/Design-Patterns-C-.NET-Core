using System;

namespace GuardiansOfTheCode.Multiplayer
{
    public class OnTrialState : IState
    {
        private SubscriptionManager _manager;

        public OnTrialState(SubscriptionManager manager)
        {
            _manager = manager;
        }

        public void Expire()
        {
            Console.WriteLine("Trial Expired");
            _manager.CurrentSate = new TrialExpiredState(_manager);

        }

        public void Pay()
        {
            Console.WriteLine("paid membership acquired");
            _manager.CurrentSate = new PaidState(_manager);
        }
    }
}

