using System.Text.Json.Serialization;

namespace StateManagement.Session_.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
}
public class UserCreate
{
    public UserCreate()
    {
        this.Code = 123456; // _codeSercive.Generate();
    }

    [JsonIgnore]
    public int Code { get; set; }
    public int UserCode { get; set; }
}