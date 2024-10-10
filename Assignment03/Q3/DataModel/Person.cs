namespace Q3.DataModel;
using Repository;
public class Person:IPersonService
{
    private string _Name;
    private int _Age;
    private decimal _Salary;
    private List<string> _Addresses;
    
    public Person()
    {
        
    }

    public Person(string name, int age, decimal salary)
    {
        _Name = name;
        _Age = age;
        _Salary = salary;
    }

    public int Age
    {
        get{return _Age;}
        set{_Age=value;}
    }

    public string Name
    {
        get{return _Name;}
        set{_Name=value;}
    }

    public decimal Salary
    {
        get{return _Salary;}
        set{_Salary=value;}
    }

    public List<string> Addresses
    {
        get{return _Addresses;}
        set{_Addresses=value;}
    }

    public void AllInfo()
    {
        Console.WriteLine($"Name: {_Name}, Age: {_Age}, Salary: {_Salary}");
        Console.WriteLine($"Addresses: {string.Join(", ",_Addresses)}");
    }
    
}