using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokédex.Models
{
	public class Pokemon
	{
		public int ID { get; set; }

		[Column(TypeName = "integer")]
		public int No { get; set; }

		[Column(TypeName = "varchar(10)")]
		public string Nome { get; set; }

		[Column(TypeName = "text")]
		public string Descrizione { get; set; }

		[Column(TypeName = "tinyint")]
		public int Tipo1 { get; set; }

		[Column(TypeName = "tinyint")]
		public int Tipo2 { get; set; }

		[Column(TypeName = "varchar(100)")]
		public string Immagine { get; set; }

		[Column(TypeName = "tinyint")]
		public int Stato { get; set; }

		public Pokemon()
		{

		}

		public Pokemon(int id, string nome, string descrizione, int tipo1, int tipo2, string immagine, int stato)
		{
			ID = id;
			Nome = nome;
			Descrizione = descrizione;
			Tipo1 = tipo1;
			Tipo2 = tipo2;
			Immagine = immagine;
			Stato = stato;
		}
	}
}
