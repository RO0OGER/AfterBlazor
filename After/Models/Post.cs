using Newtonsoft.Json;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

public class Post : BaseModel
{
    [PrimaryKey("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("date")]
    public DateTime Date { get; set; }

    [JsonProperty("img")]
    public string Img { get; set; }
}
