namespace Assignment04;

public class MyList<T>
{
    private T[] list;
    private int count;

    public MyList()
    {
        list = new T[4];
        count = 0;
    }
    public int Count => count;

    public void Add(T item)
    {
        if (count == list.Length)
        {
            Array.Resize(ref list, list.Length * 2);
        }
        list[count] = item;
        count += 1;
        
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException();
        }
        
        T removed = list[index];
        
        for (int i = index; i < count - 1; i++)
        {
            list[i] = list[i + 1];
        }

        list[count - 1] = default(T); // Clear the last item
        count--;
        return removed;
    }

    public bool Contains(T item)
    {
        foreach (T element in list)
        {
            if (element.Equals(item))
            {
                return true;
            }
        }

        return false;

    }

    public void clear()
    {
        list = new T[4];
        count = 0;
    }

    public void InsertAt(int index, T item)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (count == list.Length)
        {
            Array.Resize(ref list, list.Length * 2);
        }
        for (int i = count; i > index; i--)
        {
            list[i] = list[i - 1];
        }
        list[index] = item;
        count++;
    }
    
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException();
        }

        for (int i = index; i < count - 1; i++)
        {
            list[i] = list[i + 1];
        }

        list[count - 1] = default(T); 
        count--;
    }

    public T Find(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException();
        }

        return list[index];
    }


}