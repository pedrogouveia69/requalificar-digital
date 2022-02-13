using Ficha6;
using Newtonsoft.Json;
//using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var people = LoadJsonData();

app.MapGet("/", () => "Hello World");

app.MapGet("/people", () => 
{
    return people != null ? Results.Ok(people) : Results.NotFound("Not Found");
});

app.MapGet("/people/{id}", (int id) => 
{
    Person person = people.PersonList.Find(person => person.Id == id);
    return person != null ? Results.Ok(person) : Results.NotFound("Not Found");
});


app.MapPost("/people", (Person person) =>
{
    people.PersonList.Add(person);
    return Results.Ok(person);
});

app.MapDelete("/people/{id}", (int id) =>
{
    Person person = people.PersonList.Find(person => person.Id == id);

    if (person != null)
    {
        people.PersonList.Remove(person);
        return Results.Ok(person.Id);
    }

    return Results.NotFound("Not Found");
});

app.MapPut("/people/{id}", (int id, Person putPerson) =>
{
    Person person = people.PersonList.Find(person => person.Id == id);

    if (person != null)
    {
        people.PersonList.Remove(person);
        people.PersonList.Add(putPerson);
        return Results.Ok(putPerson);
    }

    return Results.NotFound("Not Found");
});

app.Run();

People LoadJsonData()
{
    StreamReader sr = new StreamReader("data.json");
    string jsonData = sr.ReadToEnd();
    People p = JsonConvert.DeserializeObject<People>(jsonData);

    /*
    var jsonData = File.ReadAllText("data.json");
    People p = JsonSerializer.Deserialize<People>(jsonData);
    */

    return p;
}



