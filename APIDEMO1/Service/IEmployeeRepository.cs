using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using APIDEMO1.Models;

namespace APIDEMO1.Service
{
    public interface IEmployeeRepository
    {
        Task<ActionResult<Employee>?> GetEmployee(int Id);
        Task<ActionResult<IEnumerable<Employee>>> GetAllEmployee();
        Task<ActionResult<Employee>> Add(Employee employee);
        Task<Employee> Update(int id, Employee employeeChanges);
        Task<Employee> Delete(int Id);

    }
}
