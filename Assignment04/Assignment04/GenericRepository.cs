namespace Assignment04;

public class GenericRepository<T>:IRepository<T> where T:Entity
{
    private List<T> _list = new List<T>();

    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }
        _list.Add(item);
    }

    public void Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }
        _list.Remove(item);
    }

    public void Save()
    {
        Console.WriteLine("Saved!");
    }

    public IEnumerable<T> GetAll()
    {
        return _list;
    }

    public T GetById(int id)
    {
        return _list.FirstOrDefault(x => x.Id == id);
    }
}