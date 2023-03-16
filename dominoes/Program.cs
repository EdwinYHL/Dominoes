class Domino
{

    private int num;
    private int den;
    public Domino(int num, int den)
    {
        this.num = num;
        this.den = den;
    }  
    public static Domino operator + (Domino a, Domino b)
    {
        int num= a.num+a.den;
        int den=b.num + b.den;
        return new Domino(num,den);
    }
    public void imprime()
    {
        Console.WriteLine(num+den);
    }
 }
 internal class Program
 {
    private static void Main(string[] args)
    {
        Domino a = new Domino(0, 1);
        Domino b = new Domino(2, 3);
        Domino total = a+b;
        total.imprime();
    }
 }