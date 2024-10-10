using Q3.Repository;

namespace Q3.DataModel;

public class Department:IDepartmentService
{

    public Department()
    {
        CourseList = new List<int>();
    }
    public int DepartmentId { get; set; }
    public List<int> CourseList { get; set; }
    public decimal Budget { get; set; }

    public void AddCourse(int CourseId)
    {
        CourseList.Add(CourseId);
    }

    public void DeleteCourse(int CourseId)
    {
        CourseList.Remove(CourseId);
    }

    public void AllInfo()
    {
        Console.WriteLine($"Department {DepartmentId} with budget {Budget} has these courses:");
        Console.WriteLine($"{string.Join(", ",CourseList)}");
    }
}