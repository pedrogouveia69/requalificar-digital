using Ficha10.Models;
using Ficha7Saturday;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Text.Json;

namespace Ficha10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployees employees;

        public EmployeesController(IEmployees employees)
        {
            this.employees = employees;
        }

        // Listar todos os funcionários existentes no ficheiro e devolver os mesmos na resposta
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees.EmployeesList;
        }

        // Selecionar apenas um funcionário pelo seu ID e devolver esse mesmo funcionário na resposta
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var e = employees.EmployeesList.Find(e => e.UserId == id);
            return e != null ? Ok(e) : NotFound();
        }

        // Listar todos os funcionários por região
        [HttpGet("{region}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string region)
        {
            var e = employees.EmployeesList.FindAll(e => e.Region == region.ToUpper());
            return e.Count > 0 ? Ok(e) : NotFound();
        }

        // Efetuar download da lista atual de funcionários como um ficheiro .json
        [HttpGet("/Employees/Download")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetDownload()
        {
            System.IO.File.WriteAllText("employees.json", JsonSerializer.Serialize(employees));
            return File(System.IO.File.ReadAllBytes("employees.json"), "application/json", "test.json");
        }

        // Adicionar um novo funcionário, o ID deve ser gerado automaticamente tendo em conta o número de funcionários existentes.
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Employee e)
        {
            if (employees.EmployeesList.Count == 0)
            {
                e.UserId = 1;
            }
            else
            {
                e.UserId = employees.EmployeesList.Last().UserId + 1;
            }

            employees.EmployeesList.Add(e);
            return Created("employees/" + e.UserId, e);
        }

        // Apagar um funcionário pelo seu ID
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(int id, [FromBody] Employee putEmp)
        {
            Employee e = employees.EmployeesList.Find(e => e.UserId == id);

            if (e != null)
            {
                e.JobTitle = putEmp.JobTitle;
                e.FirstName = putEmp.FirstName;
                e.LastName = putEmp.LastName;
                e.EmployeeCode = putEmp.EmployeeCode;
                e.Region = putEmp.Region;
                e.PhoneNumber = putEmp.PhoneNumber;
                e.EmailAddress = putEmp.EmailAddress;

                return Ok(e);
            }
            else
            {
                return NotFound();
            }
        }

        // Alterar os detalhes de um determinado funcionário pelo seu ID
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            int r = employees.EmployeesList.RemoveAll(e => e.UserId == id);
            return r > 0 ? Ok(id) : NotFound();
        }

    }
}