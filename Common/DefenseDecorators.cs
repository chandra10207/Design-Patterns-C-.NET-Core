using System;
using System.Collections.Generic;
namespace Common
{
    public class DefenseDecorators : CardDecorator
    {
        public DefenseDecorators(Card card, string name, int defense) : base(card, name, 0,defense)
        {
        }
    }
}


