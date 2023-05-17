using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
	public class BookAuthor
	{
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public int? Orders { get; set; }
        public Book Book = new Book();
        public Author Author = new Author();
    }
}
