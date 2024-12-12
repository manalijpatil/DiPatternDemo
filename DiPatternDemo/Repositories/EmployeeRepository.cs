using DiPatternDemo.Data;
using DiPatternDemo.Models;

namespace DiPatternDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            int result = 0;
            db.Employees.Add(employee);
            result = db.SaveChanges();
            return result;

        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
            var emp = db.Employees?.Where(x => x.EmpId == id).SingleOrDefault();
            if(emp != null)
            {
                db.Employees?.Remove(emp);
                result = db.SaveChanges();
            }
            return result;
        }

        public Employee GetEmployee(int id)
        {
            return db.Employees?.Where(x => x.EmpId == id).SingleOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }

        public int UpdateEmployee(Employee employee)
        {
            int result = 0;
            var emp = db.Employees?.Where(x => x.EmpId == employee.EmpId).SingleOrDefault();
            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Email = employee.Email;
                emp.Salary = employee.Salary;
                result = db.SaveChanges();
            }
            return result;
        }
        
    }
}
