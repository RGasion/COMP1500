using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class Monster
    {
        public string Name { get; private set; }
        public EElementType ElementType { get; private set; }
        public int Health { get; private set; }
        public int AttackStat { get; private set; }
        public int DefenseStat { get; private set; }

        public Monster(string name, EElementType elementType, int health, int attack, int defense)
        {
            Name = name;
            ElementType = elementType;
            Health = health;
            AttackStat = attack;
            DefenseStat = defense;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;

            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Attack(Monster otherMonster)
        {
            float damage = AttackStat - otherMonster.DefenseStat;
            
            if (IsTypeBonus(ElementType, otherMonster.ElementType) == true)
            {
                damage *= 1.5f;
            }
            else if (IsTypePenalty(ElementType, otherMonster.ElementType) == true)
            {
                damage *= 0.5f;
            }

            if (damage < 1)
            {
                damage = 1;
            }

            otherMonster.TakeDamage((int)damage);
        }

        public bool IsTypeBonus(EElementType attackType, EElementType defenseType)
        {
            if (attackType == EElementType.Fire)
            {
                if (defenseType == EElementType.Wind)
                {
                    return true;
                }
            }

            if (attackType == EElementType.Water)
            {
                if (defenseType == EElementType.Fire)
                {
                    return true;
                }
            }

            if (attackType == EElementType.Earth)
            {
                if (defenseType == EElementType.Fire)
                {
                    return true;
                }
            }

            if (attackType == EElementType.Wind)
            {
                if (defenseType == EElementType.Earth)
                {
                    return true;
                }

                if (defenseType == EElementType.Water)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsTypePenalty(EElementType attackType, EElementType defenseType)
        {
            if (attackType == EElementType.Fire)
            {
                if (defenseType == EElementType.Earth)
                {
                    return true;
                }

                if (defenseType == EElementType.Water)
                {
                    return true;
                }
            }

            if (attackType == EElementType.Water)
            {
                if (defenseType == EElementType.Wind)
                {
                    return true;
                }
            }

            if (attackType == EElementType.Earth)
            {
                if (defenseType == EElementType.Wind)
                {
                    return true;
                }
            }

            if (attackType == EElementType.Wind)
            {
                if (defenseType == EElementType.Fire)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
