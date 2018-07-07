using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension Method Syntax
            //var EmployeesByDepartment = Department.GetAllDepartments()
            //                                      .GroupJoin(Employee.GetAllEmployees(),
            //                                      d => d.ID,
            //                                      e => e.DepartmentID,
            //                                      (department, employees) => new
            //                                      {
            //                                          Department = department,
            //                                          Employees = employees

            var EmployeesByDepartment = from d in Department.GetAllDepartments()
                                        join e in Employee.GetAllEmployees()
                                        on d.ID equals e.DepartmentID into eGroup
                                        select new
                                        {
                                            Department = d,
                                            Employees = eGroup
                                        };
            foreach (var department in EmployeesByDepartment)
            {
                Console.WriteLine(department.Department.Name  + " " + department.Department.ID);
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine(" " + employee.Name + " " + employee.ID + " " + employee.DepartmentID);
                }
                Console.WriteLine();
            }
        }
    }
}
