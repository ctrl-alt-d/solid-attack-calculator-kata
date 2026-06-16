namespace Game.tests;

public class AttackCalculatorTests 
{
    const int NoIMPORTA = 0;
    [Fact]
    public void SiLaMevaArmaduraEsProuFortaElDanyEs0()
    {          
        // arrange
        var calc = new AttackCalculatorTestable(5);
        var atk = new Character(
            armorClass: NoIMPORTA,
            weaponDamage: NoIMPORTA,
            race: "Atacant",
            force: 5);
        var def = new Character(
            armorClass: 100,
            weaponDamage: NoIMPORTA,
            race: "Defensor",
            force: NoIMPORTA);

        // act
        var resultat = calc.CalculateDamage(atk, def);

        // assert
        Assert.Equal(0, resultat);
    }




}
