using System;
namespace GuardiansOfTheCode.Multiplayer
{
    public class SubscriptionManager
    {

        public IState CurrentSate;

        public SubscriptionManager()
        {
            CurrentSate = new OnTrialState(this);
        }

        public void Expire()
        {
            CurrentSate.Expire();
        }

        public void Pay()
        {
            CurrentSate.Pay();
        }
    }
}

