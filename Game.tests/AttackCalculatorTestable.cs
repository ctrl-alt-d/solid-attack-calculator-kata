namespace Game.tests;

public class AttackCalculatorTestable(int numero): AttackCalculator
{
    protected override int LlençaDau()
    {
        return numero;
    }
}
