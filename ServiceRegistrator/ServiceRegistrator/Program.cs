using Department.Entity;
using Employee.Entity;
using System;

namespace ServiceRegistrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Configurator.Congigure();
            Employee.Entity.Employee employee = ServiceRegistry.GetCurrent().GetService<IEmployeeService>().GetEmployeeById(1);
            ServiceRegistry.GetCurrent().GetService<IEmployeeService>().WriteEmployeeInfoToConsole(employee);
            Department.Entity.Department department = ServiceRegistry.GetCurrent().GetService<IDepartmentService>().GetDepartmentById(1);
            ServiceRegistry.GetCurrent().GetService<IDepartmentService>().WriteDepartmentInfoToConsole(department);
            Console.ReadKey();
        }
    }
}
