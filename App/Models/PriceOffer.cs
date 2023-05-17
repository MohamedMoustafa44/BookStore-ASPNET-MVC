using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
	public class PriceOffer
	{
        public int Id { get; set; }
        public int NewPrice { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        Book Book = new Book();
    }
}
