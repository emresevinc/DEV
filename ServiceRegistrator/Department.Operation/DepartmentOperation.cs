using Department.Entity;
using System;
using System.Collections.Generic;

namespace Department.Operation
{
    public class DepartmentOperation : IDepartmentService
    {
        private Dictionary<long, Entity.Department> mockDepartmentList = new Dictionary<long, Entity.Department>() {
            {1, new Entity.Department(){ Id = 1, Name = "Card Payment Systems Department",SectionId = 10 } },
            {2, new Entity.Department(){ Id = 2, Name = "Infrastructure Department",SectionId = 11 } },
            {3, new Entity.Department(){ Id = 3, Name = "Human Resources Department",SectionId = 12 } },
        };

        public Entity.Department GetDepartmentById(long id)
        {
            if(!mockDepartmentList.TryGetValue(id, out Entity.Department department))
            {
                throw new Exception("Department not found");
            }
            return department;
        }
        
        public void WriteDepartmentInfoToConsole(Entity.Department department)
        {
            Console.WriteLine(string.Format(" DepartmentId: {0} \n DepartmentName: {1} \n SectionId: {2}", department.Id, department.Name, department.SectionId));
        }
    }
}
