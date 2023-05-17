using Microsoft.EntityFrameworkCore;

namespace App.Models
{
	public class DBConverter : DbContext
	{
        public DBConverter(DbContextOptions options) : base(options)
        {
            
        }
        public virtual DbSet<Book> Books { get; set; }
		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Tag> Tags { get; set; }
		public virtual DbSet<BookAuthor> BooksAuthors { get; set; }
		public virtual DbSet<PriceOffer> PriceOffers { get; set; }
		public virtual DbSet<Review> Reviews { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BookAuthor>()
				.HasKey(a => new { a.BookId, a.AuthorId });
			base.OnModelCreating(modelBuilder);
		}


	}
}
