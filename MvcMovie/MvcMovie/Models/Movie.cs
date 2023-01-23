using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [StringLength(60,MinimumLength =3)]
        public string? Title { get; set; }

        [Display(Name ="Release Date"),DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)] //The ApplyFormatInEditMode setting specifies that the formatting should also be applied when the value is displayed in a text box for editing.

        //[Range(typeof(DateTime), "1/1/1966", "1/1/2020")] - date in specific range
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"),Required,StringLength(30)]
        public string? Genre { get; set; }

        [Range(1,100),DataType(DataType.Currency),Column(TypeName ="decimal(18,2)")]
        //decimal, float, integer inherently required and don't need the [Required] attribute.
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"),StringLength(5)]
        public string? Rating { get; set; }
    }
}
