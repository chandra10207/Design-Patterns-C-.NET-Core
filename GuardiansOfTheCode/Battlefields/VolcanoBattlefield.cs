using System;
namespace GuardiansOfTheCode.Battlefields
{
    public class VolcanoBattlefield : BattlefieldTemplate
    {
        public VolcanoBattlefield()
        {
        }

        public override string DescribeClimate()
        {
            return "fog dust";
        }

        public override string DescribeEffects()
        {
            return "flames";
        }

        public override string DescribeGround()
        {
            return "rocky";
        }
    }
}

