using Ficha10.Models;
using Ficha7Saturday;
using System.Text.Json;

namespace Ficha10
{
    public class JsonLoader
    {
        public static List<Employee> DeserializeEmployees()
        {
            try
            {
                return JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText("employees.json"));
            }
            catch(FileNotFoundException e)
            {
                File.WriteAllText("employees.json", "[]");
                return new List<Employee>();
            }
        }
    }
}
