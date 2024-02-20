using DotNetCoreWebAPI.Model;

namespace DotNetCoreWebAPI.Interface
{
    public interface IEmployee
    {
        public List<EmployeeModel> GetAll();
        public EmployeeModel GetEmployeeByID(int ID);
        public List<EmployeeModel> DeleteByID(int ID);
        public List<EmployeeModel> SaveEmployee(EmployeeModel employeeModel);
        public List<EmployeeModel> UpdateEmployee(EmployeeModel employeeModel);

        public List<EmployeeModel> PatchEmployee(EmployeeModel employeeModel);
    }
}
