using BookStore.DAL.DataContext;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    public class BookRepository : IBook
    {
        private BookStoreContext _db;

        public BookRepository(BookStoreContext db)
        {
            _db = db;
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();

        }
         


    }
}
