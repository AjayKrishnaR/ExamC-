using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementLogic
{
    public class Employee : EmployeeDetails
    {
        public string EmployeeCode;
        public string EmployeeName;
        public double EmployeeExperience;
        public int EmployeeAge;


        //To Add New Employees
        public Employee AddEmployee(string _EmployeeCode, string _EmployeeName, double _EmployeeExperience, int _EmployeeAge)
        {
            var NewEmployee = new Employee
            {
                EmployeeCode = _EmployeeCode,
                EmployeeName = _EmployeeName,
                EmployeeExperience = _EmployeeExperience,
                EmployeeAge = _EmployeeAge,
            };

            return NewEmployee;

        }

        public void EmployeeDetailsDisplay(string SearchName, IList<Employee> employee)
        {
            int flag = 1;
            foreach (Employee e in employee)
            {
                if (SearchName == e.EmployeeName)
                {
                    flag = 0;
                    Console.WriteLine("Employee Details Found");
                    Console.WriteLine("Employee Code :" + e.EmployeeCode);
                    Console.WriteLine("Employee Name :" + e.EmployeeName);
                    Console.WriteLine("Employee Age :" + e.EmployeeAge);
                    Console.WriteLine("Employee Experience :" + e.EmployeeExperience);
                }

            }
            if (flag != 0)
            {
                Console.WriteLine("Sorry Employee Details Not Found");
            }

        }

        public Employee EmployeeDetailsDisplay(string SearchName)
        {
            throw new NotImplementedException();
        }
    }
}
