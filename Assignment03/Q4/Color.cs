namespace Q4;

public class Color
{

    public Color()
    {
        
    }

    public Color(byte r, byte g, byte b, byte alpha = 255)
    {
        Red = r;
        Green = g;
        Blue = b;
        Alpha = alpha;
    }
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }
    public byte Alpha { get; set; }

    public int GrayScale()
    {
        Console.WriteLine($"The gray scale is {(Red + Green + Blue) / 3}");
        return (Red + Green + Blue) / 3;
    }
}