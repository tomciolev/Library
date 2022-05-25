﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models.DbModels
{
    public class Book
    {
        //wlasciwosci potrzebne do mapowania 
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int LibraryId { get; set; }
        public virtual Library Library { get; set; }
        //wlasciwosci Book
        public int BookId { get; set; }
        public string Title { get; set; }
        public BookType BookType { get; set; }

        public Book() { }
        public Book(int bookId, string title, BookType bookType)
        {
            BookId = bookId;
            Title = title;
            BookType = bookType;
        }

        public override string ToString()
        {
            return $"{BookId} {Title} {BookType}";
        }
    }
    public enum BookType { Fantasy, Other }
}