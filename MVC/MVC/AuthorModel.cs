using System.Text.Json;
namespace MVC;

public class AuthorModel
{
    public List<Authors> GetAllAuthors()
    {
        var json = System.IO.File.ReadAllText("Resources/Authors.json");
        return JsonSerializer.Deserialize<List<Authors>>(json) ?? new List<Authors>();
    }
}

