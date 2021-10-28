using EmployeeService.Models;
namespace EmployeeService.Repository
{
    public interface IEmployeeList
    {
        int CreateEmployee(Employee obj);

        int UpdateEmployee(Employee obj);

        int DeleteEmployee(Employee obj);
        int SearchEmployee(Employee obj);
        int FetchEmployee(Employee obj);

    }
}