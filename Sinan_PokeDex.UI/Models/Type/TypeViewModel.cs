using System.Text.Json.Serialization;

namespace Sinan_PokeDex.UI.Models.Type
{
    public class TypeViewModel
    {
        [JsonPropertyName("slot")]
        public int Slot { get; set; }

        [JsonPropertyName("type")]
        public Type2ViewModel Type2 { get; set; } = null!;
    }
}
