using AspCoreWebAPICRUD.DataAcessLayer;
using AspCoreWebAPICRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsAPIController : ControllerBase
    {
        private readonly AppDbContext context;
        //ctrl+ .
        public StudentsAPIController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet("students")]
        public async Task<IActionResult> GetStudentData()
        {
            var data = await context.StuDetails.ToListAsync();
            return Ok(data);
        }
        [HttpGet("employees")]
        public async Task<IActionResult> GetEmployeeData()
        {
            var data = await context.EmpDetails.ToListAsync();
            return Ok(data);
        }
        [HttpPost("students")]
        public async Task<IActionResult> InsertStudents(Student student)
        {
            //await context.StuDetails.AddAsync(Id);
            //await context.SaveChangesAsync();
            //return Ok();
            // Ensure "Id" is not manually set
            student.Id = 0; // or remove any explicit assignment to "Id"
            context.StuDetails.Add(student);
            await context.SaveChangesAsync();
            return Ok(student);

        }
        [HttpPost("employees")]
        public async Task<IActionResult> InsertEmployees(Employee employee)
        {
            // Ensure "Id" is not manually set
            employee.Id = 0; // or remove any explicit assignment to "Id"
            context.EmpDetails.Add(employee);
            await context.SaveChangesAsync();
            return Ok(employee);
        }
        [HttpPut("students")]
        public async Task<IActionResult> UpdateStudents(Student student)
        {
           
            context.StuDetails.Update(student);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("employees")]
        public async Task<IActionResult> UpdateEmployees(Employee employee)
        {
            
            context.EmpDetails.Update(employee);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("students")]
        public async Task<IActionResult> DeleteStudents(Student student)
        {

            context.StuDetails.Remove(student);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("employees")]
        public async Task<IActionResult> DeleteEmployees(Employee employee)
        {

            context.EmpDetails.Remove(employee);
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
