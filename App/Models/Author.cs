﻿namespace App.Models
{
	public class Author
	{
        public int Id { get; set; }
		public string Name { get; set; }
        public ICollection<BookAuthor> BooksAuthors { get; set; } = new HashSet<BookAuthor>();
    }
}
