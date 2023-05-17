using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models
{
	public class Book
	{
		public int Id { get; set; }
        public string Title { get; set; }
		public string Description { get; set; }

		[DataType(DataType.Date)]
		[Column(TypeName = "Date")]
		public DateTime PublishedOn { get; set; }

        public string Publisher { get; set; }
        public int Price { get; set; }
        public string ImgUrl { get; set; }
		public ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
		public ICollection<BookAuthor> BooksAuthors { get; set; } = new HashSet<BookAuthor>();

	}
}
