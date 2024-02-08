using System.Text.Json.Serialization;

namespace Sinan_PokeDex.UI.Models.Stat
{
    public class Stat2ViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; set; } = null!;
    }
}
