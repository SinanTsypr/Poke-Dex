using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Sinan_PokeDex.UI.Models;
using Sinan_PokeDex.UI.Models.Pokemon;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sinan_PokeDex.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int id = 20)
        {
            List<PokemonViewModel> pokemonList = new List<PokemonViewModel>();

            var client = _httpClientFactory.CreateClient();
            for (int i = 1; i <= id; i++)
            {
                var responseMessage = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{i}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonSerializer.Deserialize<PokemonViewModel>(jsonData);
                    pokemonList.Add(values!);
                }
            }
            return View(pokemonList);
        }

        public async Task<IActionResult> PokemonDetails(int? id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<PokemonViewModel> (jsonData);
                return PartialView("_PokemonDetailPartial", values);
            }

            return BadRequest();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
