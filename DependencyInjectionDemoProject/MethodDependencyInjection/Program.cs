using System;
using System.Collections.Generic;

namespace MethodDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object of EmployeeBL class
            EmployeeBL employeeBL = new EmployeeBL();
            //Call to GetAllEmployees method with proper object.            
            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
            Console.ReadKey();
        }
    }
}
