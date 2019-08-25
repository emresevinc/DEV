using Employee.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Operation
{
    public class EmployeeOperation : IEmployeeService
    {
        private Dictionary<long, Entity.Employee> mockEmployeeList = new Dictionary<long, Entity.Employee>() {
            {1, new Entity.Employee{ Id = 1, Name = "Emre", DepartmentId = 1} },
            {2, new Entity.Employee{ Id = 2, Name = "John", DepartmentId = 2} },
            {3, new Entity.Employee{ Id = 3, Name = "Michael", DepartmentId = 3} }
        };

        public Entity.Employee GetEmployeeById(long id)
        {
            if (!mockEmployeeList.TryGetValue(id, out Entity.Employee employee))
            {
                throw new Exception("Department not found");
            }
            return employee;
        }

        public void WriteEmployeeInfoToConsole(Entity.Employee employee)
        {
            Console.WriteLine(string.Format(" EmployeeId: {0} \n EmployeeName: {1} \n DepartmentId: {2}", employee.Id, employee.Name, employee.DepartmentId));
        }
    }
}
