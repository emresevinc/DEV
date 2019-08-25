using Department.Entity;
using Department.Operation;
using Employee.Entity;
using Employee.Operation;

namespace ServiceRegistrator
{
    public static class Configurator
    {
        public static void Congigure()
        {
            ServiceRegistry.GetCurrent().Register(typeof(IEmployeeService), new EmployeeOperation()); // ilk register ornegi
            ServiceRegistry.GetCurrent().Register<IDepartmentService, DepartmentOperation>(); // ikinci register ornegi
        }
    }
}
