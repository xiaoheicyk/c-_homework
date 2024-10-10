namespace Q4;

public class Ball
{
    private int thrown;
    public Ball()
    {
        
    }

    public Ball(Color color, int size)
    {
        Color = color;
        Size = size;
    }
    
    public int Size { get; set; }
    public Color Color { get; set; }

    public void Pop()
    {
        Size = 0;
    }
    
    public void Throw()
    {
        if (Size != 0)
        {
            thrown++;
        }
        else
        {
            Console.WriteLine("Size of ball is 0. Can not be thrown.");
        }
    }
    public void ThrownTimes()
    {
        Console.WriteLine($"Ball has been thrown {thrown} times.");
    }
}