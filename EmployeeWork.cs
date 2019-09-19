using System;

namespace DelegatesAndEventsClean
{
    public class EmployeeWork
    {
        // Declare event
        public EventHandler<EmployeeInstance> MornitorEmployee;

        // implement event
        protected virtual void OnMornitorEmployee(Employee employee)
        {
            if(MornitorEmployee != null)
            {
                MornitorEmployee(this, new EmployeeInstance() {Employee = employee });
            }
        }

        // Events to mornitor 1
        public void ReporttoWork(Employee employee)
        {
            Console.WriteLine("Reporting to work ...");
            OnMornitorEmployee(employee);
        }

        public void FinishAssignment(Employee employee)
        {
            Console.WriteLine("Assignment finished ...");
            OnMornitorEmployee(employee);
        }

        public void WorkedHard(Employee employee)
        {
            Console.WriteLine("Worked hard ...");
            OnMornitorEmployee(employee);
        }


    }
}
