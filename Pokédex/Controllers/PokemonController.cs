using Microsoft.AspNetCore.Mvc;

namespace Pokédex.Controllers
{
	public class PokemonController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
