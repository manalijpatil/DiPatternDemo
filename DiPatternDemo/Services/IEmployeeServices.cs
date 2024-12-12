using DiPatternDemo.Models;

namespace DiPatternDemo.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(int id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}
