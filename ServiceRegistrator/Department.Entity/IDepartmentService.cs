namespace Department.Entity
{
    public interface IDepartmentService
    {
        Department GetDepartmentById(long id);
        void WriteDepartmentInfoToConsole(Department department);
    }
}
