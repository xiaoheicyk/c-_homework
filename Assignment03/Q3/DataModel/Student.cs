using Q3.Repository;

namespace Q3.DataModel;

public class Student:Person,ICourseService,IStudentService{
    public Student()
    {
        CourseList = new List<int>();
    }
    public List<int> CourseList { get; set; }
    public char Grade { get; set; }
    public double GPA { get; set; }

    public void AddCourse(int courseId)
    {
        CourseList.Add(courseId);
    }

    public void DeleteCourse(int courseId)
    {
        CourseList.Remove(courseId);
    }

    public void AllInfo()
    {
        Console.WriteLine($"The student name is{Name}, grade is {Grade}, gpa is {GPA},Age is {Age}");
        Console.WriteLine($"Course list is {CourseList.Count}");
        Console.WriteLine($"Student list is {string.Join(',',Addresses)}");
    }

}