using BookStore.BL.Interfaces;
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
    }
}
