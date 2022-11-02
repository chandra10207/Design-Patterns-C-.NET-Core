﻿using System;
namespace GuardiansOfTheCode.Strategies
{
    public class CriticalHealthIndicator :IDamageIndicator
    {
        public void NotifyAboutDamage(int health, int damage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"HEALTH CRITICAL {damage} damage points , {health} HP remaining");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}

