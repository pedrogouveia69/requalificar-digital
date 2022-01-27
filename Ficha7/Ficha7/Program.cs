using Ficha7;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

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
    Region = "PT2",
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
    Region = "PT3",
    PhoneNumber = "987654321_3",
    EmailAddress = "pedro@mail.com3"
};

var employees = new Employees();
employees.EmployeeList.Add(employee1);
employees.EmployeeList.Add(employee2);
employees.EmployeeList.Add(employee3);

SerializeEmployees(employees);

employees = DeserializeEmployees();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", () => "Home Page");

app.MapGet("/employees", () => employees != null ? Results.Ok(employees) : Results.NotFound("Not Found"));

app.MapGet("/employees/{id}", (int id) =>
{
    Employee employee = employees.EmployeeList.Find(e => e.Id == id);
    return employee != null ? Results.Ok(employee) : Results.NotFound("Not Found");
});

/*
app.MapGet("/employees/{region}", (string region) =>
{
    Employee employee = employees.EmployeeList.Find(e => e.Region == region);
    return employee != null ? Results.Ok(employee) : Results.NotFound("Not Found");
});
*/

app.MapDelete("/employees/{id}", (int id) =>
{
    Employee employee = employees.EmployeeList.Find(e => e.Id == id);

    if (employee != null)
    {
        employees.EmployeeList.Remove(employee);
        return Results.Ok(employee.UserId);
    }

    return Results.NotFound("Not Found");
});

app.MapPost("/employees", (Employee employee) =>
{
    int id = employees.EmployeeList.Count() + 1;
    employee.Id = id;
    employees.EmployeeList.Add(employee);
    return Results.Ok(employee);
});

app.MapPut("/people/{id}", (int id, Employee putEmployee) =>
{
    Employee employee = employees.EmployeeList.Find(e => e.Id == id);

    if (employee != null)
    {
        employees.EmployeeList.Remove(employee);
        employees.EmployeeList.Add(putEmployee);
        return Results.Ok(putEmployee);
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
    var jsonData = File.ReadAllText("employees.json");
    Employees employees = JsonSerializer.Deserialize<Employees>(jsonData);

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


