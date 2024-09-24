using BookStore.BL.Interfaces;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class BookSrvice:IBookService
    {
        private IBook _book;

        public BookSrvice(IBook book)
        {
            _book = book;   
        }

        public List<Book> GetAllBooks()
        {
            return _book.GetAllBooks();
        }

        public string CreateBook(Book book)
        {
            //איך מוסיפים לסטרינג ניו?
           // book.Upc=new();
            return _book.CreateBook(book);
        }
    }

}
