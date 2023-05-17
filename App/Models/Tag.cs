using System.ComponentModel.DataAnnotations;

namespace App.Models
{
	public class Tag
	{
		[Key]
        public int Id { get; set; }
		public string Name { get; set; }
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
