namespace Q3.Repository;

public interface ICourseService
{
    List<int> CourseList { get; set; }
    void AddCourse(int CourseId);
    void DeleteCourse(int CourseId);
}