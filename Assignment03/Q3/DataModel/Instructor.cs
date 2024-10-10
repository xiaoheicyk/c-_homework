using Q3.Repository;

namespace Q3.DataModel;

public abstract class Instructor:Person,IInstructorService
{
    public bool Head{set;get;}
    public decimal Bonus{set;get;}
    public int WorkYear { get; set; }
    public void CalculateSalary(decimal bonus)
    {
        Salary = Salary+bonus;
    }
    

    public void AllInfo()
    {
        Console.WriteLine($"The instructor {Name} has bonus {Bonus} and salary {Salary}.");
    }
    
    
}