namespace Assignment04;

public class MyStack<T>
{

    private List<T> stack;
    
    public MyStack()
    {
        stack = new List<T>();
    }

    public int Count()
    {
        return stack.Count;
    }

    public T Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T top = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return top;
    }

    public void Push(T item)
    {
        stack.Add(item);
    }
}