using Ficha10;
using Ficha10.Models;

namespace Ficha7Saturday
{
    public class Employees : IEmployees
    {
        private List<Employee> employeesList;

        public Employees()
        {
            employeesList = JsonLoader.DeserializeEmployees();
        }

        public List<Employee> EmployeesList { get { return employeesList; } set { employeesList = value; } }
        
    }
}
