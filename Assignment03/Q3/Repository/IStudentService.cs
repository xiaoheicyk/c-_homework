namespace Q3.Repository;

public interface IStudentService:ICourseService
{
    double GPA { get; set; }
    char Grade { get; set; }

    void AllInfo();
}