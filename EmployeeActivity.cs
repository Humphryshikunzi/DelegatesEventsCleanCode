using System;
using System.Threading;
namespace DelegatesAndEventsClean
{
    public class EmployeeActivity
    {
         public void ReportReportingTime(object source, EmployeeInstance e)
        {
            Console.WriteLine("Employee {0} reported on {1} ", e.Employee.FullName, DateTime.Now.ToShortDateString());
            Thread.Sleep(5000);
        }
        public void ReportOnAssignMent(object source, EmployeeInstance e)
        {
            Console.WriteLine("Employee {0} finshed the assignment at {1} ", e.Employee.LastName, DateTime.Now.ToShortTimeString());
            Thread.Sleep(6000);
        }
        public void ReportMostHardWorkingEmployee( object source, EmployeeInstance e)
        {
            Console.WriteLine("The most hardworking  works at "+ e.Employee.PlaceofWork);
        }
    }
}
