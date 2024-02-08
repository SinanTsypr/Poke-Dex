using Sinan_PokeDex.UI.Models.Sprite;
using Sinan_PokeDex.UI.Models.Stat;
using Sinan_PokeDex.UI.Models.Type;
using System.Text.Json.Serialization;

namespace Sinan_PokeDex.UI.Models.Pokemon
{
    public class PokemonViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        [JsonPropertyName("weight")]
        public int Weight { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("sprites")]
        public SpriteViewModel Sprite { get; set; } = null!;

        [JsonPropertyName("stats")]
        public List<StatViewModel> Stats { get; set; } = new();

        [JsonPropertyName("types")]
        public List<TypeViewModel> Types { get; set; } = new();
    }
}
