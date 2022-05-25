using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Library.Models.DbModels
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Book> Books { get; set; }


        public Author() { }

        public Author(int authorId, string name, string surname, List<Book> books)
        {
            Books = new List<Book>();
            AuthorId = authorId;
            Name = name;
            Surname = surname;
            Books = books;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AuthorId).Append(Name).Append(Surname);
            foreach (Book book in Books)
                sb.AppendLine(book.ToString());
            return sb.ToString();
        }
    }
}