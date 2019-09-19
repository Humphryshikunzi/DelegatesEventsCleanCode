using System;

public class Employee
{
    public int  Id { get; set; }
    public string  FirstName { get; set; }
    public string LastName { get; set; }
    public  string PlaceofWork { get; set; }
    public decimal  Salary { get; set; }
    public int  YearsofExperience { get; set; }
    public DateTime DateofBirth { get; set; }
    public string  FullName
    {
        get
        {
            return FirstName + " " + LastName; 
        }
     }

}
