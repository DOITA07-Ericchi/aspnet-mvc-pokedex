using Microsoft.EntityFrameworkCore;
using Pokédex.Models;

namespace Pokédex.Database
{
	public class PokedexContext : DbContext
	{
		public DbSet<Pokemon> Pokemons { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost;Database=PokedexV1;" +
			"Integrated Security=True;TrustServerCertificate=True");
		}
	}
}
