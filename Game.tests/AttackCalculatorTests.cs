using Game.tests.StubClasses;

namespace Game.tests;

public class AttackCalculatorTests 
{
    const int NoIMPORTA = 0;
    [Fact]
    public void SiLaMevaArmaduraEsProuFortaElDanyEs0()
    {
        // arrange
        var (calc, atk, def) = ArrageObjects(5);

        // act
        var resultat = calc.CalculateDamage(atk, def);

        // assert
        Assert.Equal(0, resultat);
    }

    private static (AttackCalculator, Character, Character) ArrageObjects(int dau)
    {
        var dauTrucat = new DauTrucat(dau);
        var calc = new AttackCalculator(dauTrucat);

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


        return (calc, atk, def);
    }

    [Fact]
    public void TincProuForçaPeroElDauSurtUn1ElDanyEs0()
    {          
        // arrange
        IDice dauTrucat = new DauTrucat(1);
        var calc = new AttackCalculator(dauTrucat);
        var atk = new Character(
            armorClass: NoIMPORTA,
            weaponDamage: NoIMPORTA,
            race: "Atacant",
            force: 5);
        var def = new Character(
            armorClass: 2,
            weaponDamage: NoIMPORTA,
            race: "Defensor",
            force: NoIMPORTA);

        // act
        var resultat = calc.CalculateDamage(atk, def);

        // assert
        Assert.Equal(0, resultat);
    }


    [Fact]
    public void TincProuForçaIelDauSurt20ElDanyEsElDoble()
    {          
        // arrange
        IDice dauTrucat = new DauTrucat(20);
        var calc = new AttackCalculator(dauTrucat);
        var atk = new Character(
            armorClass: NoIMPORTA,
            weaponDamage: 100,
            race: "Atacant",
            force: 5);
        var def = new Character(
            armorClass: 2,
            weaponDamage: NoIMPORTA,
            race: "Defensor",
            force: NoIMPORTA);

        // act
        var resultat = calc.CalculateDamage(atk, def);

        // assert
        Assert.Equal(200, resultat);
    }


    [Fact]
    public void TincProuForçaIelDauNoEs20ni1ElDanyEsSimple()
    {          
        // arrange
        IDice dauTrucat = new DauTrucat(15);
        var calc = new AttackCalculator(dauTrucat);
        var atk = new Character(
            armorClass: NoIMPORTA,
            weaponDamage: 100,
            race: "Atacant",
            force: 5);
        var def = new Character(
            armorClass: 2,
            weaponDamage: NoIMPORTA,
            race: "Defensor",
            force: NoIMPORTA);

        // act
        var resultat = calc.CalculateDamage(atk, def);

        // assert
        Assert.Equal(100, resultat);
    }


}
