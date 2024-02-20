using DotNetCoreWebAPI.Model;

namespace DotNetCoreWebAPI.Interface
{

    public class EmployeeImplementation : IEmployee
    {
        public static List<EmployeeModel> EmployeeEntity;

       public EmployeeImplementation()
        {
            EmployeeEntity = new List<EmployeeModel>();
            EmployeeEntity.Add(
                new EmployeeModel() { ID = 1001, Name = "Vamshi", Email = "vamshi@gmail.com"});
            EmployeeEntity.Add(
                new EmployeeModel() { ID = 1002, Name = "Krishna", Email = "Krishna@gmail.com"});
            EmployeeEntity.Add(
                new EmployeeModel() { ID = 1003, Name = "Bandi", Email = "Bandi@gmail.com"});
        }




        public List<EmployeeModel> DeleteByID(int ID)
        {
            var employee = EmployeeEntity.Where(s => s.ID == ID).FirstOrDefault();
            EmployeeEntity.Remove(employee);
            return EmployeeEntity;
        }

        public List<EmployeeModel> GetAll()
        {
            return EmployeeEntity;
        }

        public EmployeeModel GetEmployeeByID(int ID)
        {
            return EmployeeEntity.Where(s => s.ID == ID).FirstOrDefault();
        }

        public List<EmployeeModel> SaveEmployee(EmployeeModel employeeModel)
        {

            EmployeeEntity.Add(employeeModel);
            return EmployeeEntity;
        }

        public List<EmployeeModel> UpdateEmployee (EmployeeModel employeeModel)
        {

            var employeeE = EmployeeEntity.Where(s => s.ID == employeeModel.ID).FirstOrDefault();
            employeeE.Name=employeeModel.Name;
            employeeE.Email=employeeModel.Email;
            //Using Entity Frame work We can update
            return EmployeeEntity;
        }

        public List<EmployeeModel> PatchEmployee(EmployeeModel employeeModel)
        {

            var employeeEt = EmployeeEntity.Where(s => s.ID == employeeModel.ID).FirstOrDefault();
            //employeeEt.Name = employeeModel.Name;
            employeeEt.Email = employeeModel.Email;
            //Using Entity Frame work We can update
            return EmployeeEntity;
        }
    }
}
