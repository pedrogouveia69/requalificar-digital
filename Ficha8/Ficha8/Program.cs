using Ficha8;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var employees = DeserializeEmployees();

app.MapGet("/", () => "Home Page");

app.MapGet("/employees", () =>
{
    var emps = employees.EmployeeList.FindAll(e => e.Deleted == false);
    return emps.Count > 0 ? Results.Ok(emps) : Results.NotFound("Not Found");
});

app.MapGet("/employees/{id:int}", (int id) =>
{
    var employee = employees.EmployeeList.Find(e => e.Id == id && e.Deleted == false);
    return employee != null ? Results.Ok(employee) : Results.NotFound("Not Found");
});

app.MapGet("/employees/{region}", (string region) =>
{
    var emps = employees.EmployeeList.FindAll(e => e.Region == region.ToUpper() && e.Deleted == false);
    return emps.Count > 0 ? Results.Ok(emps) : Results.NotFound("Not Found");
});

app.MapGet("/employees/download", () =>
{
    string data = JsonSerializer.Serialize(employees);
    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
    //byte[] bytes2 = File.ReadAllBytes("employees.json");

    return Results.File(bytes, null, "employees.json");

});

app.MapPost("/employees", (Employee employee) =>
{
    int id = employees.EmployeeList.Count() + 1;
    employee.Id = id;
    employees.EmployeeList.Add(employee);
    SerializeEmployees(employees);
    return Results.Created("/employees", employee);
});

app.MapPut("/employees/{id}", (int id, Employee putEmployee) =>
{
    var employee = employees.EmployeeList.Find(e => e.Id == id && e.Deleted == false);

    if (employee != null)
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
    var employee = employees.EmployeeList.Find(e => e.Id == id && e.Deleted == false);

    if (employee != null)
    {
        employee.Deleted = true;
        SerializeEmployees(employees);
        return Results.Ok(employee.Id);
    }

    return Results.NotFound("Not Found");
});

app.Run();

void SerializeEmployees(Employees employees)
{
    string jsonString = JsonSerializer.Serialize(employees);
    File.WriteAllText("employees.json", jsonString);
}

Employees DeserializeEmployees()
{
    Employees employees = new Employees();
    var jsonData = File.ReadAllText("employees.json");
    if (jsonData.Length != 0)
        employees = JsonSerializer.Deserialize<Employees>(jsonData);

    return employees;
}
