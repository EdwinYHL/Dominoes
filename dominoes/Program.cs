class Program
{
    public readonly struct Domino
{
    private readonly int num;
    private readonly int den;

    public Domino(int numerator, int denominator)
    {

        num = numerator;
        den = denominator;
    }
    
        public static Domino operator +(Domino a, Domino b)
        => new Domino(a.num+b.den+b.num+b.num);
       
    public override string ToString() => $"{num} / {den}";
 }


    private static void Main(string[] args)
    {
        var d1 = new Domino(0, 1);
        var d2 = new Domino(2, 3);
         Console.WriteLine(d1 + d2);  
    }
}