using Q3.DataModel;

namespace Q3.Repository;

public interface IDepartmentService:ICourseService
{
    int DepartmentId { get; set; }
    decimal Budget { get; set; }
    
    void AllInfo();
}