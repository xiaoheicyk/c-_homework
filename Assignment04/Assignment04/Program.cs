using Assignment04;

public class Program
{
    public static void Main()
    {
       MyStack<int> s = new MyStack<int>();
       s.Push(1);
       s.Push(2);
       s.Push(3);
       s.Push(4);
       Console.WriteLine(s.Count());
       Console.WriteLine(s.Pop());
       Console.WriteLine(s.Pop());
       Console.WriteLine(s.Count());
    }

   
}