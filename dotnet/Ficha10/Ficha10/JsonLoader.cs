using Ficha10.Models;
using Ficha7Saturday;
using FREQ_2019419;
using System.Text.Json;

namespace Ficha10
{
    public class JsonLoader
    {
        public static List<Employee> DeserializeEmployees()
        {
            return JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText("employees.json"));
        }

        public static Characters DeserializeCharacters()
        {
            return JsonSerializer.Deserialize<Characters>(File.ReadAllText("characters.json"));
        }
    }
}
