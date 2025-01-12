using Newtonsoft.Json;
using System;

public class Bewertung
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("joindate")]
    public DateTime Joindate { get; set; }

    [JsonProperty("purpose")]
    public string Purpose { get; set; }

    [JsonProperty("rate")]
    public int Rate { get; set; }

    [JsonProperty("date")]
    public DateTime Date { get; set; }
}
