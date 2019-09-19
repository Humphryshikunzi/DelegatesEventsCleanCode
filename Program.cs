using System;

namespace DelegatesAndEventsClean
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeWork = new EmployeeWork();
            var employeeActivity = new EmployeeActivity();
            var employee = new Employee()
            {
                FirstName = "Humphry",
                LastName = "Shikunzi",
                Id = 1,
                PlaceofWork = "Main Branch, Nairobi",
                DateofBirth = Convert.ToDateTime("02/19/1997"),
                Salary = 45000m,
                YearsofExperience = 1
            };

            employeeWork.MornitorEmployee += employeeActivity.ReportReportingTime;
            employeeWork.MornitorEmployee += employeeActivity.ReportOnAssignMent;
            employeeWork.MornitorEmployee += employeeActivity.ReportMostHardWorkingEmployee;

            employeeWork.ReporttoWork(employee);
            Console.WriteLine();
            employeeWork.FinishAssignment(employee);
            Console.WriteLine();
            employeeWork.WorkedHard(employee);

        }
    }
}
