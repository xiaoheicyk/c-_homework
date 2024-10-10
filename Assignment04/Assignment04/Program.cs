using Assignment04;

public class Program
{
    public static void Main()
    {
       // MyStack<int> s = new MyStack<int>();
       // s.Push(1);
       // s.Push(2);
       // s.Push(3);
       // s.Push(4);
       // Console.WriteLine(s.Count());
       // Console.WriteLine(s.Pop());
       // Console.WriteLine(s.Pop());
       // Console.WriteLine(s.Count());
       
       Console.WriteLine("=========================================");
       
       MyList<int> list = new MyList<int>();
       list.Add(1);
       list.clear();
       list.Add(2);
       list.Add(3);
       list.InsertAt(2,4);
       Console.WriteLine(list.Contains(4));
       Console.WriteLine("=========================================");


    }

   
}