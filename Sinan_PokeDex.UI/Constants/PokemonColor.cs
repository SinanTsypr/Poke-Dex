namespace Sinan_PokeDex.UI.Constants
{
    public class PokemonColor
    {
        public static string GetTypeColor(string type)
        {
            string color = type switch
            {
                "bug" => "#26de81",
                "dragon" => "#ffeaa7",
                "electric" => "#fed330",
                "fairy" => "#FF0069",
                "fighting" => "#30336b",
                "fire" => "#f0932b",
                "flying" => "#81ecec",
                "grass" => "#00b894",
                "ground" => "#EFB549",
                "ghost" => "#a55eea",
                "ice" => "#74b9ff",
                "normal" => "#95afc0",
                "poison" => "#6c5ce7",
                "psychic" => "#a29bfe",
                "rock" => "#2d3436",
                "water" => "#0190FF",
                _ => "#0190FF"
            };

            return color;
        }

        public static string GetStatColor(string stat)
        {
            string color = stat switch
            {
                "hp" => "#FE0000",
                "attack" => "#EE7F30",
                "defense" => "#F7D02C",
                "special-attack" => "#F85687",
                "special-defense" => "#77C755",
                "speed" => "#678FEE",
                _ => "#0190FF"
            };

            return color;
        }
    }
}
