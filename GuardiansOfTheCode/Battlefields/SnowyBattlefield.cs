using System;
namespace GuardiansOfTheCode.Battlefields
{
    public class SnowyBattlefield : BattlefieldTemplate
    {
        public SnowyBattlefield()
        {
        }

        public override string DescribeClimate()
        {
            return "Cold";
        }

        public override string DescribeEffects()
        {
            return "hard to see";
        }

        public override string DescribeGround()
        {
            return "covered in snow";
        }
    }
}

