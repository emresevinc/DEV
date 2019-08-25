namespace Employee.Entity
{
    public interface IEmployeeService
    {
        Employee GetEmployeeById(long id);
        void WriteEmployeeInfoToConsole(Employee employee);
    }
}
