namespace FilipinoSlangs.Models 
{
    using System.Text.Json.Serialization;
    public class FilipinoSlang
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("phrase")]
        public string Phrase { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }


        [JsonPropertyName("englishEquivalent")]
        public string? EnglishEquivalent { get; set; }

    }
}
