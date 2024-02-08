namespace Sinan_PokeDex.UI.Constants
{
    public static class PokemonUtil
    {
        public const string Pokeball = "ball-1.png";
        public const string GreatBall = "ball-2.png";
        public const string UltraBall = "ball-3.png";
        public static string GetRandomBall()
        {
            var pokeballArray = new string[] { Pokeball, GreatBall, UltraBall };
            var rand = new Random();
            string randomBall = pokeballArray[rand.Next(pokeballArray.Length)];
            return randomBall;
        }
        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }
        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}
