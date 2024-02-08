using System.Text.Json.Serialization;

namespace Sinan_PokeDex.UI.Models.Type
{
    public class Type2ViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; set; } = null!;
    }
}
