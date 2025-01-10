using Supabase.Postgrest.Models;
using System.Text.Json.Serialization;

public class Post : BaseModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("date")]
    public string Date { get; set; }

    [JsonPropertyName("img")]
    public string Img { get; set; }
    
}
    
