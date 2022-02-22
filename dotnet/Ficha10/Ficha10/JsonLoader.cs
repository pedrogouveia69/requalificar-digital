using Ficha7Saturday;
using FREQ_2019419;
using System.Text.Json;

namespace Ficha10
{
    public class JsonLoader
    {
        public static Employees DeserializeEmployees()
        {
            return JsonSerializer.Deserialize<Employees>(File.ReadAllText("employees.json"));
        }

        public static Characters DeserializeCharacters()
        {
            return JsonSerializer.Deserialize<Characters>(File.ReadAllText("characters.json"));
        }
    }
}
