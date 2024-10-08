﻿using BookStore.DAL.Entities;
using BookStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Interfaces
{
    public interface IBook
    {
        public List<Book> GetAllBooks();

        public string NewBook(Book book);


        public void DeleteBook(string bookUPC);
    }
}
