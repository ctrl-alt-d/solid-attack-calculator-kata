namespace Game.tests.StubClasses;

public class DauTrucat(int numero) : IDice
{
    public int LlençaDau()
    {
        return numero;
    }
}
