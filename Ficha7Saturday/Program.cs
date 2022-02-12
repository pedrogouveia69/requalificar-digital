using Ficha7Saturday;
using System.Text.Json;

Employees JsonDeserialize()
{
    string jsonData = "";
    try 
    {
        jsonData = File.ReadAllText("employees.json");
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine(ex.Message);
        File.WriteAllText("employees.json", "{\"EmployeeList\": []}");
        jsonData = File.ReadAllText("employees.json");
    }
    return JsonSerializer.Deserialize<Employees>(jsonData);
}

var emps = JsonDeserialize();

void JsonSerialize() 
{
    File.WriteAllText("test.json", JsonSerializer.Serialize<Employees>(emps));
}

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

app.MapGet("/employees", () => emps.EmployeeList.Count > 0 ? Results.Ok(emps.EmployeeList) : Results.NotFound());

app.MapGet("/employees/{id:int}", (int id) =>
{
    var e = emps.EmployeeList.Find(e => e.UserId == id);
    return e != null ? Results.Ok(e) : Results.NotFound();
});

app.MapGet("/employees/{region}", (string region) =>
{
    var list = emps.EmployeeList.FindAll(e => e.Region == region.ToUpper());
    return list.Count > 0 ? Results.Ok(list) : Results.NotFound();
});

app.MapGet("/employees/download", () =>
{
    JsonSerialize();
    try
    {
        return Results.File(File.ReadAllBytes("test.json"), null, "employees.json");
    }
    catch (Exception ex)
    {
        return Results.NotFound(ex.Message);
    }   
});

app.MapPost("/employees", (Employee e) =>
{
    if(emps.EmployeeList.Count == 0)
    {
        e.UserId = 1;
    }
    else
    {
        var lastEmp = emps.EmployeeList.Last();
        e.UserId = lastEmp.UserId + 1;
    }

    emps.EmployeeList.Add(e);
    return Results.Created("employees/" + e.UserId, e);
});

app.MapPut("/employees/{id:int}", (int id, Employee putEmp) =>
{
    Employee e = emps.EmployeeList.Find(e => e.UserId == id);

    if (e != null)
    {
        e.JobTitle = putEmp.JobTitle;
        e.LastName = putEmp.LastName;
        e.PhoneNumber = putEmp.PhoneNumber;
        e.FirstName = putEmp.FirstName;
        e.Region = putEmp.Region;
        e.EmailAddress = putEmp.EmailAddress;
        e.EmployeeCode = putEmp.EmployeeCode;

        return Results.Ok(e);
    }
    else
    {
        return Results.NotFound();
    }

});

app.MapDelete("/employees/{id:int}", (int id) =>
{
    int r = emps.EmployeeList.RemoveAll(e => e.UserId == id);
    return r > 0 ? Results.Ok(id) : Results.NotFound(); 
});

app.Run();
