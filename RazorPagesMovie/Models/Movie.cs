using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        public string? Title { get; set; }
        [Display(Name = "Gênero")]
        public string? Genere { get; set; }
        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }
    }
}
