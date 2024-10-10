

using Q3.DataModel;

public class Program
{
    public static void Main()
    {
        Person person1 = new Person();
        person1.Name = "John";
        person1.Age = 20;
        person1.Salary = 100;
        List<string> addresses = new List<string>();
        addresses.Add("123 Main Street");
        addresses.Add("456 Second Street");
        addresses.Add("789 Third Street");
        person1.Addresses = addresses;
        person1.AllInfo();
        
        
        Console.WriteLine("===========================================");
        Department department1 = new Department();
        department1.CourseList.Add(1);
        department1.CourseList.Add(2);
        department1.CourseList.Add(3);
        department1.Budget = 10000m;
        department1.AllInfo();
        
        Console.WriteLine("===========================================");
        Student student1 = new Student();
        student1.Name = "Amy";
        student1.Age = 20;
        student1.Salary = 100;
        student1.Addresses = addresses;
        student1.Grade = 'A';
        student1.GPA = 3.8;
        student1.AllInfo();
        
        





    }
}