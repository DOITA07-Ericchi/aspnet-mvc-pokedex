using Microsoft.AspNetCore.Mvc;
using Pokédex.Database;
using Pokédex.Models;

namespace Pokédex.Controllers
{
	public class PokemonController : Controller
	{
		public IActionResult Index()
		{
			using (PokedexContext db = new PokedexContext())
			{
				List<Pokemon> PokemonList = db.Pokemons.ToList<Pokemon>();
                return View("Index", PokemonList);
            }
		}
	}
}
