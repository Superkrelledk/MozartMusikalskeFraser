namespace MozartMusikalskeFraser;

public static class Dice
{
    // Slår én seks-sidet terning (1-6)
    public static int Roll6()
    {
        return Random.Shared.Next(1, 7);
    }

    // Generisk terning: 1..sides (default 6)
    public static int Roll(int sides = 6)
    {
        if (sides < 1) sides = 1;
        return Random.Shared.Next(1, sides + 1);
    }

    // Slår to seks-sidede terninger og returnerer summen (2-12)
    public static int Roll2d6()
    {
        return Roll6() + Roll6();
    }
}
