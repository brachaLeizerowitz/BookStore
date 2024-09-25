using BookStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
        public string NewBook(Book book);

        public void DeleteBook(string bookUPC);
    }
}
