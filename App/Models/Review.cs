using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
	public class Review
	{
		public int Id { get; set; }
        public string VoterName { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        Book Book = new Book();
    }
}
