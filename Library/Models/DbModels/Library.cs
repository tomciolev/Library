using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Library.Models.DbModels
{
    public class Library
    {
        public int LibraryId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }


        public Library() { }

        public Library(int libraryId, string name, List<Book> books)
        {
            Books = new List<Book>();
            LibraryId = libraryId;
            Name = name;
            Books = books;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(LibraryId).Append(Name).Append(Name);
            foreach (Book book in Books)
                sb.AppendLine(book.ToString());
            return sb.ToString();
        }
    }
}