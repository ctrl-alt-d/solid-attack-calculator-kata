namespace Game
{

    public class AttackCalculator
    {

        public AttackCalculator(IDice dice)
        {
            this.dau = dice;
        }

        private readonly IDice dau;

        public int CalculateDamage(Character atk, Character def)
        {
            int dice = dau.LlençaDau();

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


    }
}
