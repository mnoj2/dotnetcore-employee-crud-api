using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase {

        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context) {
            this._context = context;
        }

        [HttpGet]
        public IActionResult GetAllEmployees() {

            var allEmployees = _context.Employees.ToList();

            return Ok(allEmployees);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployee(Guid id) {

            var Employee = _context.Employees.Find(id);

            if(Employee is null) {
                return NotFound();
            }

            return Ok(Employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto) {

            var Employee = new Employee() {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary
            };

            _context.Employees.Add(Employee);
            _context.SaveChanges();

            return Ok(Employee);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto) {

            var Employee = _context.Employees.Find(id);

            if(Employee is null) {
                return NotFound();
            }

            Employee.Name = updateEmployeeDto.Name;
            Employee.Email = updateEmployeeDto.Email;
            Employee.Phone = updateEmployeeDto.Phone;
            Employee.Salary = updateEmployeeDto.Salary;

            _context.SaveChanges();

            return Ok(Employee);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id) {
            
            var Employee = _context.Employees.Find(id);

            if(Employee is null) {
                return NotFound();
            }

            _context.Employees.Remove(Employee);
            _context.SaveChanges();

            return Ok();
        }

    }
}
