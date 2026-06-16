using System;

namespace Game
{
    public class AttackCalculator
    {
        Random random = new Random();

        public int CalculateDamage(Character atk, Character def)
        {
            int dice = LlençaDau();

            if (!TincMesForçaQueArmadura(atk, def, dice))
                return 0;

            if (dice == 1)
                return 0;

            if (dice == 20)
                return atk.damageDealt * 2;

            return atk.damageDealt;
        }

        private static bool TincMesForçaQueArmadura(Character atk, Character def, int dice)
        {
            return atk.Force + dice > def.armorClass;
        }

        protected virtual int LlençaDau()
        {
            return random.Next(1, 20);
        }
    }
}
