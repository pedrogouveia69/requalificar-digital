using Ficha7;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

/*
var employee1 = new Employee()
{
    Id = 1,
    UserId = "pedro10",
    JobTitle = "student",
    FirstName = "pedro",
    LastName = "gouveia",
    EmployeeCode = "E10",
    Region = "PT",
    PhoneNumber = "987654321",
    EmailAddress = "pedro@mail.com"
};

var employee2 = new Employee()
{
    Id = 2,
    UserId = "pedro102",
    JobTitle = "student2",
    FirstName = "pedro2",
    LastName = "gouveia2",
    EmployeeCode = "E102",
    Region = "PT",
    PhoneNumber = "987654321_2",
    EmailAddress = "pedro@mail.com2"
};

var employee3 = new Employee()
{
    Id = 3,
    UserId = "pedro103",
    JobTitle = "student3",
    FirstName = "pedro3",
    LastName = "gouveia3",
    EmployeeCode = "E103",
    Region = "PT",
    PhoneNumber = "987654321_3",
    EmailAddress = "pedro@mail.com3"
};
*/

/*
var employees = new Employees();
employees.EmployeeList.Add(employee1);
employees.EmployeeList.Add(employee2);
employees.EmployeeList.Add(employee3);
SerializeEmployees(employees);
*/

var employees = DeserializeEmployees();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () => "Home Page");

app.MapGet("/employees", () =>
{
    if (employees.EmployeeList.Count > 0)
    {
        List<Employee> emps = new List<Employee>();
        foreach (var employee in employees.EmployeeList)
        {
            if (employee.Deleted == false)
            {
                emps.Add(employee);
            }
        }
        return emps.Count > 0 ? Results.Ok(emps) : Results.NotFound("Not Found");
    }
    return Results.NotFound("Not Found");
});

app.MapGet("/employees/{id}", (int id) =>
{
    Employee employee = employees.EmployeeList.Find(e => e.Id == id);
    return employee != null && employee.Deleted == false ? Results.Ok(employee) : Results.NotFound("Not Found");
});

app.MapGet("/employees/region/{region}", (string region) =>
{
    List<Employee> emps = new List<Employee>();
    foreach (Employee employee in employees.EmployeeList)
    {
        if (employee.Region == region.ToUpper() && employee.Deleted == false)
            emps.Add(employee);
    }
    return emps.Count > 0 ? Results.Ok(emps) : Results.NotFound("Not Found");
});

ActionResult TESTSAVE()
{
    var data = JsonSerializer.Serialize(employees); 
    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
    var output = new FileContentResult(bytes, "application/octet-stream");
    output.FileDownloadName = "download.txt";

    return output;
}

app.MapGet("/employees/download", () =>
{
    TESTSAVE();

});

app.MapPost("/employees", (Employee employee) =>
{
    int id = employees.EmployeeList.Count() + 1;
    employee.Id = id;
    employees.EmployeeList.Add(employee);
    SerializeEmployees(employees);
    return Results.Ok(employee);
});

app.MapPut("/employees/{id}", (int id, Employee putEmployee) =>
{
    Employee employee = employees.EmployeeList.Find(e => e.Id == id);

    if (employee != null && employee.Deleted == false)
    {
        employees.EmployeeList.Remove(employee);
        employees.EmployeeList.Add(putEmployee);
        SerializeEmployees(employees);
        return Results.Ok(putEmployee);
    }

    return Results.NotFound("Not Found");
});

app.MapDelete("/employees/{id}", (int id) =>
{
    Employee employee = employees.EmployeeList.Find(e => e.Id == id);

    if (employee != null)
    {
        employee.Deleted = true;
        SerializeEmployees(employees);
        return Results.Ok(employee.Id);
    }

    return Results.NotFound("Not Found");
});

app.Run();

Employee DeserializeEmployee()
{
    var jsonData = File.ReadAllText("employee.json");
    Employee employee = JsonSerializer.Deserialize<Employee>(jsonData);

    return employee;
}

Employees DeserializeEmployees()
{
    Employees employees = new Employees();
    var jsonData = File.ReadAllText("employees.json");
    if(jsonData.Length != 0)
        employees = JsonSerializer.Deserialize<Employees>(jsonData);

    return employees;
}

void SerializeEmployee(Employee employee)
{
    string jsonString = JsonSerializer.Serialize(employee);
    File.WriteAllText("employee.json", jsonString);
}

void SerializeEmployees(Employees employees)
{
    string jsonString = JsonSerializer.Serialize(employees);
    File.WriteAllText("employees.json", jsonString);
}


