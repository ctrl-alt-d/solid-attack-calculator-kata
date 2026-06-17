using System;

namespace Game
{

    public class Dice : IDice
    {
        public Dice(int numeroCares)
        {
            this.numeroCares = numeroCares;
        }
        private int numeroCares;
        readonly Random random = new Random();
        public int LlençaDau()
        {
            return random.Next(1, numeroCares);
        }
    }
}
