class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(1);
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);


        Console.WriteLine($"Fraction 1: {fraction1.GetFraction()}\n Decimal 1:{fraction1.GetDecimal()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFraction()}\n Decimal 2:{fraction2.GetDecimal()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFraction()}\n Decimal 3:{fraction3.GetDecimal()}");
        Console.WriteLine($"Fraction 4: {fraction4.GetFraction()}\n Decimal 4:{fraction4.GetDecimal()}");



    }
}