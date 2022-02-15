using FREQ_2019419;
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

Characters Deserialize()
{
    try
    {
        return JsonSerializer.Deserialize<Characters>(File.ReadAllText("characters.json"));
    }
    catch (FileNotFoundException ex)
    {
        Console.Error.WriteLine(ex.Message);
        File.WriteAllText("characters.json", "{\"CharactersList\":[]}");
        return new Characters();
    }    
}

var characters = Deserialize();


app.MapGet("/characters", () =>
{
    if(characters.CharactersList.Count > 0)
    {
        return Results.Ok(characters.CharactersList);
    }
    return Results.NotFound("Not Found.");
});

app.MapGet("/characters/{id:int}", (int id) =>
{
    var c = characters.CharactersList.Find(c => c.Id == id);
    return c != null ? Results.Ok(c) : Results.NotFound("Id " + id + " not found.");
});

app.MapGet("/characters/{gender}", (string gender) =>
{
    List<Character> c = characters.CharactersList.FindAll(c => c.Gender == gender.ToLower());
    return c.Count > 0 ? Results.Ok(c) : Results.NotFound("Not found.");
});

app.MapGet("/characters/jedi", () =>
{
    List<Character> c = characters.CharactersList.FindAll(c => c.Jedi);
    return c.Count > 0 ? Results.Ok(c) : Results.NotFound("Not found.");
});

app.MapGet("/characters/download", () =>
{
    File.WriteAllText("characters.json", JsonSerializer.Serialize(characters));
    try
    {
        return Results.File(File.ReadAllBytes("characters.json"), null, "characters.json");
    }
    catch (FileNotFoundException ex)
    {
        return Results.NotFound(ex.Message);
    }  
});

app.MapPost("/characters", (Character c) =>
{
    if(characters.CharactersList.Count == 0)
        c.Id = 1;
    else
        c.Id = characters.CharactersList.Last().Id + 1;
    characters.CharactersList.Add(c);
    return Results.Created("/characters/" + c.Id, c);
});

app.MapPut("/characters/{id:int}", (int id, Character putCharacter) =>
{
    var c = characters.CharactersList.Find(c => c.Id == id);
    if (c != null)
    {
        c.Name = putCharacter.Name;
        c.Gender = putCharacter.Gender;
        c.Homeworld = putCharacter.Homeworld;
        c.Born = putCharacter.Born;
        c.Jedi = putCharacter.Jedi;

        return Results.Ok(c);
    }

    return Results.NotFound("Id " + id + " not found.");
});

app.MapDelete("/characters/{id:int}", (int id) =>
{
    int r = characters.CharactersList.RemoveAll(c => c.Id == id);
    return r > 0 ? Results.Ok(id) : Results.NotFound("Id " + id + " not found.");
});

app.Run();

