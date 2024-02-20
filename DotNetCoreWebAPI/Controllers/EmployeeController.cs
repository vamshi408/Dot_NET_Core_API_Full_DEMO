using DotNetCoreWebAPI.Interface;
using DotNetCoreWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployee _iemployee;
        public EmployeeController(IEmployee iemployee) {
            _iemployee = iemployee;
        }

        [HttpGet("GetAllEmployees")]
        public List<EmployeeModel> GetAllEmployees()
        {
            return _iemployee.GetAll();
        }


        [HttpGet("GetAllEmployeeByID")]
        public EmployeeModel GetAllEmployeeByID(int ID)
        {
            return _iemployee.GetEmployeeByID(ID);
        }

        [HttpPost("SaveEmployee")]
        public List<EmployeeModel> SaveEmployee(EmployeeModel employee)
        {
            return _iemployee.SaveEmployee(employee);
        }


        [HttpPut("UpdateEmployee")]
        public List<EmployeeModel> UpdateEmployee(EmployeeModel employee)
        {
            return _iemployee.UpdateEmployee(employee);
        }

        [HttpPatch("PatchEmployee")]
        public List<EmployeeModel> PatchEmployee(EmployeeModel employee)
        {
            return _iemployee.PatchEmployee(employee);
        }

        [HttpGet("DeleteEmployeeByID")]
        public List<EmployeeModel> DeleteEmployeeByID(int ID)
        {
            return _iemployee.DeleteByID(ID);
        }
    }
}
