namespace Q3.Repository;

public interface IInstructorService:IPersonService
{
    bool Head { get; set; }
    decimal Bonus { get; set; }
    
    void CalculateSalary(decimal bonus);
    int WorkYear { get; set; }

    void AllInfo();
}