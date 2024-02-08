using System.Text.Json.Serialization;

namespace Sinan_PokeDex.UI.Models.Sprite
{
    public class SpriteViewModel
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; } = null!;
    }
}
