using Newtonsoft.Json;
using System.Data.SqlClient;

var payload = JsonConvert.SerializeObject(new { message = "Hello, World!" });
Console.WriteLine(payload);

using var connection = new SqlConnection("Server=(local);Database=Demo;Integrated Security=true;");
Console.WriteLine($"Connection state: {connection.State}");
