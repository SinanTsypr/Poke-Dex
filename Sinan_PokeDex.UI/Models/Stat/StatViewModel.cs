using System.Text.Json.Serialization;

namespace Sinan_PokeDex.UI.Models.Stat
{
    public class StatViewModel
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }

        [JsonPropertyName("effort")]
        public int Effort { get; set; }

        [JsonPropertyName("stat")]
        public Stat2ViewModel Stat2 { get; set; } = null!;
    }
}
