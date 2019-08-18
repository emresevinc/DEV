namespace NetCoreFirstApp.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeByRecordId(long recordId);
        long CreateEmployee(Employee employee);
        void ModifyEmployee(Employee employee);
        void DeleteEmployeeByRecordId(long recordId);
    }
}
