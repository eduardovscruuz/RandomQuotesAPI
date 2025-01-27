using System.Text.Json.Serialization;

namespace RandomQuotesAPI.Models
{
    public class Quote
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        // Mapeando os nomes das propriedades para os do JSON
        [JsonPropertyName("character")]
        public string Character { get; set; }

        [JsonPropertyName("quote")]
        public string QuoteText { get; set; }
    }
}

