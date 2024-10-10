using Q4;

public class Program
{
    public static void Main()
    {
        Color c = new Color(99,67,24);
        Console.WriteLine(c.Red);
        Console.WriteLine(c.GrayScale());
        Ball b = new Ball();
        b.Color = new Color(1,2,3);
        b.Size = 10;
        b.Throw();
        b.Throw();
        b.Throw();
        Console.WriteLine(b.Size);
        b.ThrownTimes();
        b.Pop();
        Console.WriteLine(b.Size);
        b.Throw();
        b.Color.GrayScale();

    }
}