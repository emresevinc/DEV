using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFirstApp.Models
{
    public class EmployeeOperation : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public EmployeeOperation(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        
        public long CreateEmployee(Employee employee)
        {
            appDbContext.Employees.Add(employee);
            appDbContext.SaveChanges();
            return employee.RecordId;
        }

        public void DeleteEmployeeByRecordId(long recordId)
        {
            Employee employee = GetEmployeeByRecordId(recordId);
            appDbContext.Employees.Remove(employee);
        }

        public Employee GetEmployeeByRecordId(long recordId)
        {
            var sqlParameter = new SqlParameter("@RecordId", recordId);
            string GET_EMPLOYEE_BY_RECORD_ID = $"SELECT * FROM dbo.Employees WITH (NOLOCK) WHERE RecordId = @RecordId";
            var sqlResult = appDbContext.Employees.FromSql(GET_EMPLOYEE_BY_RECORD_ID, sqlParameter).FirstOrDefault();
            if(sqlResult == null) {
                throw new Exception("Employee Not Found!");
            }
            return sqlResult;
        }

        public void ModifyEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
