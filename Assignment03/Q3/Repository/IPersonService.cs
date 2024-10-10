namespace Q3.Repository;

public interface IPersonService
{
    int Age { get; set; }
    string Name{get;set;}
    decimal Salary{get;set;}
    
    List<string> Addresses{get;set;}

    void AllInfo();

}